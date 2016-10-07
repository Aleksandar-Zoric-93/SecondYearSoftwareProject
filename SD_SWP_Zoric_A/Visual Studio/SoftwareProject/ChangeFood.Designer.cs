namespace SoftwareProject
{
    partial class ChangeFood
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
            this.allMenu = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amendStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listFoodItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateBar = new System.Windows.Forms.DateTimePicker();
            this.amendFoodLbl = new System.Windows.Forms.Label();
            this.TitleIdBox3 = new System.Windows.Forms.TextBox();
            this.TitleIdLbl3 = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.grpAllFood = new System.Windows.Forms.GroupBox();
            this.grdFood = new System.Windows.Forms.DataGridView();
            this.grpFood = new System.Windows.Forms.GroupBox();
            this.ingriTxt = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.stockNoTxt = new System.Windows.Forms.TextBox();
            this.amendButton = new System.Windows.Forms.Button();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.ingriLbl = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.descTxt = new System.Windows.Forms.TextBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.stockNoLbl = new System.Windows.Forms.Label();
            this.txtSearchStock = new System.Windows.Forms.TextBox();
            this.allMenu.SuspendLayout();
            this.grpAllFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).BeginInit();
            this.grpFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // allMenu
            // 
            this.allMenu.BackColor = System.Drawing.Color.Linen;
            this.allMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.foodToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.allMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.allMenu.Location = new System.Drawing.Point(0, 0);
            this.allMenu.Name = "allMenu";
            this.allMenu.Size = new System.Drawing.Size(484, 24);
            this.allMenu.TabIndex = 9;
            this.allMenu.Text = "allMenu";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStaffToolStripMenuItem,
            this.amendStaffToolStripMenuItem,
            this.listStaffToolStripMenuItem,
            this.cancelRequestToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // registerStaffToolStripMenuItem
            // 
            this.registerStaffToolStripMenuItem.Name = "registerStaffToolStripMenuItem";
            this.registerStaffToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.registerStaffToolStripMenuItem.Text = "Register Staff";
            this.registerStaffToolStripMenuItem.Click += new System.EventHandler(this.registerStaffToolStripMenuItem_Click);
            // 
            // amendStaffToolStripMenuItem
            // 
            this.amendStaffToolStripMenuItem.Name = "amendStaffToolStripMenuItem";
            this.amendStaffToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.amendStaffToolStripMenuItem.Text = "Amend Staff";
            this.amendStaffToolStripMenuItem.Click += new System.EventHandler(this.amendStaffToolStripMenuItem_Click);
            // 
            // listStaffToolStripMenuItem
            // 
            this.listStaffToolStripMenuItem.Name = "listStaffToolStripMenuItem";
            this.listStaffToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listStaffToolStripMenuItem.Text = "List Staff";
            this.listStaffToolStripMenuItem.Click += new System.EventHandler(this.listStaffToolStripMenuItem_Click);
            // 
            // cancelRequestToolStripMenuItem
            // 
            this.cancelRequestToolStripMenuItem.Name = "cancelRequestToolStripMenuItem";
            this.cancelRequestToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cancelRequestToolStripMenuItem.Text = "Cancel Request";
            this.cancelRequestToolStripMenuItem.Click += new System.EventHandler(this.cancelRequestToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordOrderToolStripMenuItem,
            this.editOrderToolStripMenuItem,
            this.listOrderToolStripMenuItem,
            this.recordPaymentToolStripMenuItem,
            this.cancelOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // recordOrderToolStripMenuItem
            // 
            this.recordOrderToolStripMenuItem.Name = "recordOrderToolStripMenuItem";
            this.recordOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recordOrderToolStripMenuItem.Text = "Record Order";
            this.recordOrderToolStripMenuItem.Click += new System.EventHandler(this.recordOrderToolStripMenuItem_Click);
            // 
            // editOrderToolStripMenuItem
            // 
            this.editOrderToolStripMenuItem.Name = "editOrderToolStripMenuItem";
            this.editOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editOrderToolStripMenuItem.Text = "Edit Order";
            this.editOrderToolStripMenuItem.Click += new System.EventHandler(this.editOrderToolStripMenuItem_Click);
            // 
            // listOrderToolStripMenuItem
            // 
            this.listOrderToolStripMenuItem.Name = "listOrderToolStripMenuItem";
            this.listOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listOrderToolStripMenuItem.Text = "List Order";
            this.listOrderToolStripMenuItem.Click += new System.EventHandler(this.listOrderToolStripMenuItem_Click);
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            this.recordPaymentToolStripMenuItem.Click += new System.EventHandler(this.recordPaymentToolStripMenuItem_Click);
            // 
            // cancelOrderToolStripMenuItem
            // 
            this.cancelOrderToolStripMenuItem.Name = "cancelOrderToolStripMenuItem";
            this.cancelOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cancelOrderToolStripMenuItem.Text = "Cancel Order";
            this.cancelOrderToolStripMenuItem.Click += new System.EventHandler(this.cancelOrderToolStripMenuItem_Click);
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFoodToolStripMenuItem,
            this.changeFoodToolStripMenuItem,
            this.removeFoodToolStripMenuItem,
            this.listFoodItemsToolStripMenuItem});
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.foodToolStripMenuItem.Text = "Food";
            // 
            // addFoodToolStripMenuItem
            // 
            this.addFoodToolStripMenuItem.Name = "addFoodToolStripMenuItem";
            this.addFoodToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addFoodToolStripMenuItem.Text = "Add Food";
            this.addFoodToolStripMenuItem.Click += new System.EventHandler(this.addFoodToolStripMenuItem_Click);
            // 
            // changeFoodToolStripMenuItem
            // 
            this.changeFoodToolStripMenuItem.Name = "changeFoodToolStripMenuItem";
            this.changeFoodToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.changeFoodToolStripMenuItem.Text = "Change Food";
            this.changeFoodToolStripMenuItem.Click += new System.EventHandler(this.changeFoodToolStripMenuItem_Click);
            // 
            // removeFoodToolStripMenuItem
            // 
            this.removeFoodToolStripMenuItem.Name = "removeFoodToolStripMenuItem";
            this.removeFoodToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.removeFoodToolStripMenuItem.Text = "Remove Food";
            this.removeFoodToolStripMenuItem.Click += new System.EventHandler(this.removeFoodToolStripMenuItem_Click);
            // 
            // listFoodItemsToolStripMenuItem
            // 
            this.listFoodItemsToolStripMenuItem.Name = "listFoodItemsToolStripMenuItem";
            this.listFoodItemsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listFoodItemsToolStripMenuItem.Text = "List Food Items";
            this.listFoodItemsToolStripMenuItem.Click += new System.EventHandler(this.listFoodItemsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesAnalysisToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // viewSalesAnalysisToolStripMenuItem
            // 
            this.viewSalesAnalysisToolStripMenuItem.Name = "viewSalesAnalysisToolStripMenuItem";
            this.viewSalesAnalysisToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewSalesAnalysisToolStripMenuItem.Text = "View Sales Analysis";
            this.viewSalesAnalysisToolStripMenuItem.Click += new System.EventHandler(this.viewSalesAnalysisToolStripMenuItem_Click);
            // 
            // dateBar
            // 
            this.dateBar.Location = new System.Drawing.Point(329, 2);
            this.dateBar.Name = "dateBar";
            this.dateBar.Size = new System.Drawing.Size(200, 20);
            this.dateBar.TabIndex = 11;
            // 
            // amendFoodLbl
            // 
            this.amendFoodLbl.AutoSize = true;
            this.amendFoodLbl.BackColor = System.Drawing.Color.Transparent;
            this.amendFoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amendFoodLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.amendFoodLbl.Location = new System.Drawing.Point(6, 59);
            this.amendFoodLbl.Name = "amendFoodLbl";
            this.amendFoodLbl.Size = new System.Drawing.Size(478, 16);
            this.amendFoodLbl.TabIndex = 20;
            this.amendFoodLbl.Text = "Please enter the title or Stock number of the food you wish to amend.";
            // 
            // TitleIdBox3
            // 
            this.TitleIdBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.TitleIdBox3.Location = new System.Drawing.Point(93, 95);
            this.TitleIdBox3.Name = "TitleIdBox3";
            this.TitleIdBox3.Size = new System.Drawing.Size(100, 20);
            this.TitleIdBox3.TabIndex = 23;
            this.TitleIdBox3.TextChanged += new System.EventHandler(this.TitleIdBox3_TextChanged);
            // 
            // TitleIdLbl3
            // 
            this.TitleIdLbl3.AutoSize = true;
            this.TitleIdLbl3.BackColor = System.Drawing.Color.Transparent;
            this.TitleIdLbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleIdLbl3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.TitleIdLbl3.Location = new System.Drawing.Point(25, 93);
            this.TitleIdLbl3.Name = "TitleIdLbl3";
            this.TitleIdLbl3.Size = new System.Drawing.Size(42, 20);
            this.TitleIdLbl3.TabIndex = 22;
            this.TitleIdLbl3.Text = "Title:";
            this.TitleIdLbl3.Click += new System.EventHandler(this.TitleIdLbl3_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Linen;
            this.homebtn.Location = new System.Drawing.Point(27, 516);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 31;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // grpAllFood
            // 
            this.grpAllFood.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpAllFood.Controls.Add(this.grdFood);
            this.grpAllFood.ForeColor = System.Drawing.Color.Gray;
            this.grpAllFood.Location = new System.Drawing.Point(29, 134);
            this.grpAllFood.Name = "grpAllFood";
            this.grpAllFood.Size = new System.Drawing.Size(410, 131);
            this.grpAllFood.TabIndex = 33;
            this.grpAllFood.TabStop = false;
            this.grpAllFood.Text = "Select Food to Amend";
            this.grpAllFood.Visible = false;
            // 
            // grdFood
            // 
            this.grdFood.AllowUserToAddRows = false;
            this.grdFood.AllowUserToDeleteRows = false;
            this.grdFood.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grdFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFood.Location = new System.Drawing.Point(6, 19);
            this.grdFood.Name = "grdFood";
            this.grdFood.ReadOnly = true;
            this.grdFood.Size = new System.Drawing.Size(398, 106);
            this.grdFood.TabIndex = 6;
            // 
            // grpFood
            // 
            this.grpFood.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpFood.Controls.Add(this.ingriTxt);
            this.grpFood.Controls.Add(this.stockLbl);
            this.grpFood.Controls.Add(this.stockNoTxt);
            this.grpFood.Controls.Add(this.amendButton);
            this.grpFood.Controls.Add(this.priceTxt);
            this.grpFood.Controls.Add(this.priceLbl);
            this.grpFood.Controls.Add(this.ingriLbl);
            this.grpFood.Controls.Add(this.categoryTxt);
            this.grpFood.Controls.Add(this.descTxt);
            this.grpFood.Controls.Add(this.categoryLbl);
            this.grpFood.Controls.Add(this.descLbl);
            this.grpFood.Controls.Add(this.titleTxt);
            this.grpFood.Controls.Add(this.titleLbl);
            this.grpFood.ForeColor = System.Drawing.Color.Gray;
            this.grpFood.Location = new System.Drawing.Point(29, 265);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(410, 242);
            this.grpFood.TabIndex = 34;
            this.grpFood.TabStop = false;
            this.grpFood.Text = "Enter Food Details";
            this.grpFood.Visible = false;
            // 
            // ingriTxt
            // 
            this.ingriTxt.BackColor = System.Drawing.Color.Moccasin;
            this.ingriTxt.ForeColor = System.Drawing.Color.Gray;
            this.ingriTxt.Location = new System.Drawing.Point(139, 116);
            this.ingriTxt.Name = "ingriTxt";
            this.ingriTxt.Size = new System.Drawing.Size(165, 20);
            this.ingriTxt.TabIndex = 36;
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.BackColor = System.Drawing.Color.Transparent;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.ForeColor = System.Drawing.Color.Gray;
            this.stockLbl.Location = new System.Drawing.Point(32, 25);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(78, 20);
            this.stockLbl.TabIndex = 34;
            this.stockLbl.Text = "Stock No:";
            // 
            // stockNoTxt
            // 
            this.stockNoTxt.BackColor = System.Drawing.Color.Moccasin;
            this.stockNoTxt.Enabled = false;
            this.stockNoTxt.ForeColor = System.Drawing.Color.Gray;
            this.stockNoTxt.Location = new System.Drawing.Point(140, 27);
            this.stockNoTxt.Name = "stockNoTxt";
            this.stockNoTxt.Size = new System.Drawing.Size(43, 20);
            this.stockNoTxt.TabIndex = 35;
            // 
            // amendButton
            // 
            this.amendButton.BackColor = System.Drawing.Color.Linen;
            this.amendButton.Location = new System.Drawing.Point(329, 213);
            this.amendButton.Name = "amendButton";
            this.amendButton.Size = new System.Drawing.Size(75, 23);
            this.amendButton.TabIndex = 30;
            this.amendButton.Text = "Amend";
            this.amendButton.UseMnemonic = false;
            this.amendButton.UseVisualStyleBackColor = false;
            this.amendButton.Click += new System.EventHandler(this.amendButton_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.Color.Moccasin;
            this.priceTxt.ForeColor = System.Drawing.Color.Gray;
            this.priceTxt.Location = new System.Drawing.Point(141, 172);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(73, 20);
            this.priceTxt.TabIndex = 33;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.Gray;
            this.priceLbl.Location = new System.Drawing.Point(32, 169);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(48, 20);
            this.priceLbl.TabIndex = 32;
            this.priceLbl.Text = "Price:";
            // 
            // ingriLbl
            // 
            this.ingriLbl.AutoSize = true;
            this.ingriLbl.BackColor = System.Drawing.Color.Transparent;
            this.ingriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingriLbl.ForeColor = System.Drawing.Color.Gray;
            this.ingriLbl.Location = new System.Drawing.Point(32, 116);
            this.ingriLbl.Name = "ingriLbl";
            this.ingriLbl.Size = new System.Drawing.Size(87, 20);
            this.ingriLbl.TabIndex = 14;
            this.ingriLbl.Text = "Ingridients:";
            // 
            // categoryTxt
            // 
            this.categoryTxt.BackColor = System.Drawing.Color.Moccasin;
            this.categoryTxt.ForeColor = System.Drawing.Color.Gray;
            this.categoryTxt.Location = new System.Drawing.Point(141, 143);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(113, 20);
            this.categoryTxt.TabIndex = 31;
            // 
            // descTxt
            // 
            this.descTxt.BackColor = System.Drawing.Color.Moccasin;
            this.descTxt.ForeColor = System.Drawing.Color.Gray;
            this.descTxt.Location = new System.Drawing.Point(140, 88);
            this.descTxt.Name = "descTxt";
            this.descTxt.Size = new System.Drawing.Size(165, 20);
            this.descTxt.TabIndex = 11;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.ForeColor = System.Drawing.Color.Gray;
            this.categoryLbl.Location = new System.Drawing.Point(32, 143);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(77, 20);
            this.categoryLbl.TabIndex = 30;
            this.categoryLbl.Text = "Category:";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.BackColor = System.Drawing.Color.Transparent;
            this.descLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.ForeColor = System.Drawing.Color.Gray;
            this.descLbl.Location = new System.Drawing.Point(32, 87);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(93, 20);
            this.descLbl.TabIndex = 10;
            this.descLbl.Text = "Description:";
            // 
            // titleTxt
            // 
            this.titleTxt.BackColor = System.Drawing.Color.Moccasin;
            this.titleTxt.ForeColor = System.Drawing.Color.Gray;
            this.titleTxt.Location = new System.Drawing.Point(140, 62);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(114, 20);
            this.titleTxt.TabIndex = 9;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.Gray;
            this.titleLbl.Location = new System.Drawing.Point(32, 60);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(42, 20);
            this.titleLbl.TabIndex = 8;
            this.titleLbl.Text = "Title:";
            // 
            // stockNoLbl
            // 
            this.stockNoLbl.AutoSize = true;
            this.stockNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.stockNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNoLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.stockNoLbl.Location = new System.Drawing.Point(258, 94);
            this.stockNoLbl.Name = "stockNoLbl";
            this.stockNoLbl.Size = new System.Drawing.Size(75, 16);
            this.stockNoLbl.TabIndex = 36;
            this.stockNoLbl.Text = "Stock No:";
            // 
            // txtSearchStock
            // 
            this.txtSearchStock.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtSearchStock.Location = new System.Drawing.Point(339, 93);
            this.txtSearchStock.Name = "txtSearchStock";
            this.txtSearchStock.Size = new System.Drawing.Size(58, 20);
            this.txtSearchStock.TabIndex = 35;
            this.txtSearchStock.TextChanged += new System.EventHandler(this.txtSearchStock_TextChanged_1);
            // 
            // ChangeFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::SoftwareProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 551);
            this.Controls.Add(this.stockNoLbl);
            this.Controls.Add(this.txtSearchStock);
            this.Controls.Add(this.grpFood);
            this.Controls.Add(this.grpAllFood);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.TitleIdBox3);
            this.Controls.Add(this.TitleIdLbl3);
            this.Controls.Add(this.amendFoodLbl);
            this.Controls.Add(this.dateBar);
            this.Controls.Add(this.allMenu);
            this.Name = "ChangeFood";
            this.Text = "ChangeFood";
            this.Load += new System.EventHandler(this.ChangeFood_Load);
            this.allMenu.ResumeLayout(false);
            this.allMenu.PerformLayout();
            this.grpAllFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).EndInit();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip allMenu;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amendStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listFoodItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesAnalysisToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateBar;
        private System.Windows.Forms.Label amendFoodLbl;
        private System.Windows.Forms.TextBox TitleIdBox3;
        private System.Windows.Forms.Label TitleIdLbl3;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.GroupBox grpAllFood;
        private System.Windows.Forms.DataGridView grdFood;
        private System.Windows.Forms.GroupBox grpFood;
        private System.Windows.Forms.TextBox ingriTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.TextBox stockNoTxt;
        private System.Windows.Forms.Button amendButton;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label ingriLbl;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.TextBox descTxt;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label stockNoLbl;
        private System.Windows.Forms.TextBox txtSearchStock;
    }
}