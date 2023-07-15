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

namespace CosmaticProject.Forms.Employee_Forms
{
    public partial class frmSearchEmployee : Form
    {
        public frmSearchEmployee()
        {
            InitializeComponent();
        }

        private void FillGrid(string SearchValue)
        {
            string query = "select e.EmpID,e.FullName,u.UserType,e.ContactNo,e.Email,e.Address,e.IsActive from tblEmployee as e inner join tblUserType as u on u.UserTypeID = e.UserTypeID";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select e.EmpID,e.FullName,u.UserType,e.ContactNo,e.Email,e.Address,e.IsActive from tblEmployee as e inner join tblUserType as u on u.UserTypeID = e.UserTypeID where FullName like'%" + SearchValue + "%'";

            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgvUserType.DataSource = dt;
                if (dt.Rows.Count > 0)
                {

                    //dgvUserType.Columns[0].Width = 100;
                    //dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvUserType.DataSource = null;
            }
        }

        private void frmSearchEmployee_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }
    }
}
