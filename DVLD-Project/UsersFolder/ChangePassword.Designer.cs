namespace DVLD_Project.Resources
{
    partial class ChangePassword
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
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.sataPanel3 = new SATAUiFramework.SATAPanel();
            this.btAdd = new Sipaa.Framework.SButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txConfirmPassword = new Sipaa.Framework.STextBox();
            this.txPassword = new Sipaa.Framework.STextBox();
            this.txCurrentPassword = new Sipaa.Framework.STextBox();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.showUserDetails1 = new DVLD_Project.Resources.ShowUserDetails();
            this.btClose = new Sipaa.Framework.SButton();
            this.sataPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // sataPanel3
            // 
            this.sataPanel3.BackColor = System.Drawing.Color.White;
            this.sataPanel3.BackColor2 = System.Drawing.Color.White;
            this.sataPanel3.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel3.BorderRadius = borderRadius2;
            this.sataPanel3.BorderThickness = 0;
            this.sataPanel3.Controls.Add(this.btAdd);
            this.sataPanel3.Controls.Add(this.label8);
            this.sataPanel3.Controls.Add(this.label7);
            this.sataPanel3.Controls.Add(this.label1);
            this.sataPanel3.Controls.Add(this.txConfirmPassword);
            this.sataPanel3.Controls.Add(this.txPassword);
            this.sataPanel3.Controls.Add(this.txCurrentPassword);
            this.sataPanel3.Location = new System.Drawing.Point(12, 495);
            this.sataPanel3.Name = "sataPanel3";
            this.sataPanel3.Size = new System.Drawing.Size(969, 193);
            this.sataPanel3.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BackgroundImage = global::DVLD_Project.Properties.Resources.sa;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAdd.BorderRadius = 6;
            this.btAdd.BorderSize = 0;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(922, 157);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(39, 29);
            this.btAdd.TabIndex = 15;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Confirm Password :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "New Password :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Current Password :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txConfirmPassword.Location = new System.Drawing.Point(245, 132);
            this.txConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txConfirmPassword.Multiline = false;
            this.txConfirmPassword.Name = "txConfirmPassword";
            this.txConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txConfirmPassword.PasswordChar = true;
            this.txConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txConfirmPassword.PlaceholderText = "Confirm Password....";
            this.txConfirmPassword.Size = new System.Drawing.Size(250, 40);
            this.txConfirmPassword.TabIndex = 11;
            this.txConfirmPassword.Texts = "";
            this.txConfirmPassword.UnderlinedStyle = false;
            this.txConfirmPassword.Validated += new System.EventHandler(this.txConfirmPassword_Validated);
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
            this.txPassword.Location = new System.Drawing.Point(245, 80);
            this.txPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txPassword.Multiline = false;
            this.txPassword.Name = "txPassword";
            this.txPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txPassword.PasswordChar = true;
            this.txPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txPassword.PlaceholderText = "Password....";
            this.txPassword.Size = new System.Drawing.Size(250, 40);
            this.txPassword.TabIndex = 10;
            this.txPassword.Texts = "";
            this.txPassword.UnderlinedStyle = false;
            // 
            // txCurrentPassword
            // 
            this.txCurrentPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txCurrentPassword.BorderColor = System.Drawing.Color.Black;
            this.txCurrentPassword.BorderFocusColor = System.Drawing.Color.Green;
            this.txCurrentPassword.BorderRadius = 10;
            this.txCurrentPassword.BorderSize = 2;
            this.txCurrentPassword.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txCurrentPassword.Location = new System.Drawing.Point(245, 28);
            this.txCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txCurrentPassword.Multiline = false;
            this.txCurrentPassword.Name = "txCurrentPassword";
            this.txCurrentPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txCurrentPassword.PasswordChar = true;
            this.txCurrentPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txCurrentPassword.PlaceholderText = "Current Password....";
            this.txCurrentPassword.Size = new System.Drawing.Size(250, 40);
            this.txCurrentPassword.TabIndex = 9;
            this.txCurrentPassword.Texts = "";
            this.txCurrentPassword.UnderlinedStyle = false;
            this.txCurrentPassword.Validated += new System.EventHandler(this.CurrentPassword_Validated);
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
            this.sEllipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // showUserDetails1
            // 
            this.showUserDetails1.Location = new System.Drawing.Point(12, 73);
            this.showUserDetails1.Name = "showUserDetails1";
            this.showUserDetails1.Size = new System.Drawing.Size(969, 416);
            this.showUserDetails1.TabIndex = 3;
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
            this.btClose.Location = new System.Drawing.Point(953, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(37, 34);
            this.btClose.TabIndex = 45;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.showUserDetails1);
            this.Controls.Add(this.sataPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.sataPanel3.ResumeLayout(false);
            this.sataPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SATAUiFramework.SATAPanel sataPanel3;
        private Sipaa.Framework.SEllipse sEllipse1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Sipaa.Framework.STextBox txConfirmPassword;
        private Sipaa.Framework.STextBox txPassword;
        private Sipaa.Framework.STextBox txCurrentPassword;
        private Sipaa.Framework.SButton btAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Diagnostics.EventLog eventLog1;
        private ShowUserDetails showUserDetails1;
        private Sipaa.Framework.SButton btClose;
    }
}