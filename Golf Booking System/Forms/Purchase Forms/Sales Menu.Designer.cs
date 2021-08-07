namespace Golf_Booking_System
{
    partial class Sales_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Menu));
            this.btnItemSales = new System.Windows.Forms.Button();
            this.btnGolfCourseBookings = new System.Windows.Forms.Button();
            this.btnDrivingRangeBookings = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstPurchases = new System.Windows.Forms.ListBox();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTokens = new System.Windows.Forms.Label();
            this.BtnAddTokens = new System.Windows.Forms.Button();
            this.cmbTokens = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ckbIsVisitor = new System.Windows.Forms.CheckBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnItemSales
            // 
            this.btnItemSales.BackColor = System.Drawing.Color.ForestGreen;
            this.btnItemSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItemSales.BackgroundImage")));
            this.btnItemSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItemSales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSales.ForeColor = System.Drawing.Color.LightYellow;
            this.btnItemSales.Location = new System.Drawing.Point(12, 301);
            this.btnItemSales.Name = "btnItemSales";
            this.btnItemSales.Size = new System.Drawing.Size(301, 82);
            this.btnItemSales.TabIndex = 3;
            this.btnItemSales.Text = "Add Items";
            this.btnItemSales.UseVisualStyleBackColor = false;
            this.btnItemSales.Click += new System.EventHandler(this.ItemSales_Click);
            // 
            // btnGolfCourseBookings
            // 
            this.btnGolfCourseBookings.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGolfCourseBookings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGolfCourseBookings.BackgroundImage")));
            this.btnGolfCourseBookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGolfCourseBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGolfCourseBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGolfCourseBookings.ForeColor = System.Drawing.Color.LightYellow;
            this.btnGolfCourseBookings.Location = new System.Drawing.Point(12, 204);
            this.btnGolfCourseBookings.Name = "btnGolfCourseBookings";
            this.btnGolfCourseBookings.Size = new System.Drawing.Size(301, 82);
            this.btnGolfCourseBookings.TabIndex = 2;
            this.btnGolfCourseBookings.Text = "Add Golf Course Booking";
            this.btnGolfCourseBookings.UseVisualStyleBackColor = false;
            this.btnGolfCourseBookings.Click += new System.EventHandler(this.GolfCourseBookings_Click);
            // 
            // btnDrivingRangeBookings
            // 
            this.btnDrivingRangeBookings.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDrivingRangeBookings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrivingRangeBookings.BackgroundImage")));
            this.btnDrivingRangeBookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrivingRangeBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrivingRangeBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivingRangeBookings.ForeColor = System.Drawing.Color.LightYellow;
            this.btnDrivingRangeBookings.Location = new System.Drawing.Point(12, 105);
            this.btnDrivingRangeBookings.Name = "btnDrivingRangeBookings";
            this.btnDrivingRangeBookings.Size = new System.Drawing.Size(301, 82);
            this.btnDrivingRangeBookings.TabIndex = 1;
            this.btnDrivingRangeBookings.Text = "Add Driving Range Booking";
            this.btnDrivingRangeBookings.UseVisualStyleBackColor = false;
            this.btnDrivingRangeBookings.Click += new System.EventHandler(this.DrivingRangeBookings_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MinimizeIcon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(731, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Golf_Booking_System.Properties.Resources.ExitIcon;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(822, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(0, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(924, 90);
            this.pnlHeader.TabIndex = 66;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Golf_Booking_System.Properties.Resources.BackIcon;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 75);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // lstPurchases
            // 
            this.lstPurchases.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPurchases.FormattingEnabled = true;
            this.lstPurchases.HorizontalScrollbar = true;
            this.lstPurchases.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lstPurchases.IntegralHeight = false;
            this.lstPurchases.ItemHeight = 50;
            this.lstPurchases.Location = new System.Drawing.Point(349, 137);
            this.lstPurchases.Name = "lstPurchases";
            this.lstPurchases.Size = new System.Drawing.Size(558, 252);
            this.lstPurchases.TabIndex = 70;
            this.lstPurchases.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPurchases_DrawItem);
            this.lstPurchases.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.Purchases_MeasureItem);
            // 
            // lblPurchase
            // 
            this.lblPurchase.BackColor = System.Drawing.SystemColors.Info;
            this.lblPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(349, 105);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(558, 34);
            this.lblPurchase.TabIndex = 71;
            this.lblPurchase.Text = "Purchases";
            this.lblPurchase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPurchase.BackgroundImage")));
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.LightYellow;
            this.btnPurchase.Location = new System.Drawing.Point(349, 433);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(558, 75);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(349, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(558, 34);
            this.lblTotal.TabIndex = 72;
            this.lblTotal.Text = "Total: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTokens
            // 
            this.lblTokens.BackColor = System.Drawing.Color.Transparent;
            this.lblTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokens.Location = new System.Drawing.Point(7, 433);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(89, 31);
            this.lblTokens.TabIndex = 74;
            this.lblTokens.Text = "Tokens:";
            // 
            // BtnAddTokens
            // 
            this.BtnAddTokens.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAddTokens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddTokens.BackgroundImage")));
            this.BtnAddTokens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddTokens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTokens.ForeColor = System.Drawing.Color.LightYellow;
            this.BtnAddTokens.Location = new System.Drawing.Point(12, 470);
            this.BtnAddTokens.Name = "BtnAddTokens";
            this.BtnAddTokens.Size = new System.Drawing.Size(301, 38);
            this.BtnAddTokens.TabIndex = 5;
            this.BtnAddTokens.Text = "Add Tokens";
            this.BtnAddTokens.UseVisualStyleBackColor = false;
            this.BtnAddTokens.Click += new System.EventHandler(this.BtnAddTokens_Click);
            // 
            // cmbTokens
            // 
            this.cmbTokens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbTokens.FormattingEnabled = true;
            this.cmbTokens.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbTokens.Location = new System.Drawing.Point(90, 433);
            this.cmbTokens.Name = "cmbTokens";
            this.cmbTokens.Size = new System.Drawing.Size(223, 28);
            this.cmbTokens.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.LightYellow;
            this.btnEdit.Location = new System.Drawing.Point(746, 355);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(81, 28);
            this.btnEdit.TabIndex = 75;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Location = new System.Drawing.Point(826, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 28);
            this.btnRemove.TabIndex = 76;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(815, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 34);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ckbIsVisitor
            // 
            this.ckbIsVisitor.AutoSize = true;
            this.ckbIsVisitor.BackColor = System.Drawing.Color.Transparent;
            this.ckbIsVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIsVisitor.Location = new System.Drawing.Point(11, 393);
            this.ckbIsVisitor.Name = "ckbIsVisitor";
            this.ckbIsVisitor.Size = new System.Drawing.Size(85, 24);
            this.ckbIsVisitor.TabIndex = 78;
            this.ckbIsVisitor.Text = "IsVisitor";
            this.ckbIsVisitor.UseVisualStyleBackColor = false;
            // 
            // Sales_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 527);
            this.Controls.Add(this.ckbIsVisitor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbTokens);
            this.Controls.Add(this.BtnAddTokens);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.lstPurchases);
            this.Controls.Add(this.btnItemSales);
            this.Controls.Add(this.btnGolfCourseBookings);
            this.Controls.Add(this.btnDrivingRangeBookings);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Menu";
            this.Text = "Sales_Menu";
            this.Load += new System.EventHandler(this.Sales_Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemSales;
        private System.Windows.Forms.Button btnGolfCourseBookings;
        private System.Windows.Forms.Button btnDrivingRangeBookings;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstPurchases;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.Button BtnAddTokens;
        private System.Windows.Forms.ComboBox cmbTokens;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox ckbIsVisitor;
    }
}