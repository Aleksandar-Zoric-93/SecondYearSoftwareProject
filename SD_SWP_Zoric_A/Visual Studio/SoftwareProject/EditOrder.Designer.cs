namespace SoftwareProject
{
    partial class EditOrder
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
            this.amendLbl = new System.Windows.Forms.Label();
            this.orderIdBox = new System.Windows.Forms.TextBox();
            this.OrderIdLbl = new System.Windows.Forms.Label();
            this.homebtn = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.dspTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.qtyTxt = new System.Windows.Forms.TextBox();
            this.orderValTxt = new System.Windows.Forms.TextBox();
            this.dispLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.qtyLbl = new System.Windows.Forms.Label();
            this.orderValLbl = new System.Windows.Forms.Label();
            this.amendButton = new System.Windows.Forms.Button();
            this.mainDishLbl = new System.Windows.Forms.Label();
            this.DispatchBtn = new System.Windows.Forms.Button();
            this.getTotalBtn = new System.Windows.Forms.Button();
            this.getNewTotalLbl = new System.Windows.Forms.Label();
            this.allMenu.SuspendLayout();
            this.grpOrder.SuspendLayout();
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
            this.allMenu.TabIndex = 1;
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
            this.dateBar.Location = new System.Drawing.Point(319, 2);
            this.dateBar.Name = "dateBar";
            this.dateBar.Size = new System.Drawing.Size(200, 20);
            this.dateBar.TabIndex = 8;
            // 
            // amendLbl
            // 
            this.amendLbl.AutoSize = true;
            this.amendLbl.BackColor = System.Drawing.Color.Transparent;
            this.amendLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amendLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.amendLbl.Location = new System.Drawing.Point(36, 54);
            this.amendLbl.Name = "amendLbl";
            this.amendLbl.Size = new System.Drawing.Size(406, 16);
            this.amendLbl.TabIndex = 9;
            this.amendLbl.Text = "Please enter the Order ID for the order you wish to amend:";
            // 
            // orderIdBox
            // 
            this.orderIdBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.orderIdBox.Location = new System.Drawing.Point(110, 83);
            this.orderIdBox.Name = "orderIdBox";
            this.orderIdBox.Size = new System.Drawing.Size(61, 20);
            this.orderIdBox.TabIndex = 11;
            this.orderIdBox.TextChanged += new System.EventHandler(this.orderIdBox_TextChanged);
            // 
            // OrderIdLbl
            // 
            this.OrderIdLbl.AutoSize = true;
            this.OrderIdLbl.BackColor = System.Drawing.Color.Transparent;
            this.OrderIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIdLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.OrderIdLbl.Location = new System.Drawing.Point(35, 83);
            this.OrderIdLbl.Name = "OrderIdLbl";
            this.OrderIdLbl.Size = new System.Drawing.Size(74, 20);
            this.OrderIdLbl.TabIndex = 10;
            this.OrderIdLbl.Text = "Order ID:";
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Linen;
            this.homebtn.Location = new System.Drawing.Point(374, 504);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 18;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpOrder.Controls.Add(this.dspTxt);
            this.grpOrder.Controls.Add(this.priceTxt);
            this.grpOrder.Controls.Add(this.qtyTxt);
            this.grpOrder.Controls.Add(this.orderValTxt);
            this.grpOrder.Controls.Add(this.dispLbl);
            this.grpOrder.Controls.Add(this.priceLbl);
            this.grpOrder.Controls.Add(this.qtyLbl);
            this.grpOrder.Controls.Add(this.orderValLbl);
            this.grpOrder.Controls.Add(this.amendButton);
            this.grpOrder.Controls.Add(this.mainDishLbl);
            this.grpOrder.ForeColor = System.Drawing.Color.Gray;
            this.grpOrder.Location = new System.Drawing.Point(39, 122);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(410, 242);
            this.grpOrder.TabIndex = 30;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Enter Order Details";
            this.grpOrder.Visible = false;
            // 
            // dspTxt
            // 
            this.dspTxt.BackColor = System.Drawing.Color.Moccasin;
            this.dspTxt.ForeColor = System.Drawing.Color.Gray;
            this.dspTxt.Location = new System.Drawing.Point(157, 170);
            this.dspTxt.Name = "dspTxt";
            this.dspTxt.Size = new System.Drawing.Size(70, 20);
            this.dspTxt.TabIndex = 42;
            // 
            // priceTxt
            // 
            this.priceTxt.BackColor = System.Drawing.Color.Moccasin;
            this.priceTxt.ForeColor = System.Drawing.Color.Gray;
            this.priceTxt.Location = new System.Drawing.Point(157, 128);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(70, 20);
            this.priceTxt.TabIndex = 41;
            // 
            // qtyTxt
            // 
            this.qtyTxt.BackColor = System.Drawing.Color.Moccasin;
            this.qtyTxt.ForeColor = System.Drawing.Color.Gray;
            this.qtyTxt.Location = new System.Drawing.Point(157, 86);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(45, 20);
            this.qtyTxt.TabIndex = 40;
            // 
            // orderValTxt
            // 
            this.orderValTxt.BackColor = System.Drawing.Color.Moccasin;
            this.orderValTxt.ForeColor = System.Drawing.Color.Gray;
            this.orderValTxt.Location = new System.Drawing.Point(157, 43);
            this.orderValTxt.Name = "orderValTxt";
            this.orderValTxt.Size = new System.Drawing.Size(70, 20);
            this.orderValTxt.TabIndex = 39;
            // 
            // dispLbl
            // 
            this.dispLbl.AutoSize = true;
            this.dispLbl.BackColor = System.Drawing.Color.Transparent;
            this.dispLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispLbl.ForeColor = System.Drawing.Color.Gray;
            this.dispLbl.Location = new System.Drawing.Point(36, 168);
            this.dispLbl.Name = "dispLbl";
            this.dispLbl.Size = new System.Drawing.Size(94, 20);
            this.dispLbl.TabIndex = 38;
            this.dispLbl.Text = "Dispatched:";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.BackColor = System.Drawing.Color.Transparent;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.ForeColor = System.Drawing.Color.Gray;
            this.priceLbl.Location = new System.Drawing.Point(36, 126);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(48, 20);
            this.priceLbl.TabIndex = 37;
            this.priceLbl.Text = "Price:";
            // 
            // qtyLbl
            // 
            this.qtyLbl.AutoSize = true;
            this.qtyLbl.BackColor = System.Drawing.Color.Transparent;
            this.qtyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyLbl.ForeColor = System.Drawing.Color.Gray;
            this.qtyLbl.Location = new System.Drawing.Point(34, 84);
            this.qtyLbl.Name = "qtyLbl";
            this.qtyLbl.Size = new System.Drawing.Size(72, 20);
            this.qtyLbl.TabIndex = 36;
            this.qtyLbl.Text = "Quantity:";
            // 
            // orderValLbl
            // 
            this.orderValLbl.AutoSize = true;
            this.orderValLbl.BackColor = System.Drawing.Color.Transparent;
            this.orderValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderValLbl.ForeColor = System.Drawing.Color.Gray;
            this.orderValLbl.Location = new System.Drawing.Point(34, 41);
            this.orderValLbl.Name = "orderValLbl";
            this.orderValLbl.Size = new System.Drawing.Size(98, 20);
            this.orderValLbl.TabIndex = 35;
            this.orderValLbl.Text = "Order Value:";
            // 
            // amendButton
            // 
            this.amendButton.BackColor = System.Drawing.Color.Linen;
            this.amendButton.Location = new System.Drawing.Point(316, 203);
            this.amendButton.Name = "amendButton";
            this.amendButton.Size = new System.Drawing.Size(75, 23);
            this.amendButton.TabIndex = 30;
            this.amendButton.Text = "Amend";
            this.amendButton.UseMnemonic = false;
            this.amendButton.UseVisualStyleBackColor = false;
            this.amendButton.Click += new System.EventHandler(this.amendButton_Click);
            // 
            // mainDishLbl
            // 
            this.mainDishLbl.AutoSize = true;
            this.mainDishLbl.BackColor = System.Drawing.Color.Transparent;
            this.mainDishLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDishLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.mainDishLbl.Location = new System.Drawing.Point(34, 41);
            this.mainDishLbl.Name = "mainDishLbl";
            this.mainDishLbl.Size = new System.Drawing.Size(83, 20);
            this.mainDishLbl.TabIndex = 31;
            this.mainDishLbl.Text = "Main Dish:";
            // 
            // DispatchBtn
            // 
            this.DispatchBtn.BackColor = System.Drawing.Color.Linen;
            this.DispatchBtn.Location = new System.Drawing.Point(281, 81);
            this.DispatchBtn.Name = "DispatchBtn";
            this.DispatchBtn.Size = new System.Drawing.Size(161, 23);
            this.DispatchBtn.TabIndex = 31;
            this.DispatchBtn.Text = "Mark Order as Dispatched";
            this.DispatchBtn.UseVisualStyleBackColor = false;
            this.DispatchBtn.Click += new System.EventHandler(this.DispatchBtn_Click);
            // 
            // getTotalBtn
            // 
            this.getTotalBtn.BackColor = System.Drawing.Color.Linen;
            this.getTotalBtn.Location = new System.Drawing.Point(39, 417);
            this.getTotalBtn.Name = "getTotalBtn";
            this.getTotalBtn.Size = new System.Drawing.Size(75, 23);
            this.getTotalBtn.TabIndex = 43;
            this.getTotalBtn.Text = "Get Total";
            this.getTotalBtn.UseMnemonic = false;
            this.getTotalBtn.UseVisualStyleBackColor = false;
            this.getTotalBtn.Click += new System.EventHandler(this.getTotalBtn_Click);
            // 
            // getNewTotalLbl
            // 
            this.getNewTotalLbl.AutoSize = true;
            this.getNewTotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.getNewTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNewTotalLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.getNewTotalLbl.Location = new System.Drawing.Point(36, 385);
            this.getNewTotalLbl.Name = "getNewTotalLbl";
            this.getNewTotalLbl.Size = new System.Drawing.Size(429, 16);
            this.getNewTotalLbl.TabIndex = 44;
            this.getNewTotalLbl.Text = "If you chaged the quantity, Please click here to get the new Order Value:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::SoftwareProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 537);
            this.Controls.Add(this.getTotalBtn);
            this.Controls.Add(this.getNewTotalLbl);
            this.Controls.Add(this.DispatchBtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.orderIdBox);
            this.Controls.Add(this.OrderIdLbl);
            this.Controls.Add(this.amendLbl);
            this.Controls.Add(this.dateBar);
            this.Controls.Add(this.allMenu);
            this.Controls.Add(this.grpOrder);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            this.allMenu.ResumeLayout(false);
            this.allMenu.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
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
        private System.Windows.Forms.Label amendLbl;
        private System.Windows.Forms.TextBox orderIdBox;
        private System.Windows.Forms.Label OrderIdLbl;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button amendButton;
        private System.Windows.Forms.Label mainDishLbl;
        private System.Windows.Forms.Label orderValLbl;
        private System.Windows.Forms.Label dispLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label qtyLbl;
        private System.Windows.Forms.TextBox dspTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox qtyTxt;
        private System.Windows.Forms.TextBox orderValTxt;
        private System.Windows.Forms.Button DispatchBtn;
        private System.Windows.Forms.Button getTotalBtn;
        private System.Windows.Forms.Label getNewTotalLbl;
    }
}