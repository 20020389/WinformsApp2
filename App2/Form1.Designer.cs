
namespace App2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Control_Box = new System.Windows.Forms.Panel();
            this.Clock_Label1 = new System.Windows.Forms.Label();
            this.NameChoosing = new System.Windows.Forms.Label();
            this.Task_Bar = new System.Windows.Forms.Panel();
            this.IntroName1 = new System.Windows.Forms.Label();
            this.BaseForms = new System.Windows.Forms.Panel();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.Error_Log = new System.Windows.Forms.Label();
            this.CLock_Label = new System.Windows.Forms.Label();
            this.IntroName2 = new System.Windows.Forms.Label();
            this.TimeRunning1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HideTaskBar = new FontAwesome.Sharp.IconButton();
            this.Choose6 = new FontAwesome.Sharp.IconButton();
            this.Choose5 = new FontAwesome.Sharp.IconButton();
            this.Choose4 = new FontAwesome.Sharp.IconButton();
            this.Choose3 = new FontAwesome.Sharp.IconButton();
            this.Choose2 = new FontAwesome.Sharp.IconButton();
            this.Choose1 = new FontAwesome.Sharp.IconButton();
            this.LogoBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new FontAwesome.Sharp.IconPictureBox();
            this.FocusButton = new FontAwesome.Sharp.IconPictureBox();
            this.BackButton = new FontAwesome.Sharp.IconPictureBox();
            this.Full_Form_bt = new FontAwesome.Sharp.IconButton();
            this.Hide_Form_bt = new FontAwesome.Sharp.IconButton();
            this.Close_Form_bt = new FontAwesome.Sharp.IconButton();
            this.Icon_Box1 = new FontAwesome.Sharp.IconPictureBox();
            this.Control_Box.SuspendLayout();
            this.Task_Bar.SuspendLayout();
            this.BaseForms.SuspendLayout();
            this.Home_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FocusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_Box
            // 
            this.Control_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.Control_Box.Controls.Add(this.Clock_Label1);
            this.Control_Box.Controls.Add(this.CloseButton);
            this.Control_Box.Controls.Add(this.FocusButton);
            this.Control_Box.Controls.Add(this.BackButton);
            this.Control_Box.Controls.Add(this.Full_Form_bt);
            this.Control_Box.Controls.Add(this.NameChoosing);
            this.Control_Box.Controls.Add(this.Hide_Form_bt);
            this.Control_Box.Controls.Add(this.Close_Form_bt);
            this.Control_Box.Controls.Add(this.Icon_Box1);
            this.Control_Box.Location = new System.Drawing.Point(313, 0);
            this.Control_Box.Name = "Control_Box";
            this.Control_Box.Size = new System.Drawing.Size(1016, 82);
            this.Control_Box.TabIndex = 0;
            this.Control_Box.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Control_Box_MouseDoubleClick);
            this.Control_Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlBox_MouseMove);
            // 
            // Clock_Label1
            // 
            this.Clock_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_Label1.AutoSize = true;
            this.Clock_Label1.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Clock_Label1.Location = new System.Drawing.Point(666, 28);
            this.Clock_Label1.Name = "Clock_Label1";
            this.Clock_Label1.Size = new System.Drawing.Size(86, 21);
            this.Clock_Label1.TabIndex = 10;
            this.Clock_Label1.Text = "00:00:00";
            // 
            // NameChoosing
            // 
            this.NameChoosing.AutoSize = true;
            this.NameChoosing.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameChoosing.ForeColor = System.Drawing.SystemColors.Control;
            this.NameChoosing.Location = new System.Drawing.Point(92, 30);
            this.NameChoosing.Name = "NameChoosing";
            this.NameChoosing.Size = new System.Drawing.Size(61, 22);
            this.NameChoosing.TabIndex = 5;
            this.NameChoosing.Text = "Home";
            // 
            // Task_Bar
            // 
            this.Task_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(69)))));
            this.Task_Bar.Controls.Add(this.HideTaskBar);
            this.Task_Bar.Controls.Add(this.Choose6);
            this.Task_Bar.Controls.Add(this.Choose5);
            this.Task_Bar.Controls.Add(this.Choose4);
            this.Task_Bar.Controls.Add(this.Choose3);
            this.Task_Bar.Controls.Add(this.Choose2);
            this.Task_Bar.Controls.Add(this.Choose1);
            this.Task_Bar.Controls.Add(this.IntroName1);
            this.Task_Bar.Controls.Add(this.LogoBox1);
            this.Task_Bar.Location = new System.Drawing.Point(0, 0);
            this.Task_Bar.Name = "Task_Bar";
            this.Task_Bar.Size = new System.Drawing.Size(313, 813);
            this.Task_Bar.TabIndex = 1;
            // 
            // IntroName1
            // 
            this.IntroName1.AutoSize = true;
            this.IntroName1.BackColor = System.Drawing.Color.Transparent;
            this.IntroName1.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroName1.ForeColor = System.Drawing.Color.White;
            this.IntroName1.Location = new System.Drawing.Point(12, 127);
            this.IntroName1.Name = "IntroName1";
            this.IntroName1.Size = new System.Drawing.Size(234, 31);
            this.IntroName1.TabIndex = 1;
            this.IntroName1.Text = "Learn  to  Better";
            // 
            // BaseForms
            // 
            this.BaseForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.BaseForms.Controls.Add(this.Home_Panel);
            this.BaseForms.Location = new System.Drawing.Point(313, 79);
            this.BaseForms.Name = "BaseForms";
            this.BaseForms.Size = new System.Drawing.Size(1016, 734);
            this.BaseForms.TabIndex = 2;
            // 
            // Home_Panel
            // 
            this.Home_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.Home_Panel.Controls.Add(this.Error_Log);
            this.Home_Panel.Controls.Add(this.CLock_Label);
            this.Home_Panel.Controls.Add(this.IntroName2);
            this.Home_Panel.Controls.Add(this.pictureBox2);
            this.Home_Panel.Location = new System.Drawing.Point(0, 0);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(1015, 734);
            this.Home_Panel.TabIndex = 0;
            // 
            // Error_Log
            // 
            this.Error_Log.AutoSize = true;
            this.Error_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Error_Log.Location = new System.Drawing.Point(79, 636);
            this.Error_Log.Name = "Error_Log";
            this.Error_Log.Size = new System.Drawing.Size(873, 38);
            this.Error_Log.TabIndex = 5;
            this.Error_Log.Text = "Connect Failed, Please check your connect then reset app!";
            // 
            // CLock_Label
            // 
            this.CLock_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CLock_Label.AutoSize = true;
            this.CLock_Label.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLock_Label.ForeColor = System.Drawing.SystemColors.Control;
            this.CLock_Label.Location = new System.Drawing.Point(325, 317);
            this.CLock_Label.Name = "CLock_Label";
            this.CLock_Label.Size = new System.Drawing.Size(270, 66);
            this.CLock_Label.TabIndex = 4;
            this.CLock_Label.Text = "00:00:00";
            // 
            // IntroName2
            // 
            this.IntroName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IntroName2.AutoSize = true;
            this.IntroName2.BackColor = System.Drawing.Color.Transparent;
            this.IntroName2.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroName2.ForeColor = System.Drawing.Color.White;
            this.IntroName2.Location = new System.Drawing.Point(184, 239);
            this.IntroName2.Name = "IntroName2";
            this.IntroName2.Size = new System.Drawing.Size(577, 78);
            this.IntroName2.TabIndex = 3;
            this.IntroName2.Text = "Learn  to  Better";
            // 
            // TimeRunning1
            // 
            this.TimeRunning1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::App2.Properties.Resources.CatIcon1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(377, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(294, 260);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // HideTaskBar
            // 
            this.HideTaskBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideTaskBar.FlatAppearance.BorderSize = 0;
            this.HideTaskBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideTaskBar.IconChar = FontAwesome.Sharp.IconChar.CaretSquareLeft;
            this.HideTaskBar.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.HideTaskBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideTaskBar.Location = new System.Drawing.Point(259, 28);
            this.HideTaskBar.Name = "HideTaskBar";
            this.HideTaskBar.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.HideTaskBar.Size = new System.Drawing.Size(34, 34);
            this.HideTaskBar.TabIndex = 8;
            this.HideTaskBar.UseVisualStyleBackColor = true;
            this.HideTaskBar.Click += new System.EventHandler(this.HideTaskBar_Click);
            // 
            // Choose6
            // 
            this.Choose6.FlatAppearance.BorderSize = 0;
            this.Choose6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose6.ForeColor = System.Drawing.Color.White;
            this.Choose6.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.Choose6.IconColor = System.Drawing.Color.White;
            this.Choose6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Choose6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose6.Location = new System.Drawing.Point(0, 528);
            this.Choose6.Name = "Choose6";
            this.Choose6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Choose6.Size = new System.Drawing.Size(313, 64);
            this.Choose6.TabIndex = 7;
            this.Choose6.TabStop = false;
            this.Choose6.Text = "Zalo";
            this.Choose6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Choose6.UseVisualStyleBackColor = true;
            this.Choose6.Click += new System.EventHandler(this.Choose6_Click);
            // 
            // Choose5
            // 
            this.Choose5.FlatAppearance.BorderSize = 0;
            this.Choose5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose5.ForeColor = System.Drawing.Color.White;
            this.Choose5.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.Choose5.IconColor = System.Drawing.Color.White;
            this.Choose5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Choose5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose5.Location = new System.Drawing.Point(0, 458);
            this.Choose5.Name = "Choose5";
            this.Choose5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Choose5.Size = new System.Drawing.Size(313, 64);
            this.Choose5.TabIndex = 6;
            this.Choose5.TabStop = false;
            this.Choose5.Text = "Hackerrank";
            this.Choose5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Choose5.UseVisualStyleBackColor = true;
            this.Choose5.Click += new System.EventHandler(this.Choose5_Click);
            // 
            // Choose4
            // 
            this.Choose4.FlatAppearance.BorderSize = 0;
            this.Choose4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose4.ForeColor = System.Drawing.Color.White;
            this.Choose4.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.Choose4.IconColor = System.Drawing.Color.White;
            this.Choose4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Choose4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose4.Location = new System.Drawing.Point(0, 388);
            this.Choose4.Name = "Choose4";
            this.Choose4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Choose4.Size = new System.Drawing.Size(313, 64);
            this.Choose4.TabIndex = 5;
            this.Choose4.TabStop = false;
            this.Choose4.Text = "Courses";
            this.Choose4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Choose4.UseVisualStyleBackColor = true;
            this.Choose4.Click += new System.EventHandler(this.Choose4_Click);
            // 
            // Choose3
            // 
            this.Choose3.FlatAppearance.BorderSize = 0;
            this.Choose3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose3.ForeColor = System.Drawing.Color.White;
            this.Choose3.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.Choose3.IconColor = System.Drawing.Color.White;
            this.Choose3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Choose3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose3.Location = new System.Drawing.Point(0, 318);
            this.Choose3.Name = "Choose3";
            this.Choose3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Choose3.Size = new System.Drawing.Size(313, 64);
            this.Choose3.TabIndex = 4;
            this.Choose3.TabStop = false;
            this.Choose3.Text = "Facebook";
            this.Choose3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Choose3.UseVisualStyleBackColor = true;
            this.Choose3.Click += new System.EventHandler(this.Choose3_Click);
            // 
            // Choose2
            // 
            this.Choose2.FlatAppearance.BorderSize = 0;
            this.Choose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose2.ForeColor = System.Drawing.Color.White;
            this.Choose2.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.Choose2.IconColor = System.Drawing.SystemColors.Control;
            this.Choose2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Choose2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose2.Location = new System.Drawing.Point(0, 248);
            this.Choose2.Name = "Choose2";
            this.Choose2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Choose2.Size = new System.Drawing.Size(313, 64);
            this.Choose2.TabIndex = 3;
            this.Choose2.TabStop = false;
            this.Choose2.Text = "Youtube";
            this.Choose2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Choose2.UseVisualStyleBackColor = true;
            this.Choose2.Click += new System.EventHandler(this.Choose2_Click);
            // 
            // Choose1
            // 
            this.Choose1.FlatAppearance.BorderSize = 0;
            this.Choose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose1.ForeColor = System.Drawing.SystemColors.Control;
            this.Choose1.IconChar = FontAwesome.Sharp.IconChar.Google;
            this.Choose1.IconColor = System.Drawing.Color.White;
            this.Choose1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Choose1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose1.Location = new System.Drawing.Point(0, 178);
            this.Choose1.Name = "Choose1";
            this.Choose1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.Choose1.Size = new System.Drawing.Size(313, 64);
            this.Choose1.TabIndex = 2;
            this.Choose1.TabStop = false;
            this.Choose1.Text = "Google";
            this.Choose1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Choose1.UseVisualStyleBackColor = true;
            this.Choose1.Click += new System.EventHandler(this.Choose1_Click);
            // 
            // LogoBox1
            // 
            this.LogoBox1.BackgroundImage = global::App2.Properties.Resources.CatIcon1;
            this.LogoBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoBox1.Location = new System.Drawing.Point(81, 46);
            this.LogoBox1.Name = "LogoBox1";
            this.LogoBox1.Size = new System.Drawing.Size(123, 103);
            this.LogoBox1.TabIndex = 0;
            this.LogoBox1.TabStop = false;
            this.LogoBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(64)))));
            this.CloseButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.CloseButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.CloseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButton.IconSize = 25;
            this.CloseButton.Location = new System.Drawing.Point(280, 34);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(28, 25);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.RefeshButton_Click);
            // 
            // FocusButton
            // 
            this.FocusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(64)))));
            this.FocusButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.FocusButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.FocusButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.FocusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FocusButton.IconSize = 25;
            this.FocusButton.Location = new System.Drawing.Point(246, 34);
            this.FocusButton.Name = "FocusButton";
            this.FocusButton.Size = new System.Drawing.Size(28, 25);
            this.FocusButton.TabIndex = 8;
            this.FocusButton.TabStop = false;
            this.FocusButton.Click += new System.EventHandler(this.FocusButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(64)))));
            this.BackButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackButton.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.BackButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackButton.IconSize = 25;
            this.BackButton.Location = new System.Drawing.Point(212, 34);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(28, 25);
            this.BackButton.TabIndex = 7;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Full_Form_bt
            // 
            this.Full_Form_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Full_Form_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.Full_Form_bt.FlatAppearance.BorderSize = 0;
            this.Full_Form_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Full_Form_bt.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.Full_Form_bt.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Full_Form_bt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Full_Form_bt.IconSize = 25;
            this.Full_Form_bt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Full_Form_bt.Location = new System.Drawing.Point(928, 0);
            this.Full_Form_bt.Name = "Full_Form_bt";
            this.Full_Form_bt.Size = new System.Drawing.Size(43, 38);
            this.Full_Form_bt.TabIndex = 6;
            this.Full_Form_bt.TabStop = false;
            this.Full_Form_bt.UseVisualStyleBackColor = false;
            this.Full_Form_bt.Click += new System.EventHandler(this.Full_Form_bt_Click);
            // 
            // Hide_Form_bt
            // 
            this.Hide_Form_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Hide_Form_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.Hide_Form_bt.FlatAppearance.BorderSize = 0;
            this.Hide_Form_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_Form_bt.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.Hide_Form_bt.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Hide_Form_bt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Hide_Form_bt.IconSize = 25;
            this.Hide_Form_bt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Hide_Form_bt.Location = new System.Drawing.Point(885, 0);
            this.Hide_Form_bt.Margin = new System.Windows.Forms.Padding(0);
            this.Hide_Form_bt.Name = "Hide_Form_bt";
            this.Hide_Form_bt.Size = new System.Drawing.Size(43, 38);
            this.Hide_Form_bt.TabIndex = 4;
            this.Hide_Form_bt.TabStop = false;
            this.Hide_Form_bt.UseVisualStyleBackColor = false;
            this.Hide_Form_bt.Click += new System.EventHandler(this.Hide_Form_bt_Click);
            // 
            // Close_Form_bt
            // 
            this.Close_Form_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Form_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(61)))));
            this.Close_Form_bt.FlatAppearance.BorderSize = 0;
            this.Close_Form_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Form_bt.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.Close_Form_bt.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close_Form_bt.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Close_Form_bt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close_Form_bt.IconSize = 25;
            this.Close_Form_bt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Close_Form_bt.Location = new System.Drawing.Point(971, 0);
            this.Close_Form_bt.Name = "Close_Form_bt";
            this.Close_Form_bt.Size = new System.Drawing.Size(43, 38);
            this.Close_Form_bt.TabIndex = 3;
            this.Close_Form_bt.TabStop = false;
            this.Close_Form_bt.UseVisualStyleBackColor = false;
            this.Close_Form_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Icon_Box1
            // 
            this.Icon_Box1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(23)))), ((int)(((byte)(64)))));
            this.Icon_Box1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Icon_Box1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.Icon_Box1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Icon_Box1.IconSize = 37;
            this.Icon_Box1.Location = new System.Drawing.Point(45, 22);
            this.Icon_Box1.Name = "Icon_Box1";
            this.Icon_Box1.Size = new System.Drawing.Size(41, 37);
            this.Icon_Box1.TabIndex = 2;
            this.Icon_Box1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 812);
            this.ControlBox = false;
            this.Controls.Add(this.BaseForms);
            this.Controls.Add(this.Task_Bar);
            this.Controls.Add(this.Control_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 760);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Control_Box.ResumeLayout(false);
            this.Control_Box.PerformLayout();
            this.Task_Bar.ResumeLayout(false);
            this.Task_Bar.PerformLayout();
            this.BaseForms.ResumeLayout(false);
            this.Home_Panel.ResumeLayout(false);
            this.Home_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FocusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_Box1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_Box;
        private System.Windows.Forms.Panel Task_Bar;
        private FontAwesome.Sharp.IconPictureBox Icon_Box1;
        private System.Windows.Forms.Panel BaseForms;
        private FontAwesome.Sharp.IconButton Close_Form_bt;
        private FontAwesome.Sharp.IconButton Hide_Form_bt;
        private System.Windows.Forms.Label IntroName1;
        private System.Windows.Forms.PictureBox LogoBox1;
        private FontAwesome.Sharp.IconButton Choose6;
        private FontAwesome.Sharp.IconButton Choose5;
        private FontAwesome.Sharp.IconButton Choose4;
        private FontAwesome.Sharp.IconButton Choose3;
        private FontAwesome.Sharp.IconButton Choose2;
        private System.Windows.Forms.Label NameChoosing;
        private FontAwesome.Sharp.IconButton Choose1;
        private FontAwesome.Sharp.IconButton Full_Form_bt;
        private FontAwesome.Sharp.IconPictureBox BackButton;
        private FontAwesome.Sharp.IconPictureBox FocusButton;
        private FontAwesome.Sharp.IconPictureBox CloseButton;
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.Label IntroName2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CLock_Label;
        private System.Windows.Forms.Timer TimeRunning1;
        private System.Windows.Forms.Label Error_Log;
        private System.Windows.Forms.Label Clock_Label1;
        private FontAwesome.Sharp.IconButton HideTaskBar;
    }
}

