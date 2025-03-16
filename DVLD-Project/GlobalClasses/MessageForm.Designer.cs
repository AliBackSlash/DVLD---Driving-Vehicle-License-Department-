namespace DVLD_Project.Resources
{
    partial class MessageForm
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btOK = new Sipaa.Framework.SButton();
            this.lbMessage = new System.Windows.Forms.Label();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.picImage = new SATAUiFramework.Controls.SATAPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btOK.BorderRadius = 6;
            this.btOK.BorderSize = 0;
            this.btOK.FlatAppearance.BorderSize = 0;
            this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(359, 125);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(88, 28);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AllowDrop = true;
            this.lbMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(84, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(375, 165);
            this.lbMessage.TabIndex = 2;
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 20;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picImage.BorderColor = System.Drawing.Color.Transparent;
            this.picImage.BorderColor2 = System.Drawing.Color.Transparent;
            this.picImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picImage.BorderSize = 1;
            this.picImage.GradientAngle = 50F;
            this.picImage.Location = new System.Drawing.Point(8, 49);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(66, 66);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(459, 165);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        public SATAUiFramework.Controls.SATAPictureBox picImage;
        public Sipaa.Framework.SButton btOK;
        public System.Windows.Forms.Label lbMessage;
    }
}