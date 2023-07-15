using CosmaticProject.Forms;
using CosmaticProject.Forms.Customer;
using CosmaticProject.Forms.Employee_Forms;
using CosmaticProject.Forms.Expense_Form;
using CosmaticProject.Forms.Purchase_Form;
using CosmaticProject.Forms.Stock;
using CosmaticProject.Forms.Stock_Form;
using CosmaticProject.Forms.Supplier;
using CosmaticProject.Forms.User_Forms;
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

namespace CosmaticProject
{
    public partial class HomeForm : Form
    {
        public frmStartup StartUp;
        public frmExpenses expenses;
        public HomeForm()
        {
            InitializeComponent();
            timer1.Start();
            SSLblCurrentTime.Text = DateTime.Now.ToString("dddd MMMM yyyy : hh:mm:ss tt"); ;
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            StartUp = new frmStartup();
            StartUp.TopLevel = false;
            StartUp.Dock = DockStyle.Fill;
            StartUp.FormBorderStyle = FormBorderStyle.None;
            panelParent.Controls.Add(StartUp);
            StartUp.Show();
           
        }

        private void userTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserType user = new frmUserType();
            user.ShowDialog();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpRegistration emp = new frmEmpRegistration();
            emp.ShowDialog();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateNewUser fcu = new frmCreateNewUser();
            fcu.ShowDialog();
        }

        private void allEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchEmployee se = new frmSearchEmployee();
            se.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmUserLogin ul = new frmUserLogin();
            ul.ShowDialog();
            if (UserInfo.EmployeeID > 0)
            {
                MSForm.Enabled = true;
                tsButtonNewSale.Enabled = true;
                tsButtonSalePayment.Enabled = true;
                tsButtonNewPurchase.Enabled = true;
                tsButtonPurchasePayment.Enabled = true;
                tsButtonStock.Enabled = true;
                tsButtonNewExpenses.Enabled = true;
                txButtonAllExpenses.Enabled = true;
                tsButtonReports.Enabled = true;
                toolStripButton5.Visible = false;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SSLblCurrentTime.Text = DateTime.Now.ToString("dddd MMMM yyyy : hh:mm:ss tt");
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory fc = new frmCategory();
            fc.ShowDialog();
        }

        private void expensesCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpensesCategory ec = new frmExpensesCategory();
            ec.ShowDialog();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            product.ShowDialog();
        }

        private void newExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (expenses == null)
            {
                expenses = new frmExpenses();   
            }
            expenses.TopLevel = false;
            panelParent.Controls.Add(expenses);
            expenses.FormBorderStyle = FormBorderStyle.None;
            expenses.Dock = DockStyle.Fill;
            expenses.BringToFront();
            expenses.Show();
        }

        private void newPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPurchase purchase = new frmNewPurchase();
            purchase.ShowDialog();
        }

        private void newSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewSupplier newSupplier = new frmNewSupplier();
            newSupplier.ShowDialog();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCustomer newCustomer = new frmNewCustomer();
            newCustomer.ShowDialog();
        }

        private void tsButtonNewPurchase_Click(object sender, EventArgs e)
        {
            frmNewPurchase purchase = new frmNewPurchase();
            purchase.ShowDialog();
        }
    }
}
