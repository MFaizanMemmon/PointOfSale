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

namespace CosmaticProject.Forms.User_Forms
{
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
            if (IsLogin(txtUserName.Text,txtPassword.Text))
            {
                this.Close();
            }
            
 
        }

        private bool IsLogin(string UserName, string Password)
        {
            DataTable dt = new DataTable();
            string query = string.Format("select * from tblEmployee where UserName = '{0}' and Password = '{1}'",UserName,Password);
            dt = DataAccess.Retrive(query);
            if (dt.Rows.Count > 0)
            {
                UserInfo.EmployeeID = Convert.ToInt32(dt.Rows[0][0]);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
