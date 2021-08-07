namespace Golf_Booking_System
{
    partial class Add_Item
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblLendPrice = new System.Windows.Forms.Label();
            this.txtLendPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSellQuantity = new System.Windows.Forms.Label();
            this.txtSellQuantity = new System.Windows.Forms.TextBox();
            this.lblLendQuantity = new System.Windows.Forms.Label();
            this.txtLendQuantity = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
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
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(26, 135);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(120, 25);
            this.lblItemName.TabIndex = 51;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(152, 132);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(274, 31);
            this.txtItemName.TabIndex = 1;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.Location = new System.Drawing.Point(37, 248);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(109, 25);
            this.lblSellPrice.TabIndex = 55;
            this.lblSellPrice.Text = "Sell Price:";

            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellPrice.Location = new System.Drawing.Point(152, 245);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(274, 31);
            this.txtSellPrice.TabIndex = 4;

            // 
            // lblLendPrice
            // 
            this.lblLendPrice.AutoSize = true;
            this.lblLendPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblLendPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLendPrice.Location = new System.Drawing.Point(26, 285);
            this.lblLendPrice.Name = "lblLendPrice";
            this.lblLendPrice.Size = new System.Drawing.Size(121, 25);
            this.lblLendPrice.TabIndex = 57;
            this.lblLendPrice.Text = "Lend Price:";

            // 
            // txtLendPrice
            // 
            this.txtLendPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLendPrice.Location = new System.Drawing.Point(152, 282);
            this.txtLendPrice.Name = "txtLendPrice";
            this.txtLendPrice.Size = new System.Drawing.Size(274, 31);
            this.txtLendPrice.TabIndex = 5;

            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddItem.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAddItem.Location = new System.Drawing.Point(152, 328);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(274, 70);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.AddItem_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(368, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.Minimize_Click_1);
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
            this.btnExit.Location = new System.Drawing.Point(459, 0);
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
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(547, 90);
            this.pnlHeader.TabIndex = 59;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // lblSellQuantity
            // 
            this.lblSellQuantity.AutoSize = true;
            this.lblSellQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblSellQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellQuantity.Location = new System.Drawing.Point(12, 172);
            this.lblSellQuantity.Name = "lblSellQuantity";
            this.lblSellQuantity.Size = new System.Drawing.Size(140, 25);
            this.lblSellQuantity.TabIndex = 61;
            this.lblSellQuantity.Text = "Sell Quantity:";
            // 
            // txtSellQuantity
            // 
            this.txtSellQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellQuantity.Location = new System.Drawing.Point(152, 169);
            this.txtSellQuantity.Name = "txtSellQuantity";
            this.txtSellQuantity.Size = new System.Drawing.Size(274, 31);
            this.txtSellQuantity.TabIndex = 2;
            // 
            // lblLendQuantity
            // 
            this.lblLendQuantity.AutoSize = true;
            this.lblLendQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblLendQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLendQuantity.Location = new System.Drawing.Point(0, 211);
            this.lblLendQuantity.Name = "lblLendQuantity";
            this.lblLendQuantity.Size = new System.Drawing.Size(152, 25);
            this.lblLendQuantity.TabIndex = 63;
            this.lblLendQuantity.Text = "Lend Quantity:";
            // 
            // txtLendQuantity
            // 
            this.txtLendQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLendQuantity.Location = new System.Drawing.Point(152, 208);
            this.txtLendQuantity.Name = "txtLendQuantity";
            this.txtLendQuantity.Size = new System.Drawing.Size(274, 31);
            this.txtLendQuantity.TabIndex = 3;
            // 
            // frmAdd_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(547, 410);
            this.Controls.Add(this.lblLendQuantity);
            this.Controls.Add(this.txtLendQuantity);
            this.Controls.Add(this.lblSellQuantity);
            this.Controls.Add(this.txtSellQuantity);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblLendPrice);
            this.Controls.Add(this.txtLendPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdd_Item";
            this.Text = "Add_Item";
            this.Load += new System.EventHandler(this.Add_Item_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblLendPrice;
        private System.Windows.Forms.TextBox txtLendPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSellQuantity;
        private System.Windows.Forms.TextBox txtSellQuantity;
        private System.Windows.Forms.Label lblLendQuantity;
        private System.Windows.Forms.TextBox txtLendQuantity;
    }
}