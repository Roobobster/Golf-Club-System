namespace Golf_Booking_System
{
    partial class GolfCourseBookings
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
            this.btnBook = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHole17 = new System.Windows.Forms.Button();
            this.btnHole16 = new System.Windows.Forms.Button();
            this.btnHole14 = new System.Windows.Forms.Button();
            this.btnHole15 = new System.Windows.Forms.Button();
            this.btnHole18 = new System.Windows.Forms.Button();
            this.btnHole13 = new System.Windows.Forms.Button();
            this.btnHole11 = new System.Windows.Forms.Button();
            this.btnHole12 = new System.Windows.Forms.Button();
            this.btnHole1 = new System.Windows.Forms.Button();
            this.btnHole10 = new System.Windows.Forms.Button();
            this.btnHole3 = new System.Windows.Forms.Button();
            this.btnHole9 = new System.Windows.Forms.Button();
            this.btnHole2 = new System.Windows.Forms.Button();
            this.btnHole7 = new System.Windows.Forms.Button();
            this.btnHole8 = new System.Windows.Forms.Button();
            this.btnHole4 = new System.Windows.Forms.Button();
            this.btnHole6 = new System.Windows.Forms.Button();
            this.btnHole5 = new System.Windows.Forms.Button();
            this.lblSelectedHoles = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBook.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.LightYellow;
            this.btnBook.Location = new System.Drawing.Point(14, 576);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(301, 82);
            this.btnBook.TabIndex = 19;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.Book_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1271, 90);
            this.pnlHeader.TabIndex = 61;
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
            this.btnMinimize.Location = new System.Drawing.Point(1095, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(85, 75);
            this.btnMinimize.TabIndex = 21;
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
            this.btnExit.Location = new System.Drawing.Point(1186, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 75);
            this.btnExit.TabIndex = 22;
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
            this.btnBack.TabIndex = 20;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Golf_Course_Layout;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnHole17);
            this.panel1.Controls.Add(this.btnHole16);
            this.panel1.Controls.Add(this.btnHole14);
            this.panel1.Controls.Add(this.btnHole15);
            this.panel1.Controls.Add(this.btnHole18);
            this.panel1.Controls.Add(this.btnHole13);
            this.panel1.Controls.Add(this.btnHole11);
            this.panel1.Controls.Add(this.btnHole12);
            this.panel1.Controls.Add(this.btnHole1);
            this.panel1.Controls.Add(this.btnHole10);
            this.panel1.Controls.Add(this.btnHole3);
            this.panel1.Controls.Add(this.btnHole9);
            this.panel1.Controls.Add(this.btnHole2);
            this.panel1.Controls.Add(this.btnHole7);
            this.panel1.Controls.Add(this.btnHole8);
            this.panel1.Controls.Add(this.btnHole4);
            this.panel1.Controls.Add(this.btnHole6);
            this.panel1.Controls.Add(this.btnHole5);
            this.panel1.Location = new System.Drawing.Point(90, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 454);
            this.panel1.TabIndex = 80;
            // 
            // btnHole17
            // 
            this.btnHole17.BackColor = System.Drawing.Color.Transparent;
            this.btnHole17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole17.FlatAppearance.BorderSize = 0;
            this.btnHole17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole17.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole17.Location = new System.Drawing.Point(74, 192);
            this.btnHole17.Name = "btnHole17";
            this.btnHole17.Size = new System.Drawing.Size(25, 18);
            this.btnHole17.TabIndex = 17;
            this.btnHole17.Tag = "17";
            this.btnHole17.UseVisualStyleBackColor = false;
            this.btnHole17.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole16
            // 
            this.btnHole16.BackColor = System.Drawing.Color.Transparent;
            this.btnHole16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole16.FlatAppearance.BorderSize = 0;
            this.btnHole16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole16.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole16.Location = new System.Drawing.Point(130, 247);
            this.btnHole16.Name = "btnHole16";
            this.btnHole16.Size = new System.Drawing.Size(25, 18);
            this.btnHole16.TabIndex = 16;
            this.btnHole16.Tag = "16";
            this.btnHole16.UseVisualStyleBackColor = false;
            this.btnHole16.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole14
            // 
            this.btnHole14.BackColor = System.Drawing.Color.Transparent;
            this.btnHole14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole14.FlatAppearance.BorderSize = 0;
            this.btnHole14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole14.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole14.Location = new System.Drawing.Point(185, 340);
            this.btnHole14.Name = "btnHole14";
            this.btnHole14.Size = new System.Drawing.Size(25, 18);
            this.btnHole14.TabIndex = 14;
            this.btnHole14.Tag = "14";
            this.btnHole14.UseVisualStyleBackColor = false;
            this.btnHole14.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole15
            // 
            this.btnHole15.BackColor = System.Drawing.Color.Transparent;
            this.btnHole15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole15.FlatAppearance.BorderSize = 0;
            this.btnHole15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole15.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole15.Location = new System.Drawing.Point(188, 275);
            this.btnHole15.Name = "btnHole15";
            this.btnHole15.Size = new System.Drawing.Size(25, 18);
            this.btnHole15.TabIndex = 15;
            this.btnHole15.Tag = "15";
            this.btnHole15.UseVisualStyleBackColor = false;
            this.btnHole15.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole18
            // 
            this.btnHole18.BackColor = System.Drawing.Color.Transparent;
            this.btnHole18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole18.FlatAppearance.BorderSize = 0;
            this.btnHole18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole18.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole18.Location = new System.Drawing.Point(179, 181);
            this.btnHole18.Name = "btnHole18";
            this.btnHole18.Size = new System.Drawing.Size(25, 18);
            this.btnHole18.TabIndex = 18;
            this.btnHole18.Tag = "18";
            this.btnHole18.UseVisualStyleBackColor = false;
            this.btnHole18.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole13
            // 
            this.btnHole13.BackColor = System.Drawing.Color.Transparent;
            this.btnHole13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole13.FlatAppearance.BorderSize = 0;
            this.btnHole13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole13.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole13.Location = new System.Drawing.Point(366, 223);
            this.btnHole13.Name = "btnHole13";
            this.btnHole13.Size = new System.Drawing.Size(25, 18);
            this.btnHole13.TabIndex = 13;
            this.btnHole13.Tag = "13";
            this.btnHole13.UseVisualStyleBackColor = false;
            this.btnHole13.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole11
            // 
            this.btnHole11.BackColor = System.Drawing.Color.Transparent;
            this.btnHole11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole11.FlatAppearance.BorderSize = 0;
            this.btnHole11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole11.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole11.Location = new System.Drawing.Point(410, 378);
            this.btnHole11.Name = "btnHole11";
            this.btnHole11.Size = new System.Drawing.Size(25, 18);
            this.btnHole11.TabIndex = 11;
            this.btnHole11.Tag = "11";
            this.btnHole11.UseVisualStyleBackColor = false;
            this.btnHole11.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole12
            // 
            this.btnHole12.BackColor = System.Drawing.Color.Transparent;
            this.btnHole12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole12.FlatAppearance.BorderSize = 0;
            this.btnHole12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole12.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole12.Location = new System.Drawing.Point(430, 288);
            this.btnHole12.Name = "btnHole12";
            this.btnHole12.Size = new System.Drawing.Size(25, 18);
            this.btnHole12.TabIndex = 12;
            this.btnHole12.Tag = "12";
            this.btnHole12.UseVisualStyleBackColor = false;
            this.btnHole12.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole1
            // 
            this.btnHole1.BackColor = System.Drawing.Color.Transparent;
            this.btnHole1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole1.FlatAppearance.BorderSize = 0;
            this.btnHole1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole1.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole1.Location = new System.Drawing.Point(522, 66);
            this.btnHole1.Name = "btnHole1";
            this.btnHole1.Size = new System.Drawing.Size(25, 18);
            this.btnHole1.TabIndex = 1;
            this.btnHole1.Tag = "1";
            this.btnHole1.UseVisualStyleBackColor = false;
            this.btnHole1.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole10
            // 
            this.btnHole10.BackColor = System.Drawing.Color.Transparent;
            this.btnHole10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole10.FlatAppearance.BorderSize = 0;
            this.btnHole10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole10.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole10.Location = new System.Drawing.Point(471, 182);
            this.btnHole10.Name = "btnHole10";
            this.btnHole10.Size = new System.Drawing.Size(25, 18);
            this.btnHole10.TabIndex = 10;
            this.btnHole10.Tag = "10";
            this.btnHole10.UseVisualStyleBackColor = false;
            this.btnHole10.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole3
            // 
            this.btnHole3.BackColor = System.Drawing.Color.Transparent;
            this.btnHole3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole3.FlatAppearance.BorderSize = 0;
            this.btnHole3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole3.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole3.Location = new System.Drawing.Point(826, 134);
            this.btnHole3.Name = "btnHole3";
            this.btnHole3.Size = new System.Drawing.Size(25, 18);
            this.btnHole3.TabIndex = 3;
            this.btnHole3.Tag = "3";
            this.btnHole3.UseVisualStyleBackColor = false;
            this.btnHole3.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole9
            // 
            this.btnHole9.BackColor = System.Drawing.Color.Transparent;
            this.btnHole9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole9.FlatAppearance.BorderSize = 0;
            this.btnHole9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole9.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole9.Location = new System.Drawing.Point(562, 120);
            this.btnHole9.Name = "btnHole9";
            this.btnHole9.Size = new System.Drawing.Size(25, 18);
            this.btnHole9.TabIndex = 9;
            this.btnHole9.Tag = "9";
            this.btnHole9.UseVisualStyleBackColor = false;
            this.btnHole9.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole2
            // 
            this.btnHole2.BackColor = System.Drawing.Color.Transparent;
            this.btnHole2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole2.FlatAppearance.BorderSize = 0;
            this.btnHole2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole2.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole2.Location = new System.Drawing.Point(623, 186);
            this.btnHole2.Name = "btnHole2";
            this.btnHole2.Size = new System.Drawing.Size(25, 18);
            this.btnHole2.TabIndex = 2;
            this.btnHole2.Tag = "2";
            this.btnHole2.UseVisualStyleBackColor = false;
            this.btnHole2.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole7
            // 
            this.btnHole7.BackColor = System.Drawing.Color.Transparent;
            this.btnHole7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole7.FlatAppearance.BorderSize = 0;
            this.btnHole7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole7.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole7.Location = new System.Drawing.Point(782, 189);
            this.btnHole7.Name = "btnHole7";
            this.btnHole7.Size = new System.Drawing.Size(25, 18);
            this.btnHole7.TabIndex = 7;
            this.btnHole7.Tag = "7";
            this.btnHole7.UseVisualStyleBackColor = false;
            this.btnHole7.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole8
            // 
            this.btnHole8.BackColor = System.Drawing.Color.Transparent;
            this.btnHole8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole8.FlatAppearance.BorderSize = 0;
            this.btnHole8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole8.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole8.Location = new System.Drawing.Point(656, 252);
            this.btnHole8.Name = "btnHole8";
            this.btnHole8.Size = new System.Drawing.Size(25, 18);
            this.btnHole8.TabIndex = 8;
            this.btnHole8.Tag = "8";
            this.btnHole8.UseVisualStyleBackColor = false;
            this.btnHole8.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole4
            // 
            this.btnHole4.BackColor = System.Drawing.Color.Transparent;
            this.btnHole4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole4.FlatAppearance.BorderSize = 0;
            this.btnHole4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole4.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole4.Location = new System.Drawing.Point(965, 162);
            this.btnHole4.Name = "btnHole4";
            this.btnHole4.Size = new System.Drawing.Size(25, 18);
            this.btnHole4.TabIndex = 4;
            this.btnHole4.Tag = "4";
            this.btnHole4.UseVisualStyleBackColor = false;
            this.btnHole4.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole6
            // 
            this.btnHole6.BackColor = System.Drawing.Color.Transparent;
            this.btnHole6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole6.FlatAppearance.BorderSize = 0;
            this.btnHole6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole6.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole6.Location = new System.Drawing.Point(898, 263);
            this.btnHole6.Name = "btnHole6";
            this.btnHole6.Size = new System.Drawing.Size(25, 18);
            this.btnHole6.TabIndex = 6;
            this.btnHole6.Tag = "6";
            this.btnHole6.UseVisualStyleBackColor = false;
            this.btnHole6.Click += new System.EventHandler(this.Hole_Click);
            // 
            // btnHole5
            // 
            this.btnHole5.BackColor = System.Drawing.Color.Transparent;
            this.btnHole5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHole5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHole5.FlatAppearance.BorderSize = 0;
            this.btnHole5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHole5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHole5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHole5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHole5.ForeColor = System.Drawing.Color.Transparent;
            this.btnHole5.Location = new System.Drawing.Point(923, 329);
            this.btnHole5.Name = "btnHole5";
            this.btnHole5.Size = new System.Drawing.Size(25, 18);
            this.btnHole5.TabIndex = 5;
            this.btnHole5.Tag = "5";
            this.btnHole5.UseVisualStyleBackColor = false;
            this.btnHole5.Click += new System.EventHandler(this.Hole_Click);
            // 
            // lblSelectedHoles
            // 
            this.lblSelectedHoles.BackColor = System.Drawing.Color.ForestGreen;
            this.lblSelectedHoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedHoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedHoles.ForeColor = System.Drawing.Color.LightYellow;
            this.lblSelectedHoles.Location = new System.Drawing.Point(332, 576);
            this.lblSelectedHoles.Name = "lblSelectedHoles";
            this.lblSelectedHoles.Size = new System.Drawing.Size(793, 37);
            this.lblSelectedHoles.TabIndex = 81;
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddAll.BackgroundImage = global::Golf_Booking_System.Properties.Resources.Panel;
            this.btnAddAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAddAll.Location = new System.Drawing.Point(1131, 576);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(125, 37);
            this.btnAddAll.TabIndex = 82;
            this.btnAddAll.Text = "Add All Holes";
            this.btnAddAll.UseVisualStyleBackColor = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1169, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Booked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1169, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Selected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1169, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Available";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(1146, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "  ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(1146, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1146, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 88;
            this.label6.Text = "  ";
            // 
            // GolfCourseBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Golf_Booking_System.Properties.Resources.MainBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.lblSelectedHoles);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GolfCourseBookings";
            this.Text = "Golf_Course_Bookings";
            this.Load += new System.EventHandler(this.Golf_Course_Bookings_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHole5;
        private System.Windows.Forms.Button btnHole17;
        private System.Windows.Forms.Button btnHole16;
        private System.Windows.Forms.Button btnHole14;
        private System.Windows.Forms.Button btnHole15;
        private System.Windows.Forms.Button btnHole18;
        private System.Windows.Forms.Button btnHole13;
        private System.Windows.Forms.Button btnHole11;
        private System.Windows.Forms.Button btnHole12;
        private System.Windows.Forms.Button btnHole1;
        private System.Windows.Forms.Button btnHole10;
        private System.Windows.Forms.Button btnHole3;
        private System.Windows.Forms.Button btnHole9;
        private System.Windows.Forms.Button btnHole2;
        private System.Windows.Forms.Button btnHole7;
        private System.Windows.Forms.Button btnHole8;
        private System.Windows.Forms.Button btnHole4;
        private System.Windows.Forms.Button btnHole6;
        private System.Windows.Forms.Label lblSelectedHoles;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}