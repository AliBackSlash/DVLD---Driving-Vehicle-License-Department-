namespace DVLD_Project.PeopleFolder
{
    partial class FindPerson
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
            this.sButton1 = new Sipaa.Framework.SButton();
            this.showPersonInfoWithFelter1 = new DVLD_Project.People1.Control.ShowPersonInfoWithFelter();
            this.SuspendLayout();
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 30;
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
            this.sButton1.Location = new System.Drawing.Point(978, 12);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(37, 34);
            this.sButton1.TabIndex = 9;
            this.sButton1.Text = "X";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // showPersonInfoWithFelter1
            // 
            this.showPersonInfoWithFelter1.EnabelFind = true;
            this.showPersonInfoWithFelter1.Location = new System.Drawing.Point(12, 27);
            this.showPersonInfoWithFelter1.Name = "showPersonInfoWithFelter1";
            this.showPersonInfoWithFelter1.ShowAddPerson = true;
            this.showPersonInfoWithFelter1.Size = new System.Drawing.Size(1013, 483);
            this.showPersonInfoWithFelter1.TabIndex = 0;
            // 
            // FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 515);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.showPersonInfoWithFelter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindPerson";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private People1.Control.ShowPersonInfoWithFelter showPersonInfoWithFelter1;
        private Sipaa.Framework.SEllipse sEllipse1;
        private Sipaa.Framework.SButton sButton1;
    }
}