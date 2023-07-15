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

namespace CosmaticProject.Forms.Stock
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void FillGrid(string SearchValue)
        {
            string query = "select CategoryID as 'ID',Name as 'Product Category' from tblCategory";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select CategoryID as 'ID',Name as 'Product Category' from tblCategory where Name like '%" + SearchValue + "%'";

            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgvProductCategory.DataSource = dt;
                if (dt.Rows.Count > 0)
                {

                    dgvProductCategory.Columns[0].Width = 100;
                    dgvProductCategory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvProductCategory.DataSource = null;
            }
        }

        private void ResetComponent()
        {
            btnCancle.Enabled = false;
            btnUpdate.Enabled = false;
            dgvProductCategory.Enabled = true;
            BtnSave.Enabled = true;
            txtSearch.Enabled = true;
            FillGrid(string.Empty);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtCategory.Text.Trim().Length == 0)
            {
                txtCategory.Clear();
                txtCategory.Focus();
                ep.SetError(txtCategory, "Please Enter Category");
                return;
            }
            DataTable dt = DataAccess.Retrive("select * from tblCategory where Name ='"+txtCategory.Text+"'");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCategory, "Already Registered");
                    txtCategory.Focus();
                    txtCategory.SelectAll();
                    return;
                }
            }

            string query = string.Format("insert into tblCategory (EmployeeID , Name) values({0},'{1}')",UserInfo.EmployeeID,txtCategory.Text);
            bool result = DataAccess.Crud(query);
            if (result)
            {
                btnClear_Click(sender, e);
                MessageBox.Show("Saved Successfully");
                FillGrid(string.Empty);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            if (dgvProductCategory.Rows.Count > 0)
            {
                if (dgvProductCategory.SelectedRows.Count == 1)
                {
                    txtCategory.Text = Convert.ToString(dgvProductCategory.CurrentRow.Cells[1].Value);
                    EnableComponents();
                }
                else
                {
                    MessageBox.Show("Warning", "Please Select one Record !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text);
        }

        private void EnableComponents()
        {
            btnCancle.Enabled = true;
            btnUpdate.Enabled = true;
            dgvProductCategory.Enabled = false;
            BtnSave.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtCategory.Text.Trim().Length == 0)
            {
                ep.SetError(txtCategory, "Please Enter User Type Titile");
                txtCategory.Focus();
                return;
            }
            DataTable dt = DataAccess.Retrive("select * from tblCategory where Name = '" + txtCategory.Text + "'");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtCategory, "Already Registered");
                    txtCategory.Focus();
                    txtCategory.SelectAll();
                    return;
                }
            }

            string UpdateQuery = "update tblCategory set Name = '" + txtCategory.Text + "',EmployeeID = '"+UserInfo.EmployeeID+"' where CategoryID=" + Convert.ToString(dgvProductCategory.CurrentRow.Cells[0].Value);
            bool result = DataAccess.Crud(UpdateQuery);
            if (result)
            {
                ResetComponent();
                MessageBox.Show("Update Successfully");
            }
            else
            {
                ep.SetError(btnUpdate, "Please Try Again");
            }

        }
    }
}
