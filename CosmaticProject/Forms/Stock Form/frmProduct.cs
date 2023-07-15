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

namespace CosmaticProject.Forms.Stock_Form
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void FillGrid(string SearchValue)
        {
            string query = "select ItemID,c.Name,ProductName,CurrentPurchaseUnitPrice,SaleUnitPrice,Qty,IsActive from tblProduct as p inner join tblCategory as c on p.CategoryID = c.CategoryID";
            if (!string.IsNullOrEmpty(SearchValue))
            {
                query = "";

            }
            DataTable dt = DataAccess.Retrive(query);
            if (dt != null)
            {
                dgvProductCategory.DataSource = dt;
                if (dt.Rows.Count > 0)
                {

                    //dgvUserType.Columns[0].Width = 100;
                    //dgvUserType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                dgvProductCategory.DataSource = null;
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            FillGrid(string.Empty);
            ComboHelper.FillProductCategory(cmbCategory);
            ComboHelper.FillProductUnit(cmbPurchaseUnit);
            ComboHelper.FillProductUnit(cmbSaleUnit);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //                                                      1              2        3          4        5               6                     7     8                9   
            string query = string.Format("insert into tblProduct (CategoryID,EmployeeID,ProductName,CurrentPurchaseUnitPrice,Qty,SaleUnitPrice,IsActive) values ({0},{1},'{2}',{3},{4},{5},'{6}')", cmbCategory.SelectedValue, UserInfo.EmployeeID, txtProductName.Text, txtPurchasePrice.Text, txtOpeningStock.Text, txtSalePrice.Text, chkIsActive.Checked);

            if (DataAccess.Crud(query))
            {
                MessageBox.Show("Product has been Saved");
                FillGrid(string.Empty);
            }
        }
    }
}
