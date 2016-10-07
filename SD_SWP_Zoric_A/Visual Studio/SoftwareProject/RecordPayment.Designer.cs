namespace SoftwareProject
{
    partial class RecordPayment
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
            this.PaymentLbl = new System.Windows.Forms.Label();
            this.OrderIDTxt = new System.Windows.Forms.TextBox();
            this.PaymentIdLbl2 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.homebtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.payIDTxt = new System.Windows.Forms.TextBox();
            this.PayLbl = new System.Windows.Forms.Label();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
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
            this.allMenu.TabIndex = 6;
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
            this.dateBar.TabIndex = 8;
            // 
            // PaymentLbl
            // 
            this.PaymentLbl.AutoSize = true;
            this.PaymentLbl.BackColor = System.Drawing.Color.Transparent;
            this.PaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PaymentLbl.Location = new System.Drawing.Point(19, 49);
            this.PaymentLbl.Name = "PaymentLbl";
            this.PaymentLbl.Size = new System.Drawing.Size(306, 32);
            this.PaymentLbl.TabIndex = 9;
            this.PaymentLbl.Text = "Please enter the order ID,\r\nof the order you wish to set the payment for.";
            // 
            // OrderIDTxt
            // 
            this.OrderIDTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.OrderIDTxt.Location = new System.Drawing.Point(321, 111);
            this.OrderIDTxt.Name = "OrderIDTxt";
            this.OrderIDTxt.Size = new System.Drawing.Size(54, 20);
            this.OrderIDTxt.TabIndex = 13;
            this.OrderIDTxt.TextChanged += new System.EventHandler(this.OrderIDTxt_TextChanged);
            // 
            // PaymentIdLbl2
            // 
            this.PaymentIdLbl2.AutoSize = true;
            this.PaymentIdLbl2.BackColor = System.Drawing.Color.Transparent;
            this.PaymentIdLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentIdLbl2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PaymentIdLbl2.Location = new System.Drawing.Point(246, 111);
            this.PaymentIdLbl2.Name = "PaymentIdLbl2";
            this.PaymentIdLbl2.Size = new System.Drawing.Size(74, 20);
            this.PaymentIdLbl2.TabIndex = 12;
            this.PaymentIdLbl2.Text = "Order ID:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.totalLbl.Location = new System.Drawing.Point(258, 144);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(48, 20);
            this.totalLbl.TabIndex = 14;
            this.totalLbl.Text = "Total:";
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.totalBox.Location = new System.Drawing.Point(321, 146);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 15;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.Linen;
            this.homebtn.Location = new System.Drawing.Point(22, 227);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(75, 23);
            this.homebtn.TabIndex = 20;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Linen;
            this.submitBtn.Location = new System.Drawing.Point(373, 227);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 21;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // payIDTxt
            // 
            this.payIDTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.payIDTxt.Enabled = false;
            this.payIDTxt.Location = new System.Drawing.Point(111, 111);
            this.payIDTxt.Name = "payIDTxt";
            this.payIDTxt.Size = new System.Drawing.Size(49, 20);
            this.payIDTxt.TabIndex = 23;
            // 
            // PayLbl
            // 
            this.PayLbl.AutoSize = true;
            this.PayLbl.BackColor = System.Drawing.Color.Transparent;
            this.PayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PayLbl.Location = new System.Drawing.Point(18, 109);
            this.PayLbl.Name = "PayLbl";
            this.PayLbl.Size = new System.Drawing.Size(96, 20);
            this.PayLbl.TabIndex = 22;
            this.PayLbl.Text = "Payment ID:";
            // 
            // dateTxt
            // 
            this.dateTxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.dateTxt.Location = new System.Drawing.Point(81, 146);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(119, 20);
            this.dateTxt.TabIndex = 25;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.PapayaWhip;
            this.dateLbl.Location = new System.Drawing.Point(18, 144);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(48, 20);
            this.dateLbl.TabIndex = 24;
            this.dateLbl.Text = "Date:";
            // 
            // RecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::SoftwareProject.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.payIDTxt);
            this.Controls.Add(this.PayLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.OrderIDTxt);
            this.Controls.Add(this.PaymentIdLbl2);
            this.Controls.Add(this.PaymentLbl);
            this.Controls.Add(this.dateBar);
            this.Controls.Add(this.allMenu);
            this.Name = "RecordPayment";
            this.Text = "RecordPayment";
            this.Load += new System.EventHandler(this.RecordPayment_Load);
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
        private System.Windows.Forms.Label PaymentLbl;
        private System.Windows.Forms.TextBox OrderIDTxt;
        private System.Windows.Forms.Label PaymentIdLbl2;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox payIDTxt;
        private System.Windows.Forms.Label PayLbl;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Label dateLbl;
    }
}