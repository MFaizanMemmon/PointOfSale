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
using System.IO;


namespace CosmaticProject.Forms.Employee_Forms
{
    public partial class frmEmpRegistration : Form
    {
        public frmEmpRegistration()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            cmbUserType.SelectedIndex = 0;
            txtContact.Clear();
            txtEmail.Clear();
            txtCnic.Clear();
            txtAddress.Clear();
            txtDiscription.Clear();
            PicEmp.Image = null;
            txtSearch.Clear();
        }

        private void FillGrid(string SearchValue)
        {
            string query = "select EmpID as 'ID',FullName as 'Name',UserTypeID as 'User Type ID',ContactNo 'Contact',Email as 'Email',CNIC,Photo,[Address] as 'Address',Description,IsActive as 'Status'from tblEmployee";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select EmpID as 'ID',FullName as 'Name',UserTypeID as 'User Type ID',ContactNo 'Contact',Email as 'Email',CNIC,Photo,[Address] as 'Address',Description,IsActive as 'Status'from tblEmployee where FullName like '%"+SearchValue+ "%'";

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


        private void frmEmpRegistration_Load(object sender, EventArgs e)
        {
            ComboHelper.FillUserType(cmbUserType);
            FillGrid(string.Empty);
           
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ofdEmployee.Title = "Select Employee Passport size photo";
            ofdEmployee.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (ofdEmployee.ShowDialog() == DialogResult.OK)
            {
                PicEmp.Image = new Bitmap(ofdEmployee.FileName);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            PicEmp.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            FillGrid(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtFullName.Text.Trim().Length == 0)
            {
                ep.SetError(txtFullName,"Please Enter Full Name");
                txtFullName.Focus();
                return;
            }
            else if(cmbUserType.SelectedIndex == 0)
            {
                ep.SetError(cmbUserType, "Please Select User Type");
                cmbUserType.Focus();
                return;
            }
            DataTable dt = DataAccess.Retrive("select * from tblEmployee where FullName = '" + txtFullName.Text + "'");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtFullName, "Already Registered");
                    txtFullName.Focus();
                    txtFullName.SelectAll();
                    return;
                }
            }

            string InsertQuery = string.Format("insert into tblEmployee (FullName,UserTypeID,ContactNo,Email,CNIC,Photo,Address,Description)values('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",txtFullName.Text,cmbUserType.SelectedValue,txtCnic.Text,txtEmail.Text,txtCnic.Text,Common.ConvertImageForInsert(PicEmp),txtAddress.Text,txtDiscription.Text);
            bool result = DataAccess.Crud(InsertQuery);
            if (result)
            {
                btnClear_Click(sender, e);
                MessageBox.Show("Save Successfully");
            }
            else
            {
                ep.SetError(btnSave, "Please Try Again");
            }
        }
    }
}
