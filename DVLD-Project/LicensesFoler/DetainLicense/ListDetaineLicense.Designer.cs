namespace DVLD_Project.Resources
{
    partial class ListDetaineLicense
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
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sataPanel2 = new SATAUiFramework.SATAPanel();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.cbIsReleased = new MetroFramework.Controls.MetroComboBox();
            this.cbFilterBy = new MetroFramework.Controls.MetroComboBox();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.btShowAddForm = new Sipaa.Framework.SButton();
            this.txtFilterValue = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sataPictureBox1 = new SATAUiFramework.Controls.SATAPictureBox();
            this.dgvDetainedLicenses = new MetroFramework.Controls.MetroGrid();
            this.CnRigthClick = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.itshowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.itShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ItHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.tableLayoutPanel1.SuspendLayout();
            this.sataPanel2.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.CnRigthClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sataPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sataPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDetainedLicenses, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 797);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // sataPanel2
            // 
            this.sataPanel2.BackColor = System.Drawing.Color.White;
            this.sataPanel2.BackColor2 = System.Drawing.Color.White;
            this.sataPanel2.BorderColor = System.Drawing.Color.Black;
            borderRadius1.BottomLeft = 10;
            borderRadius1.BottomRight = 10;
            borderRadius1.TopLeft = 10;
            borderRadius1.TopRight = 10;
            this.sataPanel2.BorderRadius = borderRadius1;
            this.sataPanel2.BorderThickness = 0;
            this.sataPanel2.Controls.Add(this.lblTotalRecords);
            this.sataPanel2.Controls.Add(this.label2);
            this.sataPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel2.Location = new System.Drawing.Point(3, 750);
            this.sataPanel2.Name = "sataPanel2";
            this.sataPanel2.Size = new System.Drawing.Size(1264, 44);
            this.sataPanel2.TabIndex = 3;
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoEllipsis = true;
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalRecords.Location = new System.Drawing.Point(221, 9);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(27, 29);
            this.lblTotalRecords.TabIndex = 3;
            this.lblTotalRecords.Text = "0";
            this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "#Total Records :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.White;
            this.sataPanel1.BackColor2 = System.Drawing.Color.White;
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius2;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.cbIsReleased);
            this.sataPanel1.Controls.Add(this.cbFilterBy);
            this.sataPanel1.Controls.Add(this.sButton1);
            this.sataPanel1.Controls.Add(this.btShowAddForm);
            this.sataPanel1.Controls.Add(this.txtFilterValue);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.sataPictureBox1);
            this.sataPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel1.Location = new System.Drawing.Point(3, 43);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1264, 74);
            this.sataPanel1.TabIndex = 0;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.ItemHeight = 23;
            this.cbIsReleased.Items.AddRange(new object[] {
            "Released",
            "Detained"});
            this.cbIsReleased.Location = new System.Drawing.Point(827, 26);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(101, 29);
            this.cbIsReleased.TabIndex = 7;
            this.cbIsReleased.UseSelectable = true;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.ItemHeight = 23;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "National No",
            "Name",
            "App ID",
            "Is Released"});
            this.cbFilterBy.Location = new System.Drawing.Point(787, 26);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(25, 29);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.UseSelectable = true;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmSearshBy_SelectedIndexChanged);
            this.cbFilterBy.MouseLeave += new System.EventHandler(this.cmSearshBy_MouseLeave);
            this.cbFilterBy.MouseHover += new System.EventHandler(this.cmSearshBy_MouseHover);
            // 
            // sButton1
            // 
            this.sButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sButton1.BackColor = System.Drawing.Color.Transparent;
            this.sButton1.BackgroundImage = global::DVLD_Project.Properties.Resources.Detain_32;
            this.sButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(1208, 15);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(43, 40);
            this.sButton1.TabIndex = 5;
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btShowAddForm
            // 
            this.btShowAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowAddForm.BackColor = System.Drawing.Color.Transparent;
            this.btShowAddForm.BackgroundImage = global::DVLD_Project.Properties.Resources.Release_Detained_License_64;
            this.btShowAddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btShowAddForm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowAddForm.BorderRadius = 6;
            this.btShowAddForm.BorderSize = 0;
            this.btShowAddForm.FlatAppearance.BorderSize = 0;
            this.btShowAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowAddForm.ForeColor = System.Drawing.Color.White;
            this.btShowAddForm.Location = new System.Drawing.Point(1154, 15);
            this.btShowAddForm.Name = "btShowAddForm";
            this.btShowAddForm.Size = new System.Drawing.Size(43, 40);
            this.btShowAddForm.TabIndex = 5;
            this.btShowAddForm.UseVisualStyleBackColor = false;
            this.btShowAddForm.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilterValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilterValue.BorderColor = System.Drawing.Color.DarkMagenta;
            this.txtFilterValue.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtFilterValue.BorderRadius = 10;
            this.txtFilterValue.BorderSize = 2;
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilterValue.Location = new System.Drawing.Point(530, 20);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Multiline = false;
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFilterValue.PasswordChar = false;
            this.txtFilterValue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFilterValue.PlaceholderText = "Search.....";
            this.txtFilterValue.Size = new System.Drawing.Size(250, 40);
            this.txtFilterValue.TabIndex = 3;
            this.txtFilterValue.Texts = "";
            this.txtFilterValue.UnderlinedStyle = false;
            this.txtFilterValue._TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detain Licenses Menue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sataPictureBox1
            // 
            this.sataPictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.Detain_64;
            this.sataPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sataPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.sataPictureBox1.BorderColor = System.Drawing.Color.Empty;
            this.sataPictureBox1.BorderColor2 = System.Drawing.Color.Empty;
            this.sataPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.sataPictureBox1.BorderSize = 1;
            this.sataPictureBox1.GradientAngle = 50F;
            this.sataPictureBox1.Location = new System.Drawing.Point(5, 5);
            this.sataPictureBox1.Name = "sataPictureBox1";
            this.sataPictureBox1.Size = new System.Drawing.Size(64, 64);
            this.sataPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sataPictureBox1.TabIndex = 0;
            this.sataPictureBox1.TabStop = false;
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToResizeRows = false;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetainedLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetainedLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.CnRigthClick;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetainedLicenses.EnableHeadersVisualStyles = false;
            this.dgvDetainedLicenses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(3, 123);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1264, 621);
            this.dgvDetainedLicenses.TabIndex = 1;
            // 
            // CnRigthClick
            // 
            this.CnRigthClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itshowDetails,
            this.itShowLicense,
            this.ItHistory,
            this.releaseLicense});
            this.CnRigthClick.Name = "metroContextMenu1";
            this.CnRigthClick.Size = new System.Drawing.Size(187, 92);
            this.CnRigthClick.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplications_Opening);
            // 
            // itshowDetails
            // 
            this.itshowDetails.Image = global::DVLD_Project.Properties.Resources.file;
            this.itshowDetails.Name = "itshowDetails";
            this.itshowDetails.ShowShortcutKeys = false;
            this.itshowDetails.Size = new System.Drawing.Size(186, 22);
            this.itshowDetails.Text = "Show details";
            this.itshowDetails.Click += new System.EventHandler(this.PesonDetailsToolStripMenuItem_Click);
            // 
            // itShowLicense
            // 
            this.itShowLicense.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.itShowLicense.Name = "itShowLicense";
            this.itShowLicense.Size = new System.Drawing.Size(186, 22);
            this.itShowLicense.Text = "Show License";
            this.itShowLicense.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // ItHistory
            // 
            this.ItHistory.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.ItHistory.Name = "ItHistory";
            this.ItHistory.Size = new System.Drawing.Size(186, 22);
            this.ItHistory.Text = "Show License History";
            this.ItHistory.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // releaseLicense
            // 
            this.releaseLicense.Image = global::DVLD_Project.Properties.Resources.Release_Detained_License_64;
            this.releaseLicense.Name = "releaseLicense";
            this.releaseLicense.Size = new System.Drawing.Size(186, 22);
            this.releaseLicense.Text = "Release License";
            this.releaseLicense.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 20;
            this.sEllipse1.TargetControl = this.dgvDetainedLicenses;
            // 
            // ListDetaineLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1270, 797);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListDetaineLicense";
            this.Text = "ListDetaineLicense";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.sataPanel2.ResumeLayout(false);
            this.sataPanel2.PerformLayout();
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.CnRigthClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SATAUiFramework.SATAPanel sataPanel2;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label2;
        private SATAUiFramework.SATAPanel sataPanel1;
        private MetroFramework.Controls.MetroComboBox cbFilterBy;
        private Sipaa.Framework.SButton btShowAddForm;
        private Sipaa.Framework.STextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private SATAUiFramework.Controls.SATAPictureBox sataPictureBox1;
        private MetroFramework.Controls.MetroGrid dgvDetainedLicenses;
        private MetroFramework.Controls.MetroContextMenu CnRigthClick;
        private System.Windows.Forms.ToolStripMenuItem itshowDetails;
        private System.Windows.Forms.ToolStripMenuItem itShowLicense;
        private System.Windows.Forms.ToolStripMenuItem ItHistory;
        private Sipaa.Framework.SEllipse sEllipse1;
        private System.Windows.Forms.ToolStripMenuItem releaseLicense;
        private Sipaa.Framework.SButton sButton1;
        private MetroFramework.Controls.MetroComboBox cbIsReleased;
    }
}