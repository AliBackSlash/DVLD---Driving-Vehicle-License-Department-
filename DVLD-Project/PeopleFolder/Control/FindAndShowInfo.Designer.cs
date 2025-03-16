namespace DVLD_Project.Resources
{
    partial class FindAndShowInfo
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
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.pnShow = new SATAUiFramework.SATAPanel();
            this.showDetails = new DVLD_Project.Resources.ShowPersonDetails();
            this.pnFind = new SATAUiFramework.SATAPanel();
            this.cmFindBy = new System.Windows.Forms.ComboBox();
            this.txInput = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new Sipaa.Framework.SButton();
            this.btFind = new Sipaa.Framework.SButton();
            this.pnShow.SuspendLayout();
            this.pnFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.White;
            this.pnShow.BackColor2 = System.Drawing.Color.White;
            this.pnShow.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.pnShow.BorderRadius = borderRadius1;
            this.pnShow.BorderThickness = 0;
            this.pnShow.Controls.Add(this.showDetails);
            this.pnShow.Location = new System.Drawing.Point(3, 97);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(1005, 365);
            this.pnShow.TabIndex = 5;
            // 
            // showDetails
            // 
            this.showDetails.BackColor = System.Drawing.Color.White;
            this.showDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDetails.Location = new System.Drawing.Point(0, 0);
            this.showDetails.Name = "showDetails";
            this.showDetails.Size = new System.Drawing.Size(1005, 365);
            this.showDetails.TabIndex = 0;
            // 
            // pnFind
            // 
            this.pnFind.BackColor = System.Drawing.Color.White;
            this.pnFind.BackColor2 = System.Drawing.Color.White;
            this.pnFind.BorderColor = System.Drawing.Color.White;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.pnFind.BorderRadius = borderRadius2;
            this.pnFind.BorderThickness = 0;
            this.pnFind.Controls.Add(this.cmFindBy);
            this.pnFind.Controls.Add(this.txInput);
            this.pnFind.Controls.Add(this.label1);
            this.pnFind.Controls.Add(this.btAdd);
            this.pnFind.Controls.Add(this.btFind);
            this.pnFind.Location = new System.Drawing.Point(134, 3);
            this.pnFind.Name = "pnFind";
            this.pnFind.Size = new System.Drawing.Size(748, 88);
            this.pnFind.TabIndex = 6;
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
            // FindAndShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnFind);
            this.Controls.Add(this.pnShow);
            this.Name = "FindAndShowInfo";
            this.Size = new System.Drawing.Size(1011, 466);
            this.Load += new System.EventHandler(this.FindAndShowInfo_Load);
            this.pnShow.ResumeLayout(false);
            this.pnFind.ResumeLayout(false);
            this.pnFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public ShowPersonDetails showDetails;
        public SATAUiFramework.SATAPanel pnShow;
        public SATAUiFramework.SATAPanel pnFind;
        public System.Windows.Forms.ComboBox cmFindBy;
        public Sipaa.Framework.STextBox txInput;
        public System.Windows.Forms.Label label1;
        public Sipaa.Framework.SButton btAdd;
        public Sipaa.Framework.SButton btFind;
    }
}
