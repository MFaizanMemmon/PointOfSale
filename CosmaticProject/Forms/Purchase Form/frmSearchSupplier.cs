using CosmaticProject.Database_Layer;
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
    public partial class frmSearchSupplier : Form
    {
        frmNewPurchase purchase;
        public frmSearchSupplier(string v, frmNewPurchase frmNewPurchase)
        {
            InitializeComponent();
            purchase = frmNewPurchase;
            txtSearch.Text = v;

        }

        private void FillGrid(string SearchValue)
        {
            string query = "select SupplierID,Name, ContactNo,Address,Description from tblSupplier";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select SupplierID,Name, ContactNo,Address,Description from tblSupplier where Name like '%" + SearchValue + "%'";

            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgvSupplier.DataSource = dt;
                if (dt.Rows.Count > 0)
                {

                    
                    //dgvUserType.Columns[0].Width = 100;
                    //dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvSupplier.DataSource = null;
            }
        }

        private void frmSearchSupplier_Load(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text);
        }

        private void frmSearchSupplier_Activated(object sender, EventArgs e)
        {
            dgvSupplier.Focus();
        }

        private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvSupplier.Rows.Count > 0)
                {
                    if (dgvSupplier.SelectedRows.Count == 1)
                    {
                        SelectSupplier();
                    }
                }
                else
                {
                    dgvSupplier.Rows[0].Selected = true;
                    SelectSupplier();
                }
            }
        }

        private void SelectSupplier()
        {
            if (purchase != null)
            {
                purchase.SupplierID = Convert.ToString(dgvSupplier.CurrentRow.Cells[0].Value);
                purchase.lblSupplier.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[1].Value);
                purchase.lblContact.Text = Convert.ToString(dgvSupplier.CurrentRow.Cells[2].Value);

                this.Close();
            }
        }
    }
}
