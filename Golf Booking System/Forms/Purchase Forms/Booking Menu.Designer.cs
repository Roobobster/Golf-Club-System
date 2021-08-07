namespace Golf_Booking_System
{
    partial class Booking_Menu
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpBookingStartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingEndTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAvailable = new System.Windows.Forms.Button();
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
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(435, 90);
            this.pnlHeader.TabIndex = 62;
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
            this.btnMinimize.Location = new System.Drawing.Point(247, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 6;
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
            this.btnExit.Location = new System.Drawing.Point(338, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dtpBookingStartTime
            // 
            this.dtpBookingStartTime.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dtpBookingStartTime.CalendarTitleBackColor = System.Drawing.Color.ForestGreen;
            this.dtpBookingStartTime.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpBookingStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingStartTime.Location = new System.Drawing.Point(199, 175);
            this.dtpBookingStartTime.Name = "dtpBookingStartTime";
            this.dtpBookingStartTime.ShowUpDown = true;
            this.dtpBookingStartTime.Size = new System.Drawing.Size(200, 29);
            this.dtpBookingStartTime.TabIndex = 2;
            this.dtpBookingStartTime.ValueChanged += new System.EventHandler(this.BookingStartTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Booking Start Time:";
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDate.Location = new System.Drawing.Point(66, 134);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(127, 24);
            this.lblBookingDate.TabIndex = 75;
            this.lblBookingDate.Text = "Booking Date:";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dtpBookingDate.CalendarTitleBackColor = System.Drawing.Color.ForestGreen;
            this.dtpBookingDate.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Location = new System.Drawing.Point(199, 129);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(200, 29);
            this.dtpBookingDate.TabIndex = 1;
            this.dtpBookingDate.ValueChanged += new System.EventHandler(this.BookingDate_ValueChanged);
            // 
            // dtpBookingEndTime
            // 
            this.dtpBookingEndTime.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dtpBookingEndTime.CalendarTitleBackColor = System.Drawing.Color.ForestGreen;
            this.dtpBookingEndTime.CalendarTrailingForeColor = System.Drawing.Color.DimGray;
            this.dtpBookingEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingEndTime.Location = new System.Drawing.Point(199, 219);
            this.dtpBookingEndTime.Name = "dtpBookingEndTime";
            this.dtpBookingEndTime.ShowUpDown = true;
            this.dtpBookingEndTime.Size = new System.Drawing.Size(200, 29);
            this.dtpBookingEndTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Booking End Time:";
            // 
            // btnViewAvailable
            // 
            this.btnViewAvailable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnViewAvailable.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.btnViewAvailable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAvailable.ForeColor = System.Drawing.Color.LightYellow;
            this.btnViewAvailable.Location = new System.Drawing.Point(25, 267);
            this.btnViewAvailable.Name = "btnViewAvailable";
            this.btnViewAvailable.Size = new System.Drawing.Size(374, 50);
            this.btnViewAvailable.TabIndex = 4;
            this.btnViewAvailable.Text = "View Available";
            this.btnViewAvailable.UseVisualStyleBackColor = false;
            this.btnViewAvailable.Click += new System.EventHandler(this.ViewAvailable_Click);
            // 
            // Booking_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 347);
            this.Controls.Add(this.btnViewAvailable);
            this.Controls.Add(this.dtpBookingEndTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBookingStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBookingDate);
            this.Controls.Add(this.dtpBookingDate);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booking_Menu";
            this.Text = "Driving_Range_Booking_Menu";
            this.Load += new System.EventHandler(this.Driving_Range_Booking_Menu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpBookingStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DateTimePicker dtpBookingEndTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAvailable;
    }
}