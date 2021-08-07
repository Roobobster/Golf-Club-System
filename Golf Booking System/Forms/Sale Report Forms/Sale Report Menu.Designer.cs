namespace Golf_Booking_System
{
    partial class Sale_Report_Menu
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
            System.Windows.Forms.Button btnAnalysisOptions;
            System.Windows.Forms.Button btnViewAnalysis;
            System.Windows.Forms.Button btnSaveAnalyses;
            System.Windows.Forms.Button button3;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lstAnalyses = new System.Windows.Forms.ListBox();
            this.lblDrivingRangeBookings = new System.Windows.Forms.Label();
            this.chrtAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAnalysisOptions = new System.Windows.Forms.Button();
            btnViewAnalysis = new System.Windows.Forms.Button();
            btnSaveAnalyses = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnalysisOptions
            // 
            btnAnalysisOptions.BackColor = System.Drawing.Color.ForestGreen;
            btnAnalysisOptions.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            btnAnalysisOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAnalysisOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAnalysisOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAnalysisOptions.ForeColor = System.Drawing.Color.LightYellow;
            btnAnalysisOptions.Location = new System.Drawing.Point(12, 108);
            btnAnalysisOptions.Name = "btnAnalysisOptions";
            btnAnalysisOptions.Size = new System.Drawing.Size(321, 59);
            btnAnalysisOptions.TabIndex = 86;
            btnAnalysisOptions.Text = "Create Analyses";
            btnAnalysisOptions.UseVisualStyleBackColor = false;
            btnAnalysisOptions.Click += new System.EventHandler(this.btnAnalysisOptions_Click);
            // 
            // btnViewAnalysis
            // 
            btnViewAnalysis.BackColor = System.Drawing.Color.ForestGreen;
            btnViewAnalysis.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            btnViewAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnViewAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnViewAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnViewAnalysis.ForeColor = System.Drawing.Color.LightYellow;
            btnViewAnalysis.Location = new System.Drawing.Point(12, 194);
            btnViewAnalysis.Name = "btnViewAnalysis";
            btnViewAnalysis.Size = new System.Drawing.Size(321, 59);
            btnViewAnalysis.TabIndex = 87;
            btnViewAnalysis.Text = "View Analysis";
            btnViewAnalysis.UseVisualStyleBackColor = false;
            btnViewAnalysis.Click += new System.EventHandler(this.btnViewAnalysis_Click);
            // 
            // btnSaveAnalyses
            // 
            btnSaveAnalyses.BackColor = System.Drawing.Color.ForestGreen;
            btnSaveAnalyses.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            btnSaveAnalyses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSaveAnalyses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSaveAnalyses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSaveAnalyses.ForeColor = System.Drawing.Color.LightYellow;
            btnSaveAnalyses.Location = new System.Drawing.Point(12, 277);
            btnSaveAnalyses.Name = "btnSaveAnalyses";
            btnSaveAnalyses.Size = new System.Drawing.Size(321, 59);
            btnSaveAnalyses.TabIndex = 88;
            btnSaveAnalyses.Text = "Save Analysis";
            btnSaveAnalyses.UseVisualStyleBackColor = false;
            btnSaveAnalyses.Click += new System.EventHandler(this.btnSaveAnalyses_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.ForestGreen;
            button3.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.Red;
            button3.Location = new System.Drawing.Point(352, 307);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(420, 29);
            button3.TabIndex = 89;
            button3.Text = "Delete Analysis";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(819, 90);
            this.pnlHeader.TabIndex = 79;
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
            this.btnMinimize.Location = new System.Drawing.Point(617, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 17;
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
            this.btnExit.Location = new System.Drawing.Point(720, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 18;
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
            this.btnBack.TabIndex = 16;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // lstAnalyses
            // 
            this.lstAnalyses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnalyses.FormattingEnabled = true;
            this.lstAnalyses.ItemHeight = 24;
            this.lstAnalyses.Location = new System.Drawing.Point(352, 142);
            this.lstAnalyses.Name = "lstAnalyses";
            this.lstAnalyses.Size = new System.Drawing.Size(420, 172);
            this.lstAnalyses.TabIndex = 90;
            // 
            // lblDrivingRangeBookings
            // 
            this.lblDrivingRangeBookings.BackColor = System.Drawing.SystemColors.Info;
            this.lblDrivingRangeBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrivingRangeBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingRangeBookings.Location = new System.Drawing.Point(352, 108);
            this.lblDrivingRangeBookings.Name = "lblDrivingRangeBookings";
            this.lblDrivingRangeBookings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDrivingRangeBookings.Size = new System.Drawing.Size(420, 35);
            this.lblDrivingRangeBookings.TabIndex = 91;
            this.lblDrivingRangeBookings.Text = "Created Analyses";
            this.lblDrivingRangeBookings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chrtAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAnalysis.Legends.Add(legend1);
            this.chrtAnalysis.Location = new System.Drawing.Point(1000, 155);
            this.chrtAnalysis.Name = "chrtAnalysis";
            this.chrtAnalysis.Size = new System.Drawing.Size(300, 300);
            this.chrtAnalysis.TabIndex = 92;
            this.chrtAnalysis.Text = "chart1";
            // 
            // Sale_Report_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 362);
            this.Controls.Add(this.chrtAnalysis);
            this.Controls.Add(button3);
            this.Controls.Add(this.lblDrivingRangeBookings);
            this.Controls.Add(this.lstAnalyses);
            this.Controls.Add(btnSaveAnalyses);
            this.Controls.Add(btnViewAnalysis);
            this.Controls.Add(btnAnalysisOptions);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sale_Report_Menu";
            this.Text = "Sale_Report_Menu";
            this.Load += new System.EventHandler(this.Sale_Report_Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAnalysis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstAnalyses;
        private System.Windows.Forms.Label lblDrivingRangeBookings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAnalysis;
    }
}