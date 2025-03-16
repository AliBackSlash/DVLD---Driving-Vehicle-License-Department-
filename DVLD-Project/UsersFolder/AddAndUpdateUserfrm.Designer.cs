namespace DVLD_Project.Resources
{
    partial class AddAndUpdateUserfrm
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
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.pnUserExtension = new SATAUiFramework.SATAPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckIsActive = new CodeeloUI.Controls.CodeeloCheckBox();
            this.txConfirmPassword = new Sipaa.Framework.STextBox();
            this.txPassword = new Sipaa.Framework.STextBox();
            this.txUserName = new Sipaa.Framework.STextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new Sipaa.Framework.SButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btClose = new Sipaa.Framework.SButton();
            this.showPersonInfoWithFelter1 = new DVLD_Project.People1.Control.ShowPersonInfoWithFelter();
            this.pnUserExtension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
            this.sEllipse1.TargetControl = this;
            // 
            // pnUserExtension
            // 
            this.pnUserExtension.BackColor = System.Drawing.Color.White;
            this.pnUserExtension.BackColor2 = System.Drawing.Color.White;
            this.pnUserExtension.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.pnUserExtension.BorderRadius = borderRadius1;
            this.pnUserExtension.BorderThickness = 0;
            this.pnUserExtension.Controls.Add(this.label4);
            this.pnUserExtension.Controls.Add(this.label3);
            this.pnUserExtension.Controls.Add(this.label1);
            this.pnUserExtension.Controls.Add(this.btSave);
            this.pnUserExtension.Controls.Add(this.ckIsActive);
            this.pnUserExtension.Controls.Add(this.txConfirmPassword);
            this.pnUserExtension.Controls.Add(this.txPassword);
            this.pnUserExtension.Controls.Add(this.txUserName);
            this.pnUserExtension.Controls.Add(this.lbID);
            this.pnUserExtension.Controls.Add(this.label2);
            this.pnUserExtension.Location = new System.Drawing.Point(38, 523);
            this.pnUserExtension.Name = "pnUserExtension";
            this.pnUserExtension.Size = new System.Drawing.Size(967, 192);
            this.pnUserExtension.TabIndex = 2;
            this.pnUserExtension.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Conf-Password :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckIsActive
            // 
            this.ckIsActive.ButtonBorderSize = 1.6F;
            this.ckIsActive.ButtonCircleSize = 18F;
            this.ckIsActive.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ckIsActive.ButtonColorChecked = System.Drawing.Color.Green;
            this.ckIsActive.Checked = true;
            this.ckIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckIsActive.DrawCircleButton = false;
            this.ckIsActive.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.ckIsActive.Location = new System.Drawing.Point(550, 101);
            this.ckIsActive.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ckIsActive.MarkType = CodeeloUI.Enums.CheckBoxMark.Mark;
            this.ckIsActive.MarkWidth = 3;
            this.ckIsActive.Name = "ckIsActive";
            this.ckIsActive.Size = new System.Drawing.Size(104, 24);
            this.ckIsActive.TabIndex = 9;
            this.ckIsActive.Text = "Is Active ?";
            this.ckIsActive.UseVisualStyleBackColor = true;
            // 
            // txConfirmPassword
            // 
            this.txConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.txConfirmPassword.BorderFocusColor = System.Drawing.Color.Green;
            this.txConfirmPassword.BorderRadius = 10;
            this.txConfirmPassword.BorderSize = 2;
            this.txConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txConfirmPassword.Location = new System.Drawing.Point(206, 141);
            this.txConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txConfirmPassword.Multiline = false;
            this.txConfirmPassword.Name = "txConfirmPassword";
            this.txConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txConfirmPassword.PasswordChar = true;
            this.txConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txConfirmPassword.PlaceholderText = "";
            this.txConfirmPassword.Size = new System.Drawing.Size(250, 40);
            this.txConfirmPassword.TabIndex = 8;
            this.txConfirmPassword.Texts = "";
            this.txConfirmPassword.UnderlinedStyle = false;
            this.txConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txPassword
            // 
            this.txPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txPassword.BorderColor = System.Drawing.Color.Black;
            this.txPassword.BorderFocusColor = System.Drawing.Color.Green;
            this.txPassword.BorderRadius = 10;
            this.txPassword.BorderSize = 2;
            this.txPassword.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txPassword.Location = new System.Drawing.Point(206, 93);
            this.txPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txPassword.Multiline = false;
            this.txPassword.Name = "txPassword";
            this.txPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txPassword.PasswordChar = true;
            this.txPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txPassword.PlaceholderText = "";
            this.txPassword.Size = new System.Drawing.Size(250, 40);
            this.txPassword.TabIndex = 7;
            this.txPassword.Texts = "";
            this.txPassword.UnderlinedStyle = false;
            this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txUserName
            // 
            this.txUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txUserName.BorderColor = System.Drawing.Color.Black;
            this.txUserName.BorderFocusColor = System.Drawing.Color.Green;
            this.txUserName.BorderRadius = 10;
            this.txUserName.BorderSize = 2;
            this.txUserName.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUserName.Location = new System.Drawing.Point(206, 45);
            this.txUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txUserName.Multiline = false;
            this.txUserName.Name = "txUserName";
            this.txUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txUserName.PasswordChar = false;
            this.txUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txUserName.PlaceholderText = "";
            this.txUserName.Size = new System.Drawing.Size(250, 40);
            this.txUserName.TabIndex = 6;
            this.txUserName.Texts = "";
            this.txUserName.UnderlinedStyle = false;
            this.txUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoEllipsis = true;
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(201, 12);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(22, 25);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "?";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.BackColor = System.Drawing.Color.Transparent;
            this.btSave.BackgroundImage = global::DVLD_Project.Properties.Resources.sa;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSave.BorderRadius = 6;
            this.btSave.BorderSize = 0;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(916, 152);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(39, 29);
            this.btSave.TabIndex = 10;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(422, 30);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(192, 36);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "Add new user";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btClose.Location = new System.Drawing.Point(997, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(37, 34);
            this.btClose.TabIndex = 43;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // showPersonInfoWithFelter1
            // 
            this.showPersonInfoWithFelter1.EnabelFind = true;
            this.showPersonInfoWithFelter1.Location = new System.Drawing.Point(17, 82);
            this.showPersonInfoWithFelter1.Name = "showPersonInfoWithFelter1";
            this.showPersonInfoWithFelter1.ShowAddPerson = true;
            this.showPersonInfoWithFelter1.Size = new System.Drawing.Size(1003, 446);
            this.showPersonInfoWithFelter1.TabIndex = 23;
            this.showPersonInfoWithFelter1.OnPersonSelectedAndFound += new System.Action<int>(this.showPersonInfoWithFelter1_OnPersonSelected);
            // 
            // AddAndUpdateUserfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 757);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.showPersonInfoWithFelter1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnUserExtension);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAndUpdateUserfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUserfrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.pnUserExtension.ResumeLayout(false);
            this.pnUserExtension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipse1;
        private SATAUiFramework.SATAPanel pnUserExtension;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label2;
        private CodeeloUI.Controls.CodeeloCheckBox ckIsActive;
        private Sipaa.Framework.STextBox txConfirmPassword;
        private Sipaa.Framework.STextBox txPassword;
        private Sipaa.Framework.STextBox txUserName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private People1.Control.ShowPersonInfoWithFelter showPersonInfoWithFelter1;
        private Sipaa.Framework.SButton btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Sipaa.Framework.SButton btSave;
    }
}