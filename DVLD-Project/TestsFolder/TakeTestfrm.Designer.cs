namespace DVLD_Project.Resources
{
    partial class TakeTestfrm
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
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.lbRetake = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btClose = new Sipaa.Framework.SButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTestID = new System.Windows.Forms.Label();
            this.btnSave = new Sipaa.Framework.SButton();
            this.codeeloSeparator1 = new CodeeloUI.Controls.CodeeloSeparator();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTrial = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDrivingClass = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseAppID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pbTestTypeImage = new System.Windows.Forms.PictureBox();
            this.txNotes = new Sipaa.Framework.STextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPass = new CodeeloUI.Controls.CodeeloRadioButton();
            this.rbFail = new CodeeloUI.Controls.CodeeloRadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
            this.sEllipse1.TargetControl = this;
            // 
            // lbRetake
            // 
            this.lbRetake.AutoSize = true;
            this.lbRetake.BackColor = System.Drawing.Color.Transparent;
            this.lbRetake.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetake.Location = new System.Drawing.Point(19, 386);
            this.lbRetake.Name = "lbRetake";
            this.lbRetake.Size = new System.Drawing.Size(83, 24);
            this.lbRetake.TabIndex = 65;
            this.lbRetake.Text = "Result  :";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(124, 110);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(233, 37);
            this.lbTitle.TabIndex = 62;
            this.lbTitle.Text = "Schedule Test";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Maroon;
            this.btClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btClose.BorderRadius = 10;
            this.btClose.BorderSize = 0;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.White;
            this.btClose.Location = new System.Drawing.Point(431, 11);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(37, 34);
            this.btClose.TabIndex = 60;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Test ID  :";
            // 
            // lbTestID
            // 
            this.lbTestID.AutoSize = true;
            this.lbTestID.BackColor = System.Drawing.Color.Transparent;
            this.lbTestID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTestID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTestID.Location = new System.Drawing.Point(110, 560);
            this.lbTestID.Name = "lbTestID";
            this.lbTestID.Size = new System.Drawing.Size(21, 24);
            this.lbTestID.TabIndex = 58;
            this.lbTestID.Text = "?";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = global::DVLD_Project.Properties.Resources.sa;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 6;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(432, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 29);
            this.btnSave.TabIndex = 57;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // codeeloSeparator1
            // 
            this.codeeloSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloSeparator1.ForeColor = System.Drawing.Color.Green;
            this.codeeloSeparator1.IsVertical = false;
            this.codeeloSeparator1.LineColor = System.Drawing.Color.Lime;
            this.codeeloSeparator1.Location = new System.Drawing.Point(12, 366);
            this.codeeloSeparator1.Name = "codeeloSeparator1";
            this.codeeloSeparator1.Size = new System.Drawing.Size(456, 17);
            this.codeeloSeparator1.TabIndex = 56;
            this.codeeloSeparator1.Text = "codeeloSeparator1";
            this.codeeloSeparator1.Thickness = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Blue;
            this.lblFullName.Location = new System.Drawing.Point(99, 229);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(32, 24);
            this.lblFullName.TabIndex = 53;
            this.lblFullName.Text = "??";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(19, 229);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 24);
            this.label24.TabIndex = 54;
            this.label24.Text = "Name :";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Blue;
            this.lblFees.Location = new System.Drawing.Point(99, 293);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(32, 24);
            this.lblFees.TabIndex = 50;
            this.lblFees.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Date :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 24);
            this.label18.TabIndex = 51;
            this.label18.Text = "Fees :";
            // 
            // lblTrial
            // 
            this.lblTrial.AutoSize = true;
            this.lblTrial.BackColor = System.Drawing.Color.Transparent;
            this.lblTrial.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrial.ForeColor = System.Drawing.Color.Maroon;
            this.lblTrial.Location = new System.Drawing.Point(99, 261);
            this.lblTrial.Name = "lblTrial";
            this.lblTrial.Size = new System.Drawing.Size(32, 24);
            this.lblTrial.TabIndex = 44;
            this.lblTrial.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Trail :";
            // 
            // lblDrivingClass
            // 
            this.lblDrivingClass.AutoSize = true;
            this.lblDrivingClass.BackColor = System.Drawing.Color.Transparent;
            this.lblDrivingClass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingClass.ForeColor = System.Drawing.Color.Maroon;
            this.lblDrivingClass.Location = new System.Drawing.Point(99, 197);
            this.lblDrivingClass.Name = "lblDrivingClass";
            this.lblDrivingClass.Size = new System.Drawing.Size(32, 24);
            this.lblDrivingClass.TabIndex = 46;
            this.lblDrivingClass.Text = "??";
            // 
            // lblLocalDrivingLicenseAppID
            // 
            this.lblLocalDrivingLicenseAppID.AutoSize = true;
            this.lblLocalDrivingLicenseAppID.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalDrivingLicenseAppID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicenseAppID.ForeColor = System.Drawing.Color.Blue;
            this.lblLocalDrivingLicenseAppID.Location = new System.Drawing.Point(99, 165);
            this.lblLocalDrivingLicenseAppID.Name = "lblLocalDrivingLicenseAppID";
            this.lblLocalDrivingLicenseAppID.Size = new System.Drawing.Size(32, 24);
            this.lblLocalDrivingLicenseAppID.TabIndex = 47;
            this.lblLocalDrivingLicenseAppID.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 24);
            this.label11.TabIndex = 48;
            this.label11.Text = "Class :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "App ID :";
            // 
            // pbTestTypeImage
            // 
            this.pbTestTypeImage.BackgroundImage = global::DVLD_Project.Properties.Resources.Vision_512;
            this.pbTestTypeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTestTypeImage.Location = new System.Drawing.Point(164, 22);
            this.pbTestTypeImage.Name = "pbTestTypeImage";
            this.pbTestTypeImage.Size = new System.Drawing.Size(152, 77);
            this.pbTestTypeImage.TabIndex = 43;
            this.pbTestTypeImage.TabStop = false;
            // 
            // txNotes
            // 
            this.txNotes.AllowDrop = true;
            this.txNotes.AutoScroll = true;
            this.txNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txNotes.BorderColor = System.Drawing.Color.Navy;
            this.txNotes.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txNotes.BorderRadius = 15;
            this.txNotes.BorderSize = 2;
            this.txNotes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txNotes.Location = new System.Drawing.Point(103, 433);
            this.txNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txNotes.Multiline = true;
            this.txNotes.Name = "txNotes";
            this.txNotes.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txNotes.PasswordChar = false;
            this.txNotes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txNotes.PlaceholderText = "";
            this.txNotes.Size = new System.Drawing.Size(364, 123);
            this.txNotes.TabIndex = 66;
            this.txNotes.Texts = "";
            this.txNotes.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 65;
            this.label2.Text = "Notes :";
            // 
            // rbPass
            // 
            this.rbPass.BackColor = System.Drawing.Color.Transparent;
            this.rbPass.ButtonAreaSize = 18F;
            this.rbPass.ButtonBorderSize = 1.6F;
            this.rbPass.ButtonColor = System.Drawing.Color.Black;
            this.rbPass.ButtonColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbPass.ButtonToggleSize = 12F;
            this.rbPass.DrawCircleButton = true;
            this.rbPass.DrawCircleToggle = true;
            this.rbPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPass.Location = new System.Drawing.Point(114, 389);
            this.rbPass.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbPass.Name = "rbPass";
            this.rbPass.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbPass.Size = new System.Drawing.Size(104, 24);
            this.rbPass.TabIndex = 67;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UseVisualStyleBackColor = false;
            // 
            // rbFail
            // 
            this.rbFail.BackColor = System.Drawing.Color.Transparent;
            this.rbFail.ButtonAreaSize = 18F;
            this.rbFail.ButtonBorderSize = 1.6F;
            this.rbFail.ButtonColor = System.Drawing.Color.Black;
            this.rbFail.ButtonColorChecked = System.Drawing.Color.Red;
            this.rbFail.ButtonToggleSize = 12F;
            this.rbFail.DrawCircleButton = true;
            this.rbFail.DrawCircleToggle = true;
            this.rbFail.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFail.Location = new System.Drawing.Point(224, 386);
            this.rbFail.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbFail.Name = "rbFail";
            this.rbFail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbFail.Size = new System.Drawing.Size(104, 24);
            this.rbFail.TabIndex = 68;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(99, 325);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(32, 24);
            this.lblDate.TabIndex = 65;
            this.lblDate.Text = "??";
            // 
            // TakeTestfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 617);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.rbFail);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.txNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbRetake);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTestID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.codeeloSeparator1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTrial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDrivingClass);
            this.Controls.Add(this.lblLocalDrivingLicenseAppID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbTestTypeImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakeTestfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeTestfrm";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbTestTypeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipse1;
        private System.Windows.Forms.Label lbRetake;
        private System.Windows.Forms.Label lbTitle;
        private Sipaa.Framework.SButton btClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTestID;
        private Sipaa.Framework.SButton btnSave;
        private CodeeloUI.Controls.CodeeloSeparator codeeloSeparator1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTrial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDrivingClass;
        private System.Windows.Forms.Label lblLocalDrivingLicenseAppID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private CodeeloUI.Controls.CodeeloRadioButton rbFail;
        private CodeeloUI.Controls.CodeeloRadioButton rbPass;
        private Sipaa.Framework.STextBox txNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
    }
}