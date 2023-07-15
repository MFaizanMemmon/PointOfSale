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

namespace CosmaticProject.Forms.User_Forms
{
    public partial class frmCreateNewUser : Form
    {
        public frmCreateNewUser()
        {
            InitializeComponent();
        }

        private void frmCreateNewUser_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == string.Empty)
            {
                ep.SetError(txtSearch, "Please Enter User ID");
                txtSearch.Focus();
                return;
            }
            string query = string.Format("select * from tblEmployee where EmpID = {0} where IsActive = 1",txtSearch.Text);
            DataTable dt = DataAccess.Retrive(query);
            if (dt.Rows.Count > 0)
            {

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == string.Empty)
            {
                ep.SetError(txtUserName, "Please Enter User Name");
                txtUserName.Focus();
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                ep.SetError(txtPassword, "Please Enter Password");
                txtPassword.Focus();
                return;
            }
            else if (txtConfirmPassword.Text.Trim() == string.Empty && txtConfirmPassword.Text != txtPassword.Text)
            {
                ep.SetError(txtConfirmPassword, "Please Enter Password");
                txtConfirmPassword.Focus();
                return;
            }

            string query = string.Format("update tblEmployee set UserName = '{0}' , Password = '{1}' where EmpID = {2}",txtUserName.Text.Trim(),txtPassword.Text.Trim(),Convert.ToInt16(txtSearch.Text.Trim()));

            if (DataAccess.Crud(query))
            {
                MessageBox.Show("User Password has been Saved...");
            }


        }
    }
}
