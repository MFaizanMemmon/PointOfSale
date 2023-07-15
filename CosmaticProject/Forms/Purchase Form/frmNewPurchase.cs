using CosmaticProject.Database_Layer;
using CosmaticProject.Source_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmaticProject.Forms.Purchase_Form
{
    public partial class frmNewPurchase : Form
    {
        public string SupplierID { get; set; }
        public frmNewPurchase()
        {
            InitializeComponent();

        }

        private void txtSearchSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmSearchSupplier searchSupplier = new frmSearchSupplier(txtSearchSupplier.Text.Trim(), this);
                searchSupplier.ShowDialog();
            }
        }

        private void frmNewPurchase_Load(object sender, EventArgs e)
        {
            ComboHelper.FillProductCategory(cmbCategoryType);
        }

        private void cmbCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {


            ComboHelper.FillProductByCategory(cmbProduct, cmbCategoryType.SelectedValue.ToString());
        }

        private void GetProductDetail(string ProductID)
        {
            string query = string.Format("select CurrentPurchaseUnitPrice,Qty,SaleUnitPrice from tblProduct where ItemID = {0}", ProductID);
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                lblCurrentPurchaseUnit.Text = dt.Rows[0][0].ToString();
                lblCurrentQty.Text = dt.Rows[0][1].ToString();
                lblCurrentSaleUnit.Text = dt.Rows[0][2].ToString();
                txtSalePrice.Text = dt.Rows[0][2].ToString();
                txtPurchasePrice.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                lblCurrentPurchaseUnit.Text = "";
                lblCurrentQty.Text = "";
                lblCurrentSaleUnit.Text = "";
                txtSalePrice.Text = "0";
                txtPurchasePrice.Text = "0";
            }

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue != null)
            {
                GetProductDetail(cmbProduct.SelectedValue.ToString());
            }

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CalculateItemCost()
        {
            try
            {
                float qty = 0;
                float.TryParse(txtQty.Text.Trim(), out qty);


                float purUnitPrice = 0;
                float.TryParse(txtPurchasePrice.Text.Trim(), out purUnitPrice);

                lblItemCost.Text = Convert.ToString(qty * purUnitPrice);

            }
            catch (Exception)
            {

                lblItemCost.Text = "0";
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            CalculateItemCost();
        }

        private void ClearField()
        {
            cmbCategoryType.SelectedIndex = 0;
            //cmbProduct.SelectedIndex = 0;
            txtPurchasePrice.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtSalePrice.Text = string.Empty;
            lblCurrentPurchaseUnit.Text = string.Empty;
            lblCurrentQty.Text = string.Empty;
            lblCurrentSaleUnit.Text = string.Empty;
        }

        private void EnableField()
        {
           
            btnAdd.Visible = false;
            btnClear.Visible = false;
            dgvInvoice.Enabled = false;
            txtSearchSupplier.Enabled = false;
        }

        private void DisableField()
        {
           
            btnAdd.Visible = true;
            btnClear.Visible = true;
            dgvInvoice.Enabled = true;
            txtSearchSupplier.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (cmbCategoryType.SelectedIndex == 0)
            {
                ep.SetError(cmbCategoryType, "Please Select Category");
                cmbCategoryType.Focus();
                return;
            }
            string CategoryID = Convert.ToString(cmbCategoryType.SelectedValue);
            string CategoryName = cmbCategoryType.Text;

            string ProductID = Convert.ToString(cmbProduct.SelectedValue);
            string ProductName = cmbProduct.Text;

            float qty = 0;
            float.TryParse(txtQty.Text.Trim(), out qty);

            float perUnitPrice = 0;
            float.TryParse(txtPurchasePrice.Text.Trim(), out perUnitPrice);

            float saleUnitPrice = 0;
            float.TryParse(txtSalePrice.Text.Trim(), out saleUnitPrice);

            float itemCost = 0;
            float.TryParse(lblItemCost.Text.Trim(), out itemCost);

            if (qty == 0)
            {
                ep.SetError(txtQty, "Please Enter Purchase Quantity");
                txtQty.Focus();
                txtQty.SelectAll();
                return;
            }

            if (perUnitPrice == 0)
            {
                ep.SetError(txtPurchasePrice, "Please Enter Purchase Price");
                txtPurchasePrice.Focus();
                txtPurchasePrice.SelectAll();
                return;
            }

            foreach (DataGridViewRow item in dgvInvoice.Rows)
            {
                if (cmbCategoryType.Text == item.Cells[3].Value.ToString() && cmbProduct.Text == item.Cells[1].Value.ToString())
                {
                    ep.Clear();
                    ep.SetError(cmbProduct, "This Product is already exists");
                    cmbProduct.Focus();
                    return;
                }
            }

            DataGridViewRow addItem = new DataGridViewRow();
            addItem.CreateCells(dgvInvoice);
            addItem.Cells[0].Value = ProductID;
            addItem.Cells[1].Value = ProductName;
            addItem.Cells[2].Value = CategoryID;
            addItem.Cells[3].Value = CategoryName;
            addItem.Cells[4].Value = qty;
            addItem.Cells[5].Value = perUnitPrice;
            addItem.Cells[6].Value = saleUnitPrice;
            addItem.Cells[7].Value = itemCost;
            dgvInvoice.Rows.Add(addItem);
            ClearField();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoice != null)
            {
                if (dgvInvoice.Rows.Count > 0)
                {
                    if (dgvInvoice.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to delete these record","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            dgvInvoice.Rows.RemoveAt(dgvInvoice.CurrentRow.Index);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select any Item");
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInvoice != null)
            {
                if (dgvInvoice.SelectedRows.Count == 1)
                {
                    DataGridViewRow currentRow = dgvInvoice.CurrentRow;

                    cmbCategoryType.SelectedValue = currentRow.Cells[2].Value;
                    cmbProduct.SelectedValue = currentRow.Cells[0].Value;
                    txtQty.Text = currentRow.Cells[4].Value.ToString();
                    txtPurchasePrice.Text = currentRow.Cells[5].Value.ToString();
                    txtSalePrice.Text = currentRow.Cells[6].Value.ToString();
                    lblItemCost.Text = currentRow.Cells[7].Value.ToString();
                    DisableField();
                }
                else
                {
                    MessageBox.Show("Please select one Record");
                }
            }
        }
    }
}
