namespace DVLD_Project.Resources
{
    partial class ApplicationsMenueSreen
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
            this.lbTotalRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.cmStatus = new MetroFramework.Controls.MetroComboBox();
            this.cmSearshBy = new MetroFramework.Controls.MetroComboBox();
            this.btShowAddForm = new Sipaa.Framework.SButton();
            this.txSearsh = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sataPictureBox1 = new SATAUiFramework.Controls.SATAPictureBox();
            this.dgvAppsMenue = new MetroFramework.Controls.MetroGrid();
            this.CnRigthClick = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.itshowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.itedite = new System.Windows.Forms.ToolStripMenuItem();
            this.itDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.itCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.itSchdule = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SchduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.itIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.itShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ItHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.sEllipse1 = new Sipaa.Framework.SEllipse();
            this.tableLayoutPanel1.SuspendLayout();
            this.sataPanel2.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsMenue)).BeginInit();
            this.CnRigthClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.sataPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sataPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvAppsMenue, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 797);
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.sataPanel2.Controls.Add(this.lbTotalRecords);
            this.sataPanel2.Controls.Add(this.label2);
            this.sataPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel2.Location = new System.Drawing.Point(3, 750);
            this.sataPanel2.Name = "sataPanel2";
            this.sataPanel2.Size = new System.Drawing.Size(1264, 44);
            this.sataPanel2.TabIndex = 3;
            // 
            // lbTotalRecords
            // 
            this.lbTotalRecords.AutoEllipsis = true;
            this.lbTotalRecords.AutoSize = true;
            this.lbTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRecords.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTotalRecords.Location = new System.Drawing.Point(221, 9);
            this.lbTotalRecords.Name = "lbTotalRecords";
            this.lbTotalRecords.Size = new System.Drawing.Size(27, 29);
            this.lbTotalRecords.TabIndex = 3;
            this.lbTotalRecords.Text = "0";
            this.lbTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.sataPanel1.Controls.Add(this.cmStatus);
            this.sataPanel1.Controls.Add(this.cmSearshBy);
            this.sataPanel1.Controls.Add(this.btShowAddForm);
            this.sataPanel1.Controls.Add(this.txSearsh);
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.sataPictureBox1);
            this.sataPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sataPanel1.Location = new System.Drawing.Point(3, 43);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(1264, 74);
            this.sataPanel1.TabIndex = 0;
            // 
            // cmStatus
            // 
            this.cmStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmStatus.FormattingEnabled = true;
            this.cmStatus.ItemHeight = 23;
            this.cmStatus.Items.AddRange(new object[] {
            "New",
            "Cancelled",
            "Completed"});
            this.cmStatus.Location = new System.Drawing.Point(818, 26);
            this.cmStatus.Name = "cmStatus";
            this.cmStatus.Size = new System.Drawing.Size(101, 29);
            this.cmStatus.TabIndex = 6;
            this.cmStatus.UseSelectable = true;
            this.cmStatus.Visible = false;
            this.cmStatus.SelectedIndexChanged += new System.EventHandler(this.cmStatus_SelectedIndexChanged);
            // 
            // cmSearshBy
            // 
            this.cmSearshBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmSearshBy.FormattingEnabled = true;
            this.cmSearshBy.ItemHeight = 23;
            this.cmSearshBy.Items.AddRange(new object[] {
            "None",
            "ID",
            "National No",
            "Full Name",
            "Status"});
            this.cmSearshBy.Location = new System.Drawing.Point(787, 26);
            this.cmSearshBy.Name = "cmSearshBy";
            this.cmSearshBy.Size = new System.Drawing.Size(25, 29);
            this.cmSearshBy.TabIndex = 4;
            this.cmSearshBy.UseSelectable = true;
            this.cmSearshBy.SelectedIndexChanged += new System.EventHandler(this.cmSearshBy_SelectedIndexChanged);
            this.cmSearshBy.MouseLeave += new System.EventHandler(this.cmSearshBy_MouseLeave);
            this.cmSearshBy.MouseHover += new System.EventHandler(this.cmSearshBy_MouseHover);
            // 
            // btShowAddForm
            // 
            this.btShowAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowAddForm.BackColor = System.Drawing.Color.Transparent;
            this.btShowAddForm.BackgroundImage = global::DVLD_Project.Properties.Resources.AddApp;
            this.btShowAddForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btShowAddForm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btShowAddForm.BorderRadius = 6;
            this.btShowAddForm.BorderSize = 0;
            this.btShowAddForm.FlatAppearance.BorderSize = 0;
            this.btShowAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowAddForm.ForeColor = System.Drawing.Color.White;
            this.btShowAddForm.Location = new System.Drawing.Point(1212, 17);
            this.btShowAddForm.Name = "btShowAddForm";
            this.btShowAddForm.Size = new System.Drawing.Size(43, 40);
            this.btShowAddForm.TabIndex = 5;
            this.btShowAddForm.UseVisualStyleBackColor = false;
            this.btShowAddForm.Click += new System.EventHandler(this.btShowAddForm_Click);
            // 
            // txSearsh
            // 
            this.txSearsh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txSearsh.BackColor = System.Drawing.SystemColors.Window;
            this.txSearsh.BorderColor = System.Drawing.Color.DarkMagenta;
            this.txSearsh.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txSearsh.BorderRadius = 10;
            this.txSearsh.BorderSize = 2;
            this.txSearsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txSearsh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txSearsh.Location = new System.Drawing.Point(530, 20);
            this.txSearsh.Margin = new System.Windows.Forms.Padding(4);
            this.txSearsh.Multiline = false;
            this.txSearsh.Name = "txSearsh";
            this.txSearsh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txSearsh.PasswordChar = false;
            this.txSearsh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txSearsh.PlaceholderText = "";
            this.txSearsh.Size = new System.Drawing.Size(250, 40);
            this.txSearsh.TabIndex = 3;
            this.txSearsh.Texts = "";
            this.txSearsh.UnderlinedStyle = false;
            this.txSearsh._TextChanged += new System.EventHandler(this.txSearsh__TextChanged);
            this.txSearsh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearsh_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Driving License Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sataPictureBox1
            // 
            this.sataPictureBox1.BackgroundImage = global::DVLD_Project.Properties.Resources.Manage_Applications_64;
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
            // dgvAppsMenue
            // 
            this.dgvAppsMenue.AllowUserToAddRows = false;
            this.dgvAppsMenue.AllowUserToDeleteRows = false;
            this.dgvAppsMenue.AllowUserToOrderColumns = true;
            this.dgvAppsMenue.AllowUserToResizeRows = false;
            this.dgvAppsMenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppsMenue.BackgroundColor = System.Drawing.Color.White;
            this.dgvAppsMenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppsMenue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppsMenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppsMenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppsMenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppsMenue.ContextMenuStrip = this.CnRigthClick;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppsMenue.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppsMenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppsMenue.EnableHeadersVisualStyles = false;
            this.dgvAppsMenue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAppsMenue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAppsMenue.Location = new System.Drawing.Point(3, 123);
            this.dgvAppsMenue.Name = "dgvAppsMenue";
            this.dgvAppsMenue.ReadOnly = true;
            this.dgvAppsMenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppsMenue.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppsMenue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAppsMenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppsMenue.Size = new System.Drawing.Size(1264, 621);
            this.dgvAppsMenue.TabIndex = 1;
            // 
            // CnRigthClick
            // 
            this.CnRigthClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itshowDetails,
            this.itedite,
            this.itDelete,
            this.itCancel,
            this.itSchdule,
            this.toolStripMenuItem2,
            this.itIssue,
            this.itShowLicense,
            this.ItHistory});
            this.CnRigthClick.Name = "metroContextMenu1";
            this.CnRigthClick.Size = new System.Drawing.Size(187, 208);
            this.CnRigthClick.Opening += new System.ComponentModel.CancelEventHandler(this.metroContextMenu1_Opening);
            // 
            // itshowDetails
            // 
            this.itshowDetails.Image = global::DVLD_Project.Properties.Resources.file;
            this.itshowDetails.Name = "itshowDetails";
            this.itshowDetails.ShowShortcutKeys = false;
            this.itshowDetails.Size = new System.Drawing.Size(186, 22);
            this.itshowDetails.Text = "Show details";
            this.itshowDetails.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // itedite
            // 
            this.itedite.Image = global::DVLD_Project.Properties.Resources.edit;
            this.itedite.Name = "itedite";
            this.itedite.Size = new System.Drawing.Size(186, 22);
            this.itedite.Text = "Edit";
            this.itedite.Click += new System.EventHandler(this.itIdite_Click);
            // 
            // itDelete
            // 
            this.itDelete.Image = global::DVLD_Project.Properties.Resources.trash;
            this.itDelete.Name = "itDelete";
            this.itDelete.Size = new System.Drawing.Size(186, 22);
            this.itDelete.Text = "Delete";
            this.itDelete.Click += new System.EventHandler(this.itDelete_Click);
            // 
            // itCancel
            // 
            this.itCancel.Image = global::DVLD_Project.Properties.Resources.Delete_32;
            this.itCancel.Name = "itCancel";
            this.itCancel.Size = new System.Drawing.Size(186, 22);
            this.itCancel.Text = "Cancel";
            this.itCancel.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // itSchdule
            // 
            this.itSchdule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schduleVisionTest,
            this.SchduleWrittenTest,
            this.ScheduleStreetTest});
            this.itSchdule.Image = global::DVLD_Project.Properties.Resources.TestType_32;
            this.itSchdule.Name = "itSchdule";
            this.itSchdule.ShowShortcutKeys = false;
            this.itSchdule.Size = new System.Drawing.Size(186, 22);
            this.itSchdule.Text = "Sechdule Tests";
            // 
            // schduleVisionTest
            // 
            this.schduleVisionTest.Image = global::DVLD_Project.Properties.Resources.Vision_Test_32;
            this.schduleVisionTest.Name = "schduleVisionTest";
            this.schduleVisionTest.Size = new System.Drawing.Size(181, 22);
            this.schduleVisionTest.Text = "Schdule Vision Test";
            this.schduleVisionTest.Click += new System.EventHandler(this.schduleVisionTestToolStripMenuItem_Click);
            // 
            // SchduleWrittenTest
            // 
            this.SchduleWrittenTest.Image = global::DVLD_Project.Properties.Resources.Schedule_Test_32;
            this.SchduleWrittenTest.Name = "SchduleWrittenTest";
            this.SchduleWrittenTest.Size = new System.Drawing.Size(181, 22);
            this.SchduleWrittenTest.Text = "Schdule Written Test";
            this.SchduleWrittenTest.Click += new System.EventHandler(this.SchduleWrittenTesttoolStripMenuItem3_Click);
            // 
            // ScheduleStreetTest
            // 
            this.ScheduleStreetTest.Image = global::DVLD_Project.Properties.Resources.Street_Test_32;
            this.ScheduleStreetTest.Name = "ScheduleStreetTest";
            this.ScheduleStreetTest.Size = new System.Drawing.Size(181, 22);
            this.ScheduleStreetTest.Text = "Schedule Street Test";
            this.ScheduleStreetTest.Click += new System.EventHandler(this.ScheduleStreetTesttoolStripMenuItem4_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // itIssue
            // 
            this.itIssue.Enabled = false;
            this.itIssue.Image = global::DVLD_Project.Properties.Resources.IssueDrivingLicense_32;
            this.itIssue.Name = "itIssue";
            this.itIssue.Size = new System.Drawing.Size(186, 22);
            this.itIssue.Text = "Issue DL (First Time)";
            this.itIssue.Click += new System.EventHandler(this.IssueLicenseToolStripMenuItem1_Click);
            // 
            // itShowLicense
            // 
            this.itShowLicense.Enabled = false;
            this.itShowLicense.Image = global::DVLD_Project.Properties.Resources.License_View_32;
            this.itShowLicense.Name = "itShowLicense";
            this.itShowLicense.Size = new System.Drawing.Size(186, 22);
            this.itShowLicense.Text = "Show License";
            this.itShowLicense.Click += new System.EventHandler(this.ShowLicenseInfoToolStripMenuItem1_Click);
            // 
            // ItHistory
            // 
            this.ItHistory.Image = global::DVLD_Project.Properties.Resources.PersonLicenseHistory_32;
            this.ItHistory.Name = "ItHistory";
            this.ItHistory.Size = new System.Drawing.Size(186, 22);
            this.ItHistory.Text = "Show License History";
            this.ItHistory.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // sEllipse1
            // 
            this.sEllipse1.CornerRadius = 20;
            this.sEllipse1.TargetControl = this.dgvAppsMenue;
            // 
            // ApplicationsMenueSreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1270, 797);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicationsMenueSreen";
            this.Text = "ApplicationsMenueSreen";
            this.Load += new System.EventHandler(this.ApplicationsMenueSreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.sataPanel2.ResumeLayout(false);
            this.sataPanel2.PerformLayout();
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sataPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppsMenue)).EndInit();
            this.CnRigthClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SATAUiFramework.SATAPanel sataPanel2;
        private System.Windows.Forms.Label lbTotalRecords;
        private System.Windows.Forms.Label label2;
        private SATAUiFramework.SATAPanel sataPanel1;
        private MetroFramework.Controls.MetroComboBox cmStatus;
        private MetroFramework.Controls.MetroComboBox cmSearshBy;
        private Sipaa.Framework.SButton btShowAddForm;
        private Sipaa.Framework.STextBox txSearsh;
        private System.Windows.Forms.Label label1;
        private SATAUiFramework.Controls.SATAPictureBox sataPictureBox1;
        private MetroFramework.Controls.MetroGrid dgvAppsMenue;
        private MetroFramework.Controls.MetroContextMenu CnRigthClick;
        private System.Windows.Forms.ToolStripMenuItem itshowDetails;
        private System.Windows.Forms.ToolStripMenuItem itedite;
        private System.Windows.Forms.ToolStripMenuItem itDelete;
        private System.Windows.Forms.ToolStripMenuItem itCancel;
        private System.Windows.Forms.ToolStripMenuItem itSchdule;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itIssue;
        private System.Windows.Forms.ToolStripMenuItem itShowLicense;
        private Sipaa.Framework.SEllipse sEllipse1;
        private System.Windows.Forms.ToolStripMenuItem ItHistory;
        private System.Windows.Forms.ToolStripMenuItem schduleVisionTest;
        private System.Windows.Forms.ToolStripMenuItem SchduleWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem ScheduleStreetTest;
    }
}