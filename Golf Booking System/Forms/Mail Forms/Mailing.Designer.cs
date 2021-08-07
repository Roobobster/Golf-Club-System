namespace Golf_Booking_System
{
    partial class Mailing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mailing));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnComposeEmail = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.FileExplorer = new System.Windows.Forms.OpenFileDialog();
            this.lblAttachments = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.lblBackLoadBar = new System.Windows.Forms.Label();
            this.lblLoadBar = new System.Windows.Forms.Label();
            this.btnZip = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbCommon = new System.Windows.Forms.CheckBox();
            this.ckbPremium = new System.Windows.Forms.CheckBox();
            this.ckbSupreme = new System.Windows.Forms.CheckBox();
            this.lblReportTypes = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.btnRemoveAttachment = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(690, 85);
            this.pnlHeader.TabIndex = 29;
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
            this.btnBack.Location = new System.Drawing.Point(3, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 75);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(505, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 11;
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
            this.btnExit.Location = new System.Drawing.Point(596, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 12;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFolder.BackgroundImage")));
            this.btnAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFolder.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAddFolder.Location = new System.Drawing.Point(12, 224);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(202, 46);
            this.btnAddFolder.TabIndex = 3;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click += new System.EventHandler(this.AddFolder_Click);
            // 
            // btnComposeEmail
            // 
            this.btnComposeEmail.BackColor = System.Drawing.Color.ForestGreen;
            this.btnComposeEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComposeEmail.BackgroundImage")));
            this.btnComposeEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComposeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComposeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComposeEmail.ForeColor = System.Drawing.Color.LightYellow;
            this.btnComposeEmail.Location = new System.Drawing.Point(12, 101);
            this.btnComposeEmail.Name = "btnComposeEmail";
            this.btnComposeEmail.Size = new System.Drawing.Size(202, 46);
            this.btnComposeEmail.TabIndex = 1;
            this.btnComposeEmail.Text = "Compose Email";
            this.btnComposeEmail.UseVisualStyleBackColor = false;
            this.btnComposeEmail.Click += new System.EventHandler(this.ComposeEmail_Click_1);
            // 
            // lstAttachments
            // 
            this.lstAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 24;
            this.lstAttachments.Location = new System.Drawing.Point(247, 135);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(400, 244);
            this.lstAttachments.TabIndex = 64;
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFile.BackgroundImage")));
            this.btnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFile.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAddFile.Location = new System.Drawing.Point(12, 172);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(202, 46);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = false;
            this.btnAddFile.Click += new System.EventHandler(this.OpenAttachment_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmail.BackgroundImage")));
            this.btnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.LightYellow;
            this.btnEmail.Location = new System.Drawing.Point(247, 474);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(400, 46);
            this.btnEmail.TabIndex = 9;
            this.btnEmail.Text = "Send Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.Email_Click);
            // 
            // FileExplorer
            // 
            this.FileExplorer.Multiselect = true;
            // 
            // lblAttachments
            // 
            this.lblAttachments.BackColor = System.Drawing.SystemColors.Info;
            this.lblAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachments.Location = new System.Drawing.Point(247, 101);
            this.lblAttachments.Name = "lblAttachments";
            this.lblAttachments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAttachments.Size = new System.Drawing.Size(400, 34);
            this.lblAttachments.TabIndex = 72;
            this.lblAttachments.Text = "Attachments";
            this.lblAttachments.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotalSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSize.Location = new System.Drawing.Point(247, 377);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSize.Size = new System.Drawing.Size(400, 34);
            this.lblTotalSize.TabIndex = 74;
            this.lblTotalSize.Text = "Total Size:";
            this.lblTotalSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBackLoadBar
            // 
            this.lblBackLoadBar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblBackLoadBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBackLoadBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackLoadBar.Location = new System.Drawing.Point(247, 411);
            this.lblBackLoadBar.Name = "lblBackLoadBar";
            this.lblBackLoadBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBackLoadBar.Size = new System.Drawing.Size(400, 20);
            this.lblBackLoadBar.TabIndex = 75;
            this.lblBackLoadBar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLoadBar
            // 
            this.lblLoadBar.BackColor = System.Drawing.Color.DarkRed;
            this.lblLoadBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoadBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadBar.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoadBar.Location = new System.Drawing.Point(247, 413);
            this.lblLoadBar.Name = "lblLoadBar";
            this.lblLoadBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLoadBar.Size = new System.Drawing.Size(0, 15);
            this.lblLoadBar.TabIndex = 76;
            this.lblLoadBar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnZip
            // 
            this.btnZip.BackColor = System.Drawing.Color.ForestGreen;
            this.btnZip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZip.BackgroundImage")));
            this.btnZip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZip.ForeColor = System.Drawing.Color.LightYellow;
            this.btnZip.Location = new System.Drawing.Point(12, 349);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(202, 46);
            this.btnZip.TabIndex = 5;
            this.btnZip.Text = "Zip Attachments";
            this.btnZip.UseVisualStyleBackColor = false;
            this.btnZip.Click += new System.EventHandler(this.Zip_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(-15, -15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 79;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(-15, -15);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 80;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-15, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 82;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckbCommon
            // 
            this.ckbCommon.AutoSize = true;
            this.ckbCommon.BackColor = System.Drawing.Color.Transparent;
            this.ckbCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ckbCommon.Location = new System.Drawing.Point(12, 431);
            this.ckbCommon.Name = "ckbCommon";
            this.ckbCommon.Size = new System.Drawing.Size(92, 24);
            this.ckbCommon.TabIndex = 6;
            this.ckbCommon.Text = "Common";
            this.ckbCommon.UseVisualStyleBackColor = false;
            // 
            // ckbPremium
            // 
            this.ckbPremium.AutoSize = true;
            this.ckbPremium.BackColor = System.Drawing.Color.Transparent;
            this.ckbPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ckbPremium.Location = new System.Drawing.Point(12, 462);
            this.ckbPremium.Name = "ckbPremium";
            this.ckbPremium.Size = new System.Drawing.Size(90, 24);
            this.ckbPremium.TabIndex = 7;
            this.ckbPremium.Text = "Premium";
            this.ckbPremium.UseVisualStyleBackColor = false;
            // 
            // ckbSupreme
            // 
            this.ckbSupreme.AutoSize = true;
            this.ckbSupreme.BackColor = System.Drawing.Color.Transparent;
            this.ckbSupreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ckbSupreme.Location = new System.Drawing.Point(12, 492);
            this.ckbSupreme.Name = "ckbSupreme";
            this.ckbSupreme.Size = new System.Drawing.Size(93, 24);
            this.ckbSupreme.TabIndex = 8;
            this.ckbSupreme.Text = "Supreme";
            this.ckbSupreme.UseVisualStyleBackColor = false;
            // 
            // lblReportTypes
            // 
            this.lblReportTypes.AutoSize = true;
            this.lblReportTypes.BackColor = System.Drawing.Color.Transparent;
            this.lblReportTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTypes.Location = new System.Drawing.Point(7, 403);
            this.lblReportTypes.Name = "lblReportTypes";
            this.lblReportTypes.Size = new System.Drawing.Size(108, 25);
            this.lblReportTypes.TabIndex = 86;
            this.lblReportTypes.Text = "Mail List:";
            // 
            // lblSubject
            // 
            this.lblSubject.BackColor = System.Drawing.Color.OrangeRed;
            this.lblSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(248, 437);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSubject.Size = new System.Drawing.Size(129, 34);
            this.lblSubject.TabIndex = 87;
            this.lblSubject.Text = "Email Subject";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBody
            // 
            this.lblBody.BackColor = System.Drawing.Color.OrangeRed;
            this.lblBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(518, 437);
            this.lblBody.Name = "lblBody";
            this.lblBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBody.Size = new System.Drawing.Size(129, 34);
            this.lblBody.TabIndex = 88;
            this.lblBody.Text = "Email Body";
            this.lblBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveAttachment
            // 
            this.btnRemoveAttachment.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemoveAttachment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveAttachment.BackgroundImage")));
            this.btnRemoveAttachment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveAttachment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveAttachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRemoveAttachment.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveAttachment.Location = new System.Drawing.Point(12, 276);
            this.btnRemoveAttachment.Name = "btnRemoveAttachment";
            this.btnRemoveAttachment.Size = new System.Drawing.Size(202, 46);
            this.btnRemoveAttachment.TabIndex = 4;
            this.btnRemoveAttachment.Text = "Remove Attachment";
            this.btnRemoveAttachment.UseVisualStyleBackColor = false;
            this.btnRemoveAttachment.Click += new System.EventHandler(this.RemoveSelectedAttachment);
            // 
            // Mailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 527);
            this.Controls.Add(this.btnRemoveAttachment);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblReportTypes);
            this.Controls.Add(this.ckbSupreme);
            this.Controls.Add(this.ckbPremium);
            this.Controls.Add(this.ckbCommon);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.lblLoadBar);
            this.Controls.Add(this.lblBackLoadBar);
            this.Controls.Add(this.lblTotalSize);
            this.Controls.Add(this.lblAttachments);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnComposeEmail);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mailing";
            this.Text = "Mailing";
            this.Load += new System.EventHandler(this.Mailing_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnComposeEmail;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.OpenFileDialog FileExplorer;
        private System.Windows.Forms.Label lblAttachments;
        private System.Windows.Forms.Label lblTotalSize;
        private System.Windows.Forms.Label lblBackLoadBar;
        private System.Windows.Forms.Label lblLoadBar;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbCommon;
        private System.Windows.Forms.CheckBox ckbPremium;
        private System.Windows.Forms.CheckBox ckbSupreme;
        private System.Windows.Forms.Label lblReportTypes;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Button btnRemoveAttachment;
    }
}