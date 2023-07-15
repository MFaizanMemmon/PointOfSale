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

namespace CosmaticProject.Forms.Customer
{
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void FillGrid(string SearchValue)
        {
            string query = "select CustomerID,Name,ContactNo,Address,Description from tblCustomer";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select CustomerID,Name,ContactNo,Address,Description from tblCustomer where Name like '%" + SearchValue + "%'";

            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgvCustomer.DataSource = dt;
                if (dt.Rows.Count > 0)
                {

                    //dgvUserType.Columns[0].Width = 100;
                    //dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvCustomer.DataSource = null;
            }
        }

        private void ClearField()
        {
            txtCustomer.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtCustomer.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Customer");
                txtCustomer.Focus();
                return;
            }

            string query = string.Format("insert into tblCustomer values ({0},'{1}','{2}','{3}','{4}')",UserInfo.EmployeeID,txtCustomer.Text,txtContact.Text,txtAddress.Text,txtDescription.Text);
            if (DataAccess.Crud(query))
            {
                MessageBox.Show("Customer has been Saved");
                FillGrid(string.Empty);
                ClearField();
            }
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }
    }
}
