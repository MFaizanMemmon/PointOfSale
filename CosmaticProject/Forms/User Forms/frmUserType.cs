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
    public partial class frmUserType : Form
    {
        public frmUserType()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtUserType.Clear();
            txtSearch.Clear();
        }
        private void FillGrid(string SearchValue)
        {
            string query = "select UserTypeID as [ID] ,UserType as [User Type] from tblUserType";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "select UserTypeID as [ID] ,UserType as [User Type] from tblUserType where UserType like '%"+SearchValue +"%'";
                    
            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgvUserType.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    dgvUserType.Columns[0].Width = 100;
                    dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  
                }
            }
            else
            {
                dgvUserType.DataSource = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            FillGrid(string.Empty);
        }

        private void frmUserType_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FillGrid(txtSearch.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtUserType.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserType,"Please Enter User Type Titile");
                txtUserType.Focus();
                return;
            }
            DataTable dt = DataAccess.Retrive("select * from tblUserType where UserType = '"+txtUserType.Text+"'");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtUserType, "Already Registered");
                    txtUserType.Focus();
                    txtUserType.SelectAll();
                    return;
                }
            }

            string InsertQuery = "insert into tblUserType (UserType) values ('"+txtUserType.Text+"')";
            bool result = DataAccess.Crud(InsertQuery);
            if (result)
            {
                btnClear_Click(sender, e);
                MessageBox.Show("Save Successfully");
            }
            else
            {
                ep.SetError(btnSave,"Please Try Again");
            }
        }

        private void EnableComponents()
        {
            btnCancle.Enabled = true;
            btnUpdate.Enabled = true;
            dgvUserType.Enabled = false;
            btnSave.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void ResetComponent()
        {
            btnCancle.Enabled = false;
            btnUpdate.Enabled = false;
            dgvUserType.Enabled = true;
            btnSave.Enabled = true;
            txtSearch.Enabled = true;
            FillGrid(string.Empty);
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvUserType.Rows.Count > 0)
            {
                if (dgvUserType.SelectedRows.Count == 1)
                {
                    txtUserType.Text = Convert.ToString(dgvUserType.CurrentRow.Cells[1].Value);
                    EnableComponents();
                }
                else
                {
                    MessageBox.Show("Warning","Please Select one Record !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (txtUserType.Text.Trim().Length == 0)
            {
                ep.SetError(txtUserType, "Please Enter User Type Titile");
                txtUserType.Focus();
                return;
            }
            DataTable dt = DataAccess.Retrive("select * from tblUserType where UserType = '" + txtUserType.Text + "'");

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    ep.SetError(txtUserType, "Already Registered");
                    txtUserType.Focus();
                    txtUserType.SelectAll();
                    return;
                }
            }

            string UpdateQuery = "update tblUserType set UserType = '" + txtUserType.Text + "' where UserTypeID=" + Convert.ToString(dgvUserType.CurrentRow.Cells[0].Value);
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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ResetComponent();
        }
    }
}
