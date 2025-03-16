namespace DVLD_Project.Resources
{
    partial class UpdateAppTypes
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
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.btSave = new Sipaa.Framework.SButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txFees = new Sipaa.Framework.STextBox();
            this.txAppTitle = new Sipaa.Framework.STextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
            this.sEllipse1.TargetControl = this;
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
            this.btSave.Location = new System.Drawing.Point(543, 277);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(39, 29);
            this.btSave.TabIndex = 21;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fees :";
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
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "App Title :";
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
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txFees
            // 
            this.txFees.BackColor = System.Drawing.SystemColors.Window;
            this.txFees.BorderColor = System.Drawing.Color.Black;
            this.txFees.BorderFocusColor = System.Drawing.Color.Green;
            this.txFees.BorderRadius = 10;
            this.txFees.BorderSize = 2;
            this.txFees.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txFees.Location = new System.Drawing.Point(159, 217);
            this.txFees.Margin = new System.Windows.Forms.Padding(4);
            this.txFees.Multiline = false;
            this.txFees.Name = "txFees";
            this.txFees.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txFees.PasswordChar = false;
            this.txFees.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txFees.PlaceholderText = "";
            this.txFees.Size = new System.Drawing.Size(217, 40);
            this.txFees.TabIndex = 17;
            this.txFees.Texts = "";
            this.txFees.UnderlinedStyle = false;
            this.txFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // txAppTitle
            // 
            this.txAppTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txAppTitle.BorderColor = System.Drawing.Color.Black;
            this.txAppTitle.BorderFocusColor = System.Drawing.Color.Green;
            this.txAppTitle.BorderRadius = 10;
            this.txAppTitle.BorderSize = 2;
            this.txAppTitle.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txAppTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txAppTitle.Location = new System.Drawing.Point(159, 169);
            this.txAppTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txAppTitle.Multiline = false;
            this.txAppTitle.Name = "txAppTitle";
            this.txAppTitle.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txAppTitle.PasswordChar = false;
            this.txAppTitle.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txAppTitle.PlaceholderText = "";
            this.txAppTitle.Size = new System.Drawing.Size(423, 40);
            this.txAppTitle.TabIndex = 16;
            this.txAppTitle.Texts = "";
            this.txAppTitle.UnderlinedStyle = false;
            this.txAppTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoEllipsis = true;
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(66, 126);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 25);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "?";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.Maroon;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 10;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(543, 12);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(37, 34);
            this.sButton1.TabIndex = 22;
            this.sButton1.Text = "X";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoEllipsis = true;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(100, 49);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(394, 41);
            this.lbTitle.TabIndex = 23;
            this.lbTitle.Text = "Update Application Types";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateAppTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 318);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txFees);
            this.Controls.Add(this.txAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateAppTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAppTypes";
            this.Load += new System.EventHandler(this.UpdateAppTypes_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SEllipse sEllipse1;
        private Sipaa.Framework.SButton btSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label1;
        private Sipaa.Framework.STextBox txFees;
        private Sipaa.Framework.STextBox txAppTitle;
        private Sipaa.Framework.SButton sButton1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}