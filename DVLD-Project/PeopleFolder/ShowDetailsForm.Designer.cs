namespace DVLD_Project.Resources
{
    partial class ShowDetailsForm
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
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            this.pnShow = new SATAUiFramework.SATAPanel();
            this.showPersonDetails1 = new DVLD_Project.Resources.ShowPersonDetails();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.pnShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor2 = System.Drawing.Color.White;
            this.pnShow.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.pnShow.BorderRadius = borderRadius1;
            this.pnShow.BorderThickness = 0;
            this.pnShow.Controls.Add(this.showPersonDetails1);
            this.pnShow.Location = new System.Drawing.Point(17, 45);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(962, 326);
            this.pnShow.TabIndex = 1;
            // 
            // showPersonDetails1
            // 
            this.showPersonDetails1.BackColor = System.Drawing.Color.White;
            this.showPersonDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.showPersonDetails1.Name = "showPersonDetails1";
            this.showPersonDetails1.Size = new System.Drawing.Size(962, 326);
            this.showPersonDetails1.TabIndex = 0;
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 20;
            this.sEllipse1.TargetControl = this;
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
            this.sButton1.Location = new System.Drawing.Point(947, 5);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(37, 34);
            this.sButton1.TabIndex = 10;
            this.sButton1.Text = "X";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // ShowDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 385);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.pnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDetailsForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.pnShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel pnShow;
        private Sipaa.Framework.SEllipse sEllipse1;
        private ShowPersonDetails showPersonDetails1;
        private Sipaa.Framework.SButton sButton1;
    }
}