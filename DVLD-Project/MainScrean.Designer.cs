namespace DVLD_Project
{
    partial class MainScrean
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
            this.pnMenue = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btLogOut = new Sipaa.Framework.SButton();
            this.btApplications = new Sipaa.Framework.SButton();
            this.btPeople = new Sipaa.Framework.SButton();
            this.btDrivers = new Sipaa.Framework.SButton();
            this.btUsers = new Sipaa.Framework.SButton();
            this.btSetting = new Sipaa.Framework.SButton();
            this.btCurrentU = new Sipaa.Framework.SButton();
            this.btChangePassw = new Sipaa.Framework.SButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.picPersonalImage = new SATAUiFramework.Controls.SATAPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btMaxmiz = new CodeeloUI.Controls.CodeeloButton();
            this.btClose = new CodeeloUI.Controls.CodeeloButton();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.pnShow = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMenue.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalImage)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenue
            // 
            this.pnMenue.BackColor = System.Drawing.Color.Black;
            this.pnMenue.Controls.Add(this.tableLayoutPanel1);
            this.pnMenue.Controls.Add(this.panel2);
            this.pnMenue.Controls.Add(this.panel1);
            this.pnMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenue.Location = new System.Drawing.Point(0, 0);
            this.pnMenue.Name = "pnMenue";
            this.pnMenue.Size = new System.Drawing.Size(207, 889);
            this.pnMenue.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btLogOut, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btApplications, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btPeople, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btDrivers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btUsers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btSetting, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btCurrentU, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btChangePassw, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 678);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btLogOut
            // 
            this.btLogOut.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btLogOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btLogOut.BorderRadius = 10;
            this.btLogOut.BorderSize = 0;
            this.btLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btLogOut.FlatAppearance.BorderSize = 0;
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btLogOut.ForeColor = System.Drawing.Color.White;
            this.btLogOut.Image = global::DVLD_Project.Properties.Resources.log_out;
            this.btLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogOut.Location = new System.Drawing.Point(3, 631);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btLogOut.Size = new System.Drawing.Size(201, 44);
            this.btLogOut.TabIndex = 5;
            this.btLogOut.Text = " Sign Out";
            this.btLogOut.UseVisualStyleBackColor = false;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // btApplications
            // 
            this.btApplications.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btApplications.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btApplications.BorderRadius = 10;
            this.btApplications.BorderSize = 0;
            this.btApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btApplications.FlatAppearance.BorderSize = 0;
            this.btApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApplications.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btApplications.ForeColor = System.Drawing.Color.White;
            this.btApplications.Image = global::DVLD_Project.Properties.Resources.application;
            this.btApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btApplications.Location = new System.Drawing.Point(3, 3);
            this.btApplications.Name = "btApplications";
            this.btApplications.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btApplications.Size = new System.Drawing.Size(201, 56);
            this.btApplications.TabIndex = 0;
            this.btApplications.Text = "Applications";
            this.btApplications.UseVisualStyleBackColor = false;
            this.btApplications.Click += new System.EventHandler(this.btApplications_Click);
            // 
            // btPeople
            // 
            this.btPeople.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btPeople.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btPeople.BorderRadius = 10;
            this.btPeople.BorderSize = 0;
            this.btPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btPeople.FlatAppearance.BorderSize = 0;
            this.btPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPeople.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btPeople.ForeColor = System.Drawing.Color.White;
            this.btPeople.Image = global::DVLD_Project.Properties.Resources.people;
            this.btPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPeople.Location = new System.Drawing.Point(3, 65);
            this.btPeople.Name = "btPeople";
            this.btPeople.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btPeople.Size = new System.Drawing.Size(201, 56);
            this.btPeople.TabIndex = 1;
            this.btPeople.Text = "People";
            this.btPeople.UseVisualStyleBackColor = false;
            this.btPeople.Click += new System.EventHandler(this.btPeople_Click);
            // 
            // btDrivers
            // 
            this.btDrivers.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btDrivers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDrivers.BorderRadius = 10;
            this.btDrivers.BorderSize = 0;
            this.btDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btDrivers.FlatAppearance.BorderSize = 0;
            this.btDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDrivers.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btDrivers.ForeColor = System.Drawing.Color.White;
            this.btDrivers.Image = global::DVLD_Project.Properties.Resources.driver;
            this.btDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDrivers.Location = new System.Drawing.Point(3, 127);
            this.btDrivers.Name = "btDrivers";
            this.btDrivers.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btDrivers.Size = new System.Drawing.Size(201, 56);
            this.btDrivers.TabIndex = 2;
            this.btDrivers.Text = "Drivers";
            this.btDrivers.UseVisualStyleBackColor = false;
            this.btDrivers.Click += new System.EventHandler(this.btDrivers_Click);
            // 
            // btUsers
            // 
            this.btUsers.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btUsers.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btUsers.BorderRadius = 10;
            this.btUsers.BorderSize = 0;
            this.btUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btUsers.FlatAppearance.BorderSize = 0;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btUsers.ForeColor = System.Drawing.Color.White;
            this.btUsers.Image = global::DVLD_Project.Properties.Resources.Users;
            this.btUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsers.Location = new System.Drawing.Point(3, 189);
            this.btUsers.Name = "btUsers";
            this.btUsers.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.btUsers.Size = new System.Drawing.Size(201, 56);
            this.btUsers.TabIndex = 3;
            this.btUsers.Text = "Users";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btSetting
            // 
            this.btSetting.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btSetting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSetting.BorderRadius = 10;
            this.btSetting.BorderSize = 0;
            this.btSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSetting.FlatAppearance.BorderSize = 0;
            this.btSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetting.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btSetting.ForeColor = System.Drawing.Color.White;
            this.btSetting.Image = global::DVLD_Project.Properties.Resources.Setting;
            this.btSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSetting.Location = new System.Drawing.Point(3, 251);
            this.btSetting.Name = "btSetting";
            this.btSetting.Size = new System.Drawing.Size(201, 56);
            this.btSetting.TabIndex = 4;
            this.btSetting.Text = "Acc settings";
            this.btSetting.UseVisualStyleBackColor = false;
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // btCurrentU
            // 
            this.btCurrentU.BackColor = System.Drawing.Color.Teal;
            this.btCurrentU.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btCurrentU.BorderRadius = 6;
            this.btCurrentU.BorderSize = 0;
            this.btCurrentU.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCurrentU.FlatAppearance.BorderSize = 0;
            this.btCurrentU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCurrentU.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btCurrentU.ForeColor = System.Drawing.Color.White;
            this.btCurrentU.Image = global::DVLD_Project.Properties.Resources.User_32__2;
            this.btCurrentU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCurrentU.Location = new System.Drawing.Point(25, 313);
            this.btCurrentU.Name = "btCurrentU";
            this.btCurrentU.Size = new System.Drawing.Size(179, 34);
            this.btCurrentU.TabIndex = 6;
            this.btCurrentU.Text = "Curent user";
            this.btCurrentU.UseVisualStyleBackColor = false;
            this.btCurrentU.Visible = false;
            this.btCurrentU.Click += new System.EventHandler(this.btCurrentU_Click);
            // 
            // btChangePassw
            // 
            this.btChangePassw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btChangePassw.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btChangePassw.BorderRadius = 6;
            this.btChangePassw.BorderSize = 0;
            this.btChangePassw.Dock = System.Windows.Forms.DockStyle.Right;
            this.btChangePassw.FlatAppearance.BorderSize = 0;
            this.btChangePassw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangePassw.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btChangePassw.ForeColor = System.Drawing.Color.White;
            this.btChangePassw.Image = global::DVLD_Project.Properties.Resources.Password_32;
            this.btChangePassw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChangePassw.Location = new System.Drawing.Point(44, 353);
            this.btChangePassw.Name = "btChangePassw";
            this.btChangePassw.Size = new System.Drawing.Size(160, 34);
            this.btChangePassw.TabIndex = 7;
            this.btChangePassw.Text = "change password";
            this.btChangePassw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChangePassw.UseVisualStyleBackColor = false;
            this.btChangePassw.Visible = false;
            this.btChangePassw.Click += new System.EventHandler(this.btChangePassw_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.picPersonalImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 158);
            this.panel2.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbUserName.ForeColor = System.Drawing.Color.White;
            this.lbUserName.Location = new System.Drawing.Point(0, 116);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(207, 42);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPersonalImage
            // 
            this.picPersonalImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPersonalImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picPersonalImage.BorderColor = System.Drawing.Color.Transparent;
            this.picPersonalImage.BorderColor2 = System.Drawing.Color.Transparent;
            this.picPersonalImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picPersonalImage.BorderSize = 1;
            this.picPersonalImage.GradientAngle = 50F;
            this.picPersonalImage.Image = global::DVLD_Project.Properties.Resources.man;
            this.picPersonalImage.Location = new System.Drawing.Point(50, 10);
            this.picPersonalImage.Name = "picPersonalImage";
            this.picPersonalImage.Size = new System.Drawing.Size(107, 107);
            this.picPersonalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonalImage.TabIndex = 0;
            this.picPersonalImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Silver;
            this.pnHeader.Controls.Add(this.btMaxmiz);
            this.pnHeader.Controls.Add(this.btClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(207, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1217, 53);
            this.pnHeader.TabIndex = 1;
            // 
            // btMaxmiz
            // 
            this.btMaxmiz.AccessibleRole = null;
            this.btMaxmiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaxmiz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btMaxmiz.BackColor = System.Drawing.Color.Transparent;
            this.btMaxmiz.BackgroundImage = global::DVLD_Project.Properties.Resources.maximize;
            this.btMaxmiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btMaxmiz.BorderColor_1 = System.Drawing.Color.Transparent;
            this.btMaxmiz.BorderColor_2 = System.Drawing.Color.Transparent;
            this.btMaxmiz.BorderRadius = 15;
            this.btMaxmiz.BorderSize = 3;
            this.btMaxmiz.CausesValidation = false;
            this.btMaxmiz.ColorFill_1 = System.Drawing.Color.Transparent;
            this.btMaxmiz.ColorFill_2 = System.Drawing.Color.Transparent;
            this.btMaxmiz.DialogResult = false;
            this.btMaxmiz.FlatAppearance.BorderSize = 0;
            this.btMaxmiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaxmiz.Font = new System.Drawing.Font("Yu Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaxmiz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btMaxmiz.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btMaxmiz.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btMaxmiz.Location = new System.Drawing.Point(1111, 12);
            this.btMaxmiz.Name = "btMaxmiz";
            this.btMaxmiz.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnClick_FillColor_1 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnClick_FillColor_2 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnOver_FillColor_1 = System.Drawing.Color.Transparent;
            this.btMaxmiz.OnOver_FillColor_2 = System.Drawing.Color.Transparent;
            this.btMaxmiz.Size = new System.Drawing.Size(42, 33);
            this.btMaxmiz.TabIndex = 0;
            this.btMaxmiz.TabStop = false;
            this.btMaxmiz.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.btMaxmiz.UseMnemonic = false;
            this.btMaxmiz.UseVisualStyleBackColor = false;
            this.btMaxmiz.Click += new System.EventHandler(this.btMaxmiz_Click);
            // 
            // btClose
            // 
            this.btClose.AccessibleRole = null;
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BackgroundImage = global::DVLD_Project.Properties.Resources.cross;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClose.BorderColor_1 = System.Drawing.Color.Transparent;
            this.btClose.BorderColor_2 = System.Drawing.Color.Transparent;
            this.btClose.BorderRadius = 20;
            this.btClose.BorderSize = 3;
            this.btClose.CausesValidation = false;
            this.btClose.ColorFill_1 = System.Drawing.Color.Transparent;
            this.btClose.ColorFill_2 = System.Drawing.Color.Transparent;
            this.btClose.DialogResult = false;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Yu Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btClose.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btClose.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btClose.Location = new System.Drawing.Point(1165, 5);
            this.btClose.Name = "btClose";
            this.btClose.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.btClose.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.btClose.OnClick_FillColor_1 = System.Drawing.Color.Red;
            this.btClose.OnClick_FillColor_2 = System.Drawing.Color.Transparent;
            this.btClose.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.btClose.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.btClose.OnOver_FillColor_1 = System.Drawing.Color.Transparent;
            this.btClose.OnOver_FillColor_2 = System.Drawing.Color.Transparent;
            this.btClose.Size = new System.Drawing.Size(42, 40);
            this.btClose.TabIndex = 0;
            this.btClose.TabStop = false;
            this.btClose.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.btClose.UseMnemonic = false;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.codeeloButton1_Click);
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 20;
            this.sEllipse1.TargetControl = this;
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.Black;
            this.pnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShow.Controls.Add(this.pictureBox1);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnShow.Location = new System.Drawing.Point(207, 53);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(1217, 836);
            this.pnShow.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.DVLD_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(571, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainScrean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1424, 889);
            this.Controls.Add(this.pnShow);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnMenue);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScrean";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScrean_Load);
            this.pnMenue.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonalImage)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.pnShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenue;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnShow;
        private CodeeloUI.Controls.CodeeloButton btClose;
        private CodeeloUI.Controls.CodeeloButton btMaxmiz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbUserName;
        private SATAUiFramework.Controls.SATAPictureBox picPersonalImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Sipaa.Framework.SButton btApplications;
        private Sipaa.Framework.SButton btPeople;
        private Sipaa.Framework.SButton btDrivers;
        private Sipaa.Framework.SButton btUsers;
        private Sipaa.Framework.SButton btSetting;
        private Sipaa.Framework.SEllipse sEllipse1;
        private Sipaa.Framework.SButton btLogOut;
        private Sipaa.Framework.SButton btCurrentU;
        private Sipaa.Framework.SButton btChangePassw;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

