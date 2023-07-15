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

namespace CosmaticProject.Forms.Expense_Form
{
    public partial class frmExpensesCategory : Form
    {
        public frmExpensesCategory()
        {
            InitializeComponent();
        }

        private void FillGrid(string SearchValue)
        {
            string query = "select ExpCategoryID,Name from tblExpensesCategory";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select ExpCategoryID,Name from tblExpensesCategory where Name like '" + SearchValue + "%'";

            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgCategory.DataSource = dt;
                if (dt.Rows.Count > 0)
                {

                    //dgvUserType.Columns[0].Width = 100;
                    //dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgCategory.DataSource = null;
            }
        }

        private void Clear()
        {
            txtCategory.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtCategory.Text.Trim().Length == 0)
            {
                txtCategory.Clear();
                txtCategory.Focus();
                ep.SetError(txtCategory, "Please Enter Category");
                return;
            }
            DataTable dt = DataAccess.Retrive("select * from tblExpensesCategory where Name ='" + txtCategory.Text + "'");

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

            string query = string.Format("insert into tblExpensesCategory (Name,EmployeeID) values('{0}',{1})", txtCategory.Text , UserInfo.EmployeeID);
            bool result = DataAccess.Crud(query);
            if (result)
            {
                FillGrid(string.Empty);
                btnClear_Click(sender, e);
                MessageBox.Show("Saved Successfully");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            txtCategory.Focus();
        }

        private void frmExpensesCategory_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillGrid(textBox1.Text.Trim());
        }
    }
}
