namespace SoftwareProject
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
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
            this.addFoodLbl = new System.Windows.Forms.Label();
            this.TitleIdBox2 = new System.Windows.Forms.TextBox();
            this.TitleIdLbl2 = new System.Windows.Forms.Label();
            this.descBox = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.IngriBox = new System.Windows.Forms.TextBox();
            this.IngriLbl = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stockNoTxt = new System.Windows.Forms.TextBox();
            this.allMenu.SuspendLayout();
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
            this.allMenu.TabIndex = 8;
            this.allMenu.Text = "allMenu";
            this.allMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.allMenu_ItemClicked);
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
            this.dateBar.Location = new System.Drawing.Point(322, 2);
            this.dateBar.Name = "dateBar";
            this.dateBar.Size = new System.Drawing.Size(200, 20);
            this.dateBar.TabIndex = 10;
            // 
            // addFoodLbl
            // 
            this.addFoodLbl.AutoSize = true;
            this.addFoodLbl.BackColor = System.Drawing.Color.Transparent;
            this.addFoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addFoodLbl.Location = new System.Drawing.Point(7, 56);
            this.addFoodLbl.Name = "addFoodLbl";
            this.addFoodLbl.Size = new System.Drawing.Size(221, 16);
            this.addFoodLbl.TabIndex = 19;
            this.addFoodLbl.Text = "Please enter the details below.";
            // 
            // TitleIdBox2
            // 
            this.TitleIdBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.TitleIdBox2.Location = new System.Drawing.Point(244, 114);
            this.TitleIdBox2.Name = "TitleIdBox2";
            this.TitleIdBox2.Size = new System.Drawing.Size(100, 20);
            this.TitleIdBox2.TabIndex = 21;
            // 
            // TitleIdLbl2
            // 
            this.TitleIdLbl2.AutoSize = true;
            this.TitleIdLbl2.BackColor = System.Drawing.Color.Transparent;
            this.TitleIdLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleIdLbl2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.TitleIdLbl2.Location = new System.Drawing.Point(140, 112);
            this.TitleIdLbl2.Name = "TitleIdLbl2";
            this.TitleIdLbl2.Size = new System.Drawing.Size(42, 20);
            this.TitleIdLbl2.TabIndex = 20;
            this.TitleIdLbl2.Text = "Title:";
            // 
            // descBox
            // 
            this.descBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.descBox.Location = new System.Drawing.Point(244, 140);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(123, 20);
            this.descBox.TabIndex = 23;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.BackColor = System.Drawing.Color.Transparent;
            this.descLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.descLbl.Location = new System.Drawing.Point(140, 138);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(93, 20);
            this.descLbl.TabIndex = 22;
            this.descLbl.Text = "Description:";
            // 
            // IngriBox
            // 
            this.IngriBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.IngriBox.Location = new System.Drawing.Point(244, 166);
            this.IngriBox.Name = "IngriBox";
            this.IngriBox.Size = new System.Drawing.Size(123, 20);
            this.IngriBox.TabIndex = 25;
            // 
            // IngriLbl
            // 
            this.IngriLbl.AutoSize = true;
            this.IngriLbl.BackColor = System.Drawing.Color.Transparent;
            this.IngriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngriLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.IngriLbl.Location = new System.Drawing.Point(138, 164);
            this.IngriLbl.Name = "IngriLbl";
            this.IngriLbl.Size = new System.Drawing.Size(87, 20);
            this.IngriLbl.TabIndex = 24;
            this.IngriLbl.Text = "Ingridients:";
            // 
            // CategoryBox
            // 
            this.CategoryBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.CategoryBox.Location = new System.Drawing.Point(244, 192);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(83, 20);
            this.CategoryBox.TabIndex = 27;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.BackColor = System.Drawing.Color.Transparent;
            this.CategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.CategoryLbl.Location = new System.Drawing.Point(138, 190);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(77, 20);
            this.CategoryLbl.TabIndex = 26;
            this.CategoryLbl.Text = "Category:";
            // 
            // PriceBox
            // 
            this.PriceBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.PriceBox.Location = new System.Drawing.Point(244, 218);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(49, 20);
            this.PriceBox.TabIndex = 29;
            this.PriceBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BackColor = System.Drawing.Color.Transparent;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PriceLbl.Location = new System.Drawing.Point(138, 216);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(48, 20);
            this.PriceLbl.TabIndex = 28;
            this.PriceLbl.Text = "Price:";
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Linen;
            this.homebtn.Location = new System.Drawing.Point(28, 227);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 30;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Linen;
            this.submitBtn.Location = new System.Drawing.Point(381, 227);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 31;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(140, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "StockNo";
            // 
            // stockNoTxt
            // 
            this.stockNoTxt.Enabled = false;
            this.stockNoTxt.Location = new System.Drawing.Point(244, 82);
            this.stockNoTxt.Name = "stockNoTxt";
            this.stockNoTxt.Size = new System.Drawing.Size(37, 20);
            this.stockNoTxt.TabIndex = 33;
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.stockNoTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.IngriBox);
            this.Controls.Add(this.IngriLbl);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.TitleIdBox2);
            this.Controls.Add(this.TitleIdLbl2);
            this.Controls.Add(this.addFoodLbl);
            this.Controls.Add(this.dateBar);
            this.Controls.Add(this.allMenu);
            this.Name = "AddFood";
            this.Text = "AddFood";
            this.Load += new System.EventHandler(this.AddFood_Load);
            this.allMenu.ResumeLayout(false);
            this.allMenu.PerformLayout();
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
        private System.Windows.Forms.Label addFoodLbl;
        private System.Windows.Forms.TextBox TitleIdBox2;
        private System.Windows.Forms.Label TitleIdLbl2;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.TextBox IngriBox;
        private System.Windows.Forms.Label IngriLbl;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockNoTxt;
    }
}