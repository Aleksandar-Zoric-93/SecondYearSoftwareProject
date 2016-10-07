namespace SoftwareProject
{
    partial class RecordOrder
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
            this.enterStockNumLbl = new System.Windows.Forms.Label();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.OrderIDBox = new System.Windows.Forms.TextBox();
            this.OrderIdTxt = new System.Windows.Forms.Label();
            this.stockNoTxt = new System.Windows.Forms.TextBox();
            this.grpAllFood = new System.Windows.Forms.GroupBox();
            this.grdFood = new System.Windows.Forms.DataGridView();
            this.nextBtn = new System.Windows.Forms.Button();
            this.grpAllCost = new System.Windows.Forms.GroupBox();
            this.grdCost = new System.Windows.Forms.DataGridView();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allMenu.SuspendLayout();
            this.grpAllFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).BeginInit();
            this.grpAllCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).BeginInit();
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
            this.allMenu.TabIndex = 4;
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
            this.dateBar.Location = new System.Drawing.Point(317, 2);
            this.dateBar.Name = "dateBar";
            this.dateBar.Size = new System.Drawing.Size(200, 20);
            this.dateBar.TabIndex = 7;
            // 
            // enterStockNumLbl
            // 
            this.enterStockNumLbl.AutoSize = true;
            this.enterStockNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.enterStockNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterStockNumLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.enterStockNumLbl.Location = new System.Drawing.Point(21, 242);
            this.enterStockNumLbl.Name = "enterStockNumLbl";
            this.enterStockNumLbl.Size = new System.Drawing.Size(319, 20);
            this.enterStockNumLbl.TabIndex = 8;
            this.enterStockNumLbl.Text = "Enter the stock number of the food ordered:";
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.BackColor = System.Drawing.Color.Transparent;
            this.qtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.qtyLbl.Location = new System.Drawing.Point(21, 276);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(72, 20);
            this.qtyLbl.TabIndex = 10;
            this.qtyLbl.Text = "Quantity:";
            // 
            // qtyTxt
            // 
            this.qtyTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.qtyTxt.Location = new System.Drawing.Point(126, 278);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(42, 20);
            this.qtyTxt.TabIndex = 11;
            this.qtyTxt.TextChanged += new System.EventHandler(this.qtyTxt_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Linen;
            this.submitBtn.Location = new System.Drawing.Point(388, 491);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 16;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Linen;
            this.homebtn.Location = new System.Drawing.Point(27, 491);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 17;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // OrderIDBox
            // 
            this.OrderIDBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.OrderIDBox.Enabled = false;
            this.OrderIDBox.Location = new System.Drawing.Point(126, 40);
            this.OrderIDBox.Name = "OrderIDBox";
            this.OrderIDBox.Size = new System.Drawing.Size(55, 20);
            this.OrderIDBox.TabIndex = 19;
            // 
            // OrderIdTxt
            // 
            this.OrderIdTxt.AutoSize = true;
            this.OrderIdTxt.BackColor = System.Drawing.Color.Transparent;
            this.OrderIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdTxt.ForeColor = System.Drawing.Color.PapayaWhip;
            this.OrderIdTxt.Location = new System.Drawing.Point(21, 41);
            this.OrderIdTxt.Name = "OrderIdTxt";
            this.OrderIdTxt.Size = new System.Drawing.Size(74, 20);
            this.OrderIdTxt.TabIndex = 18;
            this.OrderIdTxt.Text = "Order ID:";
            // 
            // stockNoTxt
            // 
            this.stockNoTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.stockNoTxt.Location = new System.Drawing.Point(346, 244);
            this.stockNoTxt.Name = "stockNoTxt";
            this.stockNoTxt.Size = new System.Drawing.Size(39, 20);
            this.stockNoTxt.TabIndex = 9;
            this.stockNoTxt.TextChanged += new System.EventHandler(this.stockNoTxt_TextChanged);
            // 
            // grpAllFood
            // 
            this.grpAllFood.BackColor = System.Drawing.Color.Transparent;
            this.grpAllFood.Controls.Add(this.grdFood);
            this.grpAllFood.ForeColor = System.Drawing.Color.DarkGray;
            this.grpAllFood.Location = new System.Drawing.Point(25, 66);
            this.grpAllFood.Name = "grpAllFood";
            this.grpAllFood.Size = new System.Drawing.Size(367, 153);
            this.grpAllFood.TabIndex = 21;
            this.grpAllFood.TabStop = false;
            this.grpAllFood.Text = " Current Food Items";
            // 
            // grdFood
            // 
            this.grdFood.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grdFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFood.Location = new System.Drawing.Point(6, 16);
            this.grdFood.Name = "grdFood";
            this.grdFood.Size = new System.Drawing.Size(354, 131);
            this.grdFood.TabIndex = 2;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Linen;
            this.nextBtn.Location = new System.Drawing.Point(346, 276);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 22;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // grpAllCost
            // 
            this.grpAllCost.BackColor = System.Drawing.Color.Transparent;
            this.grpAllCost.Controls.Add(this.grdCost);
            this.grpAllCost.ForeColor = System.Drawing.Color.DarkGray;
            this.grpAllCost.Location = new System.Drawing.Point(25, 318);
            this.grpAllCost.Name = "grpAllCost";
            this.grpAllCost.Size = new System.Drawing.Size(360, 153);
            this.grpAllCost.TabIndex = 22;
            this.grpAllCost.TabStop = false;
            this.grpAllCost.Text = "Cost";
            // 
            // grdCost
            // 
            this.grdCost.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grdCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCost.Location = new System.Drawing.Point(6, 16);
            this.grdCost.Name = "grdCost";
            this.grdCost.Size = new System.Drawing.Size(348, 131);
            this.grdCost.TabIndex = 2;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.totalLbl.Location = new System.Drawing.Point(176, 491);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(48, 20);
            this.totalLbl.TabIndex = 23;
            this.totalLbl.Text = "Total:";
            // 
            // totalTxt
            // 
            this.totalTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.totalTxt.Enabled = false;
            this.totalTxt.Location = new System.Drawing.Point(227, 491);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(75, 20);
            this.totalTxt.TabIndex = 24;
            // 
            // dateTxt
            // 
            this.dateTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.dateTxt.Enabled = false;
            this.dateTxt.Location = new System.Drawing.Point(301, 40);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(91, 20);
            this.dateTxt.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(237, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Date:";
            // 
            // RecordOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::SoftwareProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 526);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.grpAllCost);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.grpAllFood);
            this.Controls.Add(this.OrderIDBox);
            this.Controls.Add(this.OrderIdTxt);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.qtyLbl);
            this.Controls.Add(this.stockNoTxt);
            this.Controls.Add(this.enterStockNumLbl);
            this.Controls.Add(this.dateBar);
            this.Controls.Add(this.allMenu);
            this.Name = "RecordOrder";
            this.Text = "RecordOrder";
            this.Load += new System.EventHandler(this.RecordOrder_Load);
            this.allMenu.ResumeLayout(false);
            this.allMenu.PerformLayout();
            this.grpAllFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFood)).EndInit();
            this.grpAllCost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).EndInit();
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
        private System.Windows.Forms.Label enterStockNumLbl;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.TextBox OrderIDBox;
        private System.Windows.Forms.Label OrderIdTxt;
        private System.Windows.Forms.TextBox stockNoTxt;
        private System.Windows.Forms.GroupBox grpAllFood;
        private System.Windows.Forms.DataGridView grdFood;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.GroupBox grpAllCost;
        private System.Windows.Forms.DataGridView grdCost;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label label1;
    }
}