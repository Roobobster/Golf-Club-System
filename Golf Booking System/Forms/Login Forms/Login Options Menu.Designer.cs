namespace Golf_Booking_System
{
    partial class Login_Option_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Option_Menu));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddLogin = new System.Windows.Forms.Button();
            this.btnChangeLoginPassword = new System.Windows.Forms.Button();
            this.btnRemoveLogin = new System.Windows.Forms.Button();
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
            this.pnlHeader.Size = new System.Drawing.Size(500, 90);
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
            this.btnBack.Location = new System.Drawing.Point(12, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 75);
            this.btnBack.TabIndex = 4;
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
            this.btnMinimize.Location = new System.Drawing.Point(319, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 5;
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
            this.btnExit.Location = new System.Drawing.Point(401, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAddLogin
            // 
            this.btnAddLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLogin.BackgroundImage")));
            this.btnAddLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLogin.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAddLogin.Location = new System.Drawing.Point(92, 127);
            this.btnAddLogin.Name = "btnAddLogin";
            this.btnAddLogin.Size = new System.Drawing.Size(301, 69);
            this.btnAddLogin.TabIndex = 1;
            this.btnAddLogin.Text = "Add Login";
            this.btnAddLogin.UseVisualStyleBackColor = false;
            this.btnAddLogin.Click += new System.EventHandler(this.AddLogin_Click);
            // 
            // btnChangeLoginPassword
            // 
            this.btnChangeLoginPassword.BackColor = System.Drawing.Color.ForestGreen;
            this.btnChangeLoginPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeLoginPassword.BackgroundImage")));
            this.btnChangeLoginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeLoginPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLoginPassword.ForeColor = System.Drawing.Color.LightYellow;
            this.btnChangeLoginPassword.Location = new System.Drawing.Point(92, 223);
            this.btnChangeLoginPassword.Name = "btnChangeLoginPassword";
            this.btnChangeLoginPassword.Size = new System.Drawing.Size(301, 69);
            this.btnChangeLoginPassword.TabIndex = 2;
            this.btnChangeLoginPassword.Text = "Change Login Password";
            this.btnChangeLoginPassword.UseVisualStyleBackColor = false;
            this.btnChangeLoginPassword.Click += new System.EventHandler(this.ChangeLoginPassword_Click);
            // 
            // btnRemoveLogin
            // 
            this.btnRemoveLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRemoveLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveLogin.BackgroundImage")));
            this.btnRemoveLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLogin.ForeColor = System.Drawing.Color.LightYellow;
            this.btnRemoveLogin.Location = new System.Drawing.Point(92, 324);
            this.btnRemoveLogin.Name = "btnRemoveLogin";
            this.btnRemoveLogin.Size = new System.Drawing.Size(301, 69);
            this.btnRemoveLogin.TabIndex = 3;
            this.btnRemoveLogin.Text = "Remove Login";
            this.btnRemoveLogin.UseVisualStyleBackColor = false;
            this.btnRemoveLogin.Click += new System.EventHandler(this.RemoveLogin_Click);
            // 
            // Login_Option_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 455);
            this.Controls.Add(this.btnRemoveLogin);
            this.Controls.Add(this.btnChangeLoginPassword);
            this.Controls.Add(this.btnAddLogin);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Option_Menu";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
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
        private System.Windows.Forms.Button btnAddLogin;
        private System.Windows.Forms.Button btnChangeLoginPassword;
        private System.Windows.Forms.Button btnRemoveLogin;
    }
}