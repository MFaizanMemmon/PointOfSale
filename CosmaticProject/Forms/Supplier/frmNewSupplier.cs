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

namespace CosmaticProject.Forms.Supplier
{
    public partial class frmNewSupplier : Form
    {
        public frmNewSupplier()
        {
            InitializeComponent();
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

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSupplier.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Customer");
                txtSupplier.Focus();
                return;
            }

            string query = string.Format("insert into tblSupplier values ({0},'{1}','{2}','{3}','{4}')", UserInfo.EmployeeID, txtSupplier.Text, txtContact.Text, txtAddress.Text, txtDescription.Text);
            if (DataAccess.Crud(query))
            {
                MessageBox.Show("Supplier has been Saved");
                FillGrid(string.Empty);
            }
        }
    }
}
