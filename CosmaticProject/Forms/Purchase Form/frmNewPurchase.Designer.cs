namespace CosmaticProject.Forms.Purchase_Form
{
    partial class frmNewPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblItemCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoryType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentSaleUnit = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCurrentPurchaseUnit = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCurrentQty = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaleUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblContact);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearchSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Supplier";
            // 
            // lblContact
            // 
            this.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(613, 45);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(157, 29);
            this.lblContact.TabIndex = 5;
            this.lblContact.Text = "Contact No";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(610, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No";
            // 
            // lblSupplier
            // 
            this.lblSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(342, 45);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(157, 29);
            this.lblSupplier.TabIndex = 3;
            this.lblSupplier.Text = "Supplier Name";
            this.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplier.Location = new System.Drawing.Point(9, 48);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(277, 26);
            this.txtSearchSupplier.TabIndex = 1;
            this.txtSearchSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchSupplier_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Supplier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.lblItemCost);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSalePrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPurchasePrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbProduct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbCategoryType);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 367);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Product";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(80, 297);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 26);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(179, 297);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 26);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblItemCost
            // 
            this.lblItemCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCost.Location = new System.Drawing.Point(80, 265);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(197, 29);
            this.lblItemCost.TabIndex = 4;
            this.lblItemCost.Text = "Item Cost";
            this.lblItemCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Item Cost";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(80, 222);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(126, 26);
            this.txtSalePrice.TabIndex = 16;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 36);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sale\r\nUnit Price\r\n";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(80, 172);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(126, 26);
            this.txtPurchasePrice.TabIndex = 14;
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPurchasePrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "Purchase\r\nUnit Price\r\n";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(80, 118);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(126, 26);
            this.txtQty.TabIndex = 6;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "Purchase\r\nQty";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(80, 67);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(197, 21);
            this.cmbProduct.TabIndex = 12;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Product";
            // 
            // cmbCategoryType
            // 
            this.cmbCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoryType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryType.FormattingEnabled = true;
            this.cmbCategoryType.Location = new System.Drawing.Point(80, 29);
            this.cmbCategoryType.Name = "cmbCategoryType";
            this.cmbCategoryType.Size = new System.Drawing.Size(197, 21);
            this.cmbCategoryType.TabIndex = 10;
            this.cmbCategoryType.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCurrentSaleUnit);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.lblCurrentPurchaseUnit);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblCurrentQty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Product";
            // 
            // lblCurrentSaleUnit
            // 
            this.lblCurrentSaleUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentSaleUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSaleUnit.Location = new System.Drawing.Point(6, 155);
            this.lblCurrentSaleUnit.Name = "lblCurrentSaleUnit";
            this.lblCurrentSaleUnit.Size = new System.Drawing.Size(268, 29);
            this.lblCurrentSaleUnit.TabIndex = 23;
            this.lblCurrentSaleUnit.Text = "Item Cost";
            this.lblCurrentSaleUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 18);
            this.label18.TabIndex = 24;
            this.label18.Text = "Sale Unit Price";
            // 
            // lblCurrentPurchaseUnit
            // 
            this.lblCurrentPurchaseUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentPurchaseUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPurchaseUnit.Location = new System.Drawing.Point(9, 99);
            this.lblCurrentPurchaseUnit.Name = "lblCurrentPurchaseUnit";
            this.lblCurrentPurchaseUnit.Size = new System.Drawing.Size(268, 29);
            this.lblCurrentPurchaseUnit.TabIndex = 21;
            this.lblCurrentPurchaseUnit.Text = "Item Cost";
            this.lblCurrentPurchaseUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 18);
            this.label16.TabIndex = 22;
            this.label16.Text = "Current Purchase Unit";
            // 
            // lblCurrentQty
            // 
            this.lblCurrentQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQty.Location = new System.Drawing.Point(9, 43);
            this.lblCurrentQty.Name = "lblCurrentQty";
            this.lblCurrentQty.Size = new System.Drawing.Size(268, 29);
            this.lblCurrentQty.TabIndex = 19;
            this.lblCurrentQty.Text = "Item Cost";
            this.lblCurrentQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Current Quantity";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProduct,
            this.colCategoryiD,
            this.colCategory,
            this.colQty,
            this.colPurchaseUnitPrice,
            this.ColSaleUnitPrice,
            this.colItemCost});
            this.dgvInvoice.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInvoice.Location = new System.Drawing.Point(304, 123);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.ReadOnly = true;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(586, 395);
            this.dgvInvoice.TabIndex = 20;
            // 
            // colProductID
            // 
            this.colProductID.HeaderText = "ID";
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            this.colProductID.Visible = false;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            this.colProduct.Width = 160;
            // 
            // colCategoryiD
            // 
            this.colCategoryiD.HeaderText = "Category";
            this.colCategoryiD.Name = "colCategoryiD";
            this.colCategoryiD.ReadOnly = true;
            this.colCategoryiD.Visible = false;
            this.colCategoryiD.Width = 5;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 120;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 50;
            // 
            // colPurchaseUnitPrice
            // 
            this.colPurchaseUnitPrice.HeaderText = "Purchase U-P";
            this.colPurchaseUnitPrice.Name = "colPurchaseUnitPrice";
            this.colPurchaseUnitPrice.ReadOnly = true;
            this.colPurchaseUnitPrice.Width = 70;
            // 
            // ColSaleUnitPrice
            // 
            this.ColSaleUnitPrice.HeaderText = "Sale U-P";
            this.ColSaleUnitPrice.Name = "ColSaleUnitPrice";
            this.ColSaleUnitPrice.ReadOnly = true;
            this.ColSaleUnitPrice.Width = 70;
            // 
            // colItemCost
            // 
            this.colItemCost.HeaderText = "Item Cost";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(304, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 18);
            this.label19.TabIndex = 19;
            this.label19.Text = "Invoice";
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(706, 556);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 29);
            this.label20.TabIndex = 25;
            this.label20.Text = "Item Cost";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(603, 567);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 18);
            this.label21.TabIndex = 26;
            this.label21.Text = "Total Cost :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(698, 608);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(192, 22);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Is Payment Successfull ?";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(304, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 53);
            this.button4.TabIndex = 32;
            this.button4.Text = "Cancle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(464, 608);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 53);
            this.button5.TabIndex = 33;
            this.button5.Text = "Confirm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(80, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 32;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(179, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 26);
            this.button2.TabIndex = 31;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmNewPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 674);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Purchase";
            this.Load += new System.EventHandler(this.frmNewPurchase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategoryType;
        private System.Windows.Forms.Label lblItemCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblCurrentSaleUnit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCurrentPurchaseUnit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCurrentQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryiD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaleUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCost;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}