namespace Golf_Booking_System
{
    partial class Remove_Member_Bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Member_Bookings));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGolfCourseBookings = new System.Windows.Forms.Label();
            this.lblDrivingRangeBookings = new System.Windows.Forms.Label();
            this.lstGolfCourseBookings = new System.Windows.Forms.ListBox();
            this.lstDrivingRangeBookings = new System.Windows.Forms.ListBox();
            this.btnRemoveGolfBooking = new System.Windows.Forms.Button();
            this.btnRemoveDrivingBooking = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(820, 90);
            this.pnlHeader.TabIndex = 62;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
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
            this.btnMinimize.Location = new System.Drawing.Point(638, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(729, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
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
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // lblGolfCourseBookings
            // 
            this.lblGolfCourseBookings.BackColor = System.Drawing.SystemColors.Info;
            this.lblGolfCourseBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGolfCourseBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolfCourseBookings.Location = new System.Drawing.Point(10, 120);
            this.lblGolfCourseBookings.Name = "lblGolfCourseBookings";
            this.lblGolfCourseBookings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGolfCourseBookings.Size = new System.Drawing.Size(350, 35);
            this.lblGolfCourseBookings.TabIndex = 73;
            this.lblGolfCourseBookings.Text = "Golf Course Bookings";
            this.lblGolfCourseBookings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDrivingRangeBookings
            // 
            this.lblDrivingRangeBookings.BackColor = System.Drawing.SystemColors.Info;
            this.lblDrivingRangeBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrivingRangeBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingRangeBookings.Location = new System.Drawing.Point(460, 120);
            this.lblDrivingRangeBookings.Name = "lblDrivingRangeBookings";
            this.lblDrivingRangeBookings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDrivingRangeBookings.Size = new System.Drawing.Size(350, 35);
            this.lblDrivingRangeBookings.TabIndex = 74;
            this.lblDrivingRangeBookings.Text = "Driving Range Bookings";
            this.lblDrivingRangeBookings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstGolfCourseBookings
            // 
            this.lstGolfCourseBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lstGolfCourseBookings.FormattingEnabled = true;
            this.lstGolfCourseBookings.ItemHeight = 22;
            this.lstGolfCourseBookings.Location = new System.Drawing.Point(10, 154);
            this.lstGolfCourseBookings.Name = "lstGolfCourseBookings";
            this.lstGolfCourseBookings.Size = new System.Drawing.Size(350, 246);
            this.lstGolfCourseBookings.TabIndex = 75;
            // 
            // lstDrivingRangeBookings
            // 
            this.lstDrivingRangeBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lstDrivingRangeBookings.FormattingEnabled = true;
            this.lstDrivingRangeBookings.ItemHeight = 22;
            this.lstDrivingRangeBookings.Location = new System.Drawing.Point(460, 154);
            this.lstDrivingRangeBookings.Name = "lstDrivingRangeBookings";
            this.lstDrivingRangeBookings.Size = new System.Drawing.Size(350, 246);
            this.lstDrivingRangeBookings.TabIndex = 76;
            // 
            // btnRemoveGolfBooking
            // 
            this.btnRemoveGolfBooking.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemoveGolfBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveGolfBooking.BackgroundImage")));
            this.btnRemoveGolfBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveGolfBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveGolfBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRemoveGolfBooking.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveGolfBooking.Location = new System.Drawing.Point(10, 399);
            this.btnRemoveGolfBooking.Name = "btnRemoveGolfBooking";
            this.btnRemoveGolfBooking.Size = new System.Drawing.Size(350, 46);
            this.btnRemoveGolfBooking.TabIndex = 1;
            this.btnRemoveGolfBooking.Text = "Remove Booking";
            this.btnRemoveGolfBooking.UseVisualStyleBackColor = false;
            this.btnRemoveGolfBooking.Click += new System.EventHandler(this.RemoveGolfBooking_Click);
            // 
            // btnRemoveDrivingBooking
            // 
            this.btnRemoveDrivingBooking.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemoveDrivingBooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveDrivingBooking.BackgroundImage")));
            this.btnRemoveDrivingBooking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveDrivingBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveDrivingBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRemoveDrivingBooking.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveDrivingBooking.Location = new System.Drawing.Point(460, 399);
            this.btnRemoveDrivingBooking.Name = "btnRemoveDrivingBooking";
            this.btnRemoveDrivingBooking.Size = new System.Drawing.Size(350, 46);
            this.btnRemoveDrivingBooking.TabIndex = 2;
            this.btnRemoveDrivingBooking.Text = "Remove Booking";
            this.btnRemoveDrivingBooking.UseVisualStyleBackColor = false;
            this.btnRemoveDrivingBooking.Click += new System.EventHandler(this.RemoveDrivingBooking_Click);
            // 
            // Remove_Member_Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 474);
            this.Controls.Add(this.btnRemoveDrivingBooking);
            this.Controls.Add(this.btnRemoveGolfBooking);
            this.Controls.Add(this.lstDrivingRangeBookings);
            this.Controls.Add(this.lstGolfCourseBookings);
            this.Controls.Add(this.lblDrivingRangeBookings);
            this.Controls.Add(this.lblGolfCourseBookings);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Remove_Member_Bookings";
            this.Text = "Remove_Member_Bookings";
            this.Load += new System.EventHandler(this.Remove_Member_Bookings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGolfCourseBookings;
        private System.Windows.Forms.Label lblDrivingRangeBookings;
        private System.Windows.Forms.ListBox lstGolfCourseBookings;
        private System.Windows.Forms.ListBox lstDrivingRangeBookings;
        private System.Windows.Forms.Button btnRemoveDrivingBooking;
        private System.Windows.Forms.Button btnRemoveGolfBooking;
    }
}