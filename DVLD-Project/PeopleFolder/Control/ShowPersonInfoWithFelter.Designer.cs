namespace DVLD_Project.People1.Control
{
    partial class ShowPersonInfoWithFelter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.pnFind = new SATAUiFramework.SATAPanel();
            this.cmFindBy = new System.Windows.Forms.ComboBox();
            this.txInput = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new Sipaa.Framework.SButton();
            this.btFind = new Sipaa.Framework.SButton();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.showPersonDetails1 = new DVLD_Project.Resources.ShowPersonDetails();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnFind.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFind
            // 
            this.pnFind.BackColor = System.Drawing.Color.White;
            this.pnFind.BackColor2 = System.Drawing.Color.White;
            this.pnFind.BorderColor = System.Drawing.Color.White;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.pnFind.BorderRadius = borderRadius1;
            this.pnFind.BorderThickness = 0;
            this.pnFind.Controls.Add(this.cmFindBy);
            this.pnFind.Controls.Add(this.txInput);
            this.pnFind.Controls.Add(this.label1);
            this.pnFind.Controls.Add(this.btAdd);
            this.pnFind.Controls.Add(this.btFind);
            this.pnFind.Location = new System.Drawing.Point(127, 21);
            this.pnFind.Name = "pnFind";
            this.pnFind.Size = new System.Drawing.Size(748, 88);
            this.pnFind.TabIndex = 7;
            // 
            // cmFindBy
            // 
            this.cmFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFindBy.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.cmFindBy.FormattingEnabled = true;
            this.cmFindBy.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cmFindBy.Location = new System.Drawing.Point(98, 25);
            this.cmFindBy.Name = "cmFindBy";
            this.cmFindBy.Size = new System.Drawing.Size(263, 35);
            this.cmFindBy.TabIndex = 16;
            this.cmFindBy.SelectedIndexChanged += new System.EventHandler(this.cmFindBy_SelectedIndexChanged);
            // 
            // txInput
            // 
            this.txInput.BackColor = System.Drawing.SystemColors.Window;
            this.txInput.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txInput.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txInput.BorderRadius = 5;
            this.txInput.BorderSize = 2;
            this.txInput.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txInput.Location = new System.Drawing.Point(368, 22);
            this.txInput.Margin = new System.Windows.Forms.Padding(4);
            this.txInput.Multiline = false;
            this.txInput.Name = "txInput";
            this.txInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txInput.PasswordChar = false;
            this.txInput.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txInput.PlaceholderText = "";
            this.txInput.Size = new System.Drawing.Size(250, 40);
            this.txInput.TabIndex = 15;
            this.txInput.Texts = "";
            this.txInput.UnderlinedStyle = false;
            this.txInput._TextChanged += new System.EventHandler(this.txInput__TextChanged);
            this.txInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txInput_KeyPress);
            this.txInput.Validated += new System.EventHandler(this.txInput_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Find by";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BackgroundImage = global::DVLD_Project.Properties.Resources.add_employee;
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAdd.BorderRadius = 6;
            this.btAdd.BorderSize = 0;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(693, 26);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(43, 40);
            this.btAdd.TabIndex = 13;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.BackColor = System.Drawing.Color.Transparent;
            this.btFind.BackgroundImage = global::DVLD_Project.Properties.Resources.Searsh_;
            this.btFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btFind.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btFind.BorderRadius = 6;
            this.btFind.BorderSize = 0;
            this.btFind.FlatAppearance.BorderSize = 0;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.ForeColor = System.Drawing.Color.White;
            this.btFind.Location = new System.Drawing.Point(644, 25);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(43, 40);
            this.btFind.TabIndex = 12;
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.White;
            this.sataPanel1.BackColor2 = System.Drawing.Color.White;
            this.sataPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius2;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.showPersonDetails1);
            this.sataPanel1.Location = new System.Drawing.Point(20, 120);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(963, 311);
            this.sataPanel1.TabIndex = 8;
            // 
            // showPersonDetails1
            // 
            this.showPersonDetails1.BackColor = System.Drawing.Color.White;
            this.showPersonDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPersonDetails1.Location = new System.Drawing.Point(0, 0);
            this.showPersonDetails1.Name = "showPersonDetails1";
            this.showPersonDetails1.Size = new System.Drawing.Size(963, 311);
            this.showPersonDetails1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ShowPersonInfoWithFelter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.pnFind);
            this.Name = "ShowPersonInfoWithFelter";
            this.Size = new System.Drawing.Size(1003, 446);
            this.Load += new System.EventHandler(this.ShowPersonInfoWithFelter_Load);
            this.pnFind.ResumeLayout(false);
            this.pnFind.PerformLayout();
            this.sataPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public SATAUiFramework.SATAPanel pnFind;
        public System.Windows.Forms.ComboBox cmFindBy;
        public Sipaa.Framework.STextBox txInput;
        public System.Windows.Forms.Label label1;
        public Sipaa.Framework.SButton btAdd;
        public Sipaa.Framework.SButton btFind;
        private SATAUiFramework.SATAPanel sataPanel1;
        private Resources.ShowPersonDetails showPersonDetails1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
