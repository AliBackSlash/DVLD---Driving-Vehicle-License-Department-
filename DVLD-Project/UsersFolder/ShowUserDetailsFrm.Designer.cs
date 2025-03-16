namespace DVLD_Project.Resources
{
    partial class ShowUserDetailsFrm
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
            this.showUserDetails1 = new DVLD_Project.Resources.ShowUserDetails();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.btClose = new Sipaa.Framework.SButton();
            this.SuspendLayout();
            // 
            // showUserDetails1
            // 
            this.showUserDetails1.Location = new System.Drawing.Point(12, 68);
            this.showUserDetails1.Name = "showUserDetails1";
            this.showUserDetails1.Size = new System.Drawing.Size(966, 405);
            this.showUserDetails1.TabIndex = 0;
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
            this.sEllipse1.TargetControl = this;
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
            this.btClose.Location = new System.Drawing.Point(944, 12);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(37, 34);
            this.btClose.TabIndex = 44;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ShowUserDetailsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 493);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.showUserDetails1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowUserDetailsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowUserDetailsFrm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private ShowUserDetails showUserDetails1;
        private Sipaa.Framework.SEllipse sEllipse1;
        private Sipaa.Framework.SButton btClose;
    }
}