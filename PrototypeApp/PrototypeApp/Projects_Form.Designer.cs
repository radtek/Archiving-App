namespace PolyDoc
{
    partial class Projects_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PB = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchStartDate = new System.Windows.Forms.DateTimePicker();
            this.DisableStartDate = new System.Windows.Forms.CheckBox();
            this.Projects_Grid = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchEx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchProjectN = new System.Windows.Forms.TextBox();
            this.SearchLoc = new System.Windows.Forms.ComboBox();
            this.SearchP = new System.Windows.Forms.TextBox();
            this.SearchN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchEndDate = new System.Windows.Forms.DateTimePicker();
            this.DisableEndDate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchPartner = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.View_Info = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Projects_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(0)))), ((int)(((byte)(126)))));
            this.PB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PB.ForeColor = System.Drawing.Color.White;
            this.PB.Location = new System.Drawing.Point(0, 623);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(1248, 23);
            this.PB.TabIndex = 69;
            this.PB.Text = " Powered by : Polygon Network Company";
            this.PB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "garbage.png");
            this.imageList1.Images.SetKeyName(1, "plus.png");
            this.imageList1.Images.SetKeyName(2, "edit.png");
            this.imageList1.Images.SetKeyName(3, "search.png");
            this.imageList1.Images.SetKeyName(4, "view.png");
            this.imageList1.Images.SetKeyName(5, "add.png");
            this.imageList1.Images.SetKeyName(6, "error.png");
            this.imageList1.Images.SetKeyName(7, "folder.png");
            this.imageList1.Images.SetKeyName(8, "success.png");
            this.imageList1.Images.SetKeyName(9, "brush.png");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(573, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 47);
            this.label11.TabIndex = 68;
            this.label11.Text = "DELETED";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(640, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 67;
            this.label10.Text = "Code : ";
            // 
            // SearchCode
            // 
            this.SearchCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCode.BackColor = System.Drawing.Color.White;
            this.SearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCode.Location = new System.Drawing.Point(739, 114);
            this.SearchCode.Name = "SearchCode";
            this.SearchCode.Size = new System.Drawing.Size(497, 21);
            this.SearchCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "File Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "File Path : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "Start Date : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "Project Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 63;
            this.label5.Text = "Location : ";
            // 
            // SearchStartDate
            // 
            this.SearchStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStartDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchStartDate.Location = new System.Drawing.Point(109, 145);
            this.SearchStartDate.Name = "SearchStartDate";
            this.SearchStartDate.Size = new System.Drawing.Size(105, 21);
            this.SearchStartDate.TabIndex = 7;
            // 
            // DisableStartDate
            // 
            this.DisableStartDate.AutoSize = true;
            this.DisableStartDate.Checked = true;
            this.DisableStartDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableStartDate.Location = new System.Drawing.Point(220, 149);
            this.DisableStartDate.Name = "DisableStartDate";
            this.DisableStartDate.Size = new System.Drawing.Size(97, 19);
            this.DisableStartDate.TabIndex = 8;
            this.DisableStartDate.Text = "Disable Date";
            this.DisableStartDate.UseVisualStyleBackColor = true;
            // 
            // Projects_Grid
            // 
            this.Projects_Grid.AllowUserToAddRows = false;
            this.Projects_Grid.AllowUserToDeleteRows = false;
            this.Projects_Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Projects_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Projects_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Projects_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Projects_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Partner,
            this.ProjectN,
            this.Loc,
            this.StartDate,
            this.EndDate,
            this.FileName,
            this.Path,
            this.Extension});
            this.Projects_Grid.GridColor = System.Drawing.Color.White;
            this.Projects_Grid.Location = new System.Drawing.Point(15, 272);
            this.Projects_Grid.Name = "Projects_Grid";
            this.Projects_Grid.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Projects_Grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Projects_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Projects_Grid.Size = new System.Drawing.Size(1221, 347);
            this.Projects_Grid.TabIndex = 16;
            this.Projects_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Projects_Grid_CellDoubleClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 135;
            // 
            // Partner
            // 
            this.Partner.DataPropertyName = "Partner";
            this.Partner.HeaderText = "Partner";
            this.Partner.Name = "Partner";
            this.Partner.ReadOnly = true;
            this.Partner.Width = 136;
            // 
            // ProjectN
            // 
            this.ProjectN.DataPropertyName = "ProjectName";
            this.ProjectN.HeaderText = "Project Name";
            this.ProjectN.Name = "ProjectN";
            this.ProjectN.ReadOnly = true;
            this.ProjectN.Width = 135;
            // 
            // Loc
            // 
            this.Loc.DataPropertyName = "Location";
            this.Loc.HeaderText = "Location";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Width = 136;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 135;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 136;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "Name";
            this.FileName.FillWeight = 86.0406F;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 116;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.FillWeight = 86.0406F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 117;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Width = 135;
            // 
            // SearchEx
            // 
            this.SearchEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchEx.BackColor = System.Drawing.Color.White;
            this.SearchEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEx.Location = new System.Drawing.Point(1061, 48);
            this.SearchEx.Name = "SearchEx";
            this.SearchEx.Size = new System.Drawing.Size(175, 21);
            this.SearchEx.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(962, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "File Extension : ";
            // 
            // SearchProjectN
            // 
            this.SearchProjectN.BackColor = System.Drawing.Color.White;
            this.SearchProjectN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProjectN.Location = new System.Drawing.Point(109, 81);
            this.SearchProjectN.Name = "SearchProjectN";
            this.SearchProjectN.Size = new System.Drawing.Size(525, 21);
            this.SearchProjectN.TabIndex = 3;
            // 
            // SearchLoc
            // 
            this.SearchLoc.BackColor = System.Drawing.Color.White;
            this.SearchLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchLoc.FormattingEnabled = true;
            this.SearchLoc.Items.AddRange(new object[] {
            "6th Of October",
            "Alexandria",
            "Aswan",
            "Asyut",
            "Beheira",
            "Beni Suef",
            "Cairo",
            "Dakahlia",
            "Damietta",
            "Faiyum",
            "Gharbia",
            "Helwan",
            "Ismailia",
            "Kafr El Sheikh",
            "Luxor",
            "Matruh",
            "Minya",
            "Monufia",
            "New Valley",
            "North Sinai",
            "Port Said",
            "Qalyubia",
            "Qena",
            "Red Sea",
            "Sharqia",
            "Sohag",
            "South Sinai",
            "Suez",
            "-Disable-"});
            this.SearchLoc.Location = new System.Drawing.Point(109, 112);
            this.SearchLoc.Name = "SearchLoc";
            this.SearchLoc.Size = new System.Drawing.Size(525, 23);
            this.SearchLoc.TabIndex = 5;
            // 
            // SearchP
            // 
            this.SearchP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchP.BackColor = System.Drawing.Color.White;
            this.SearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchP.Location = new System.Drawing.Point(109, 48);
            this.SearchP.Name = "SearchP";
            this.SearchP.Size = new System.Drawing.Size(847, 21);
            this.SearchP.TabIndex = 1;
            // 
            // SearchN
            // 
            this.SearchN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchN.BackColor = System.Drawing.Color.White;
            this.SearchN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchN.Location = new System.Drawing.Point(109, 15);
            this.SearchN.Name = "SearchN";
            this.SearchN.Size = new System.Drawing.Size(1127, 21);
            this.SearchN.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 71;
            this.label6.Text = "End Date : ";
            // 
            // SearchEndDate
            // 
            this.SearchEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEndDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchEndDate.Location = new System.Drawing.Point(109, 178);
            this.SearchEndDate.Name = "SearchEndDate";
            this.SearchEndDate.Size = new System.Drawing.Size(105, 21);
            this.SearchEndDate.TabIndex = 9;
            // 
            // DisableEndDate
            // 
            this.DisableEndDate.AutoSize = true;
            this.DisableEndDate.Checked = true;
            this.DisableEndDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableEndDate.Location = new System.Drawing.Point(220, 182);
            this.DisableEndDate.Name = "DisableEndDate";
            this.DisableEndDate.Size = new System.Drawing.Size(97, 19);
            this.DisableEndDate.TabIndex = 10;
            this.DisableEndDate.Text = "Disable Date";
            this.DisableEndDate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 74;
            this.label7.Text = "Partner Name : ";
            // 
            // SearchPartner
            // 
            this.SearchPartner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPartner.BackColor = System.Drawing.Color.White;
            this.SearchPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPartner.Location = new System.Drawing.Point(739, 81);
            this.SearchPartner.Name = "SearchPartner";
            this.SearchPartner.Size = new System.Drawing.Size(497, 21);
            this.SearchPartner.TabIndex = 4;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.ImageIndex = 9;
            this.Clear.ImageList = this.imageList1;
            this.Clear.Location = new System.Drawing.Point(1106, 222);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(130, 44);
            this.Clear.TabIndex = 15;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // View_Info
            // 
            this.View_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.View_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.View_Info.ImageIndex = 4;
            this.View_Info.ImageList = this.imageList1;
            this.View_Info.Location = new System.Drawing.Point(287, 222);
            this.View_Info.Name = "View_Info";
            this.View_Info.Size = new System.Drawing.Size(130, 44);
            this.View_Info.TabIndex = 13;
            this.View_Info.Text = "View";
            this.View_Info.UseVisualStyleBackColor = true;
            this.View_Info.Click += new System.EventHandler(this.View_Info_Click);
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.ImageIndex = 3;
            this.Search.ImageList = this.imageList1;
            this.Search.Location = new System.Drawing.Point(970, 222);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(130, 44);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.ImageIndex = 0;
            this.Delete.ImageList = this.imageList1;
            this.Delete.Location = new System.Drawing.Point(151, 222);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 44);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.ImageIndex = 5;
            this.Add.ImageList = this.imageList1;
            this.Add.Location = new System.Drawing.Point(15, 222);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 44);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Projects_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchPartner);
            this.Controls.Add(this.DisableEndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchEndDate);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SearchCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.View_Info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchStartDate);
            this.Controls.Add(this.DisableStartDate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Projects_Grid);
            this.Controls.Add(this.SearchEx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchProjectN);
            this.Controls.Add(this.SearchLoc);
            this.Controls.Add(this.SearchP);
            this.Controls.Add(this.SearchN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Projects_Form";
            this.Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)(this.Projects_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PB;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SearchCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button View_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker SearchStartDate;
        private System.Windows.Forms.CheckBox DisableStartDate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView Projects_Grid;
        private System.Windows.Forms.TextBox SearchEx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchProjectN;
        private System.Windows.Forms.ComboBox SearchLoc;
        private System.Windows.Forms.TextBox SearchP;
        private System.Windows.Forms.TextBox SearchN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker SearchEndDate;
        private System.Windows.Forms.CheckBox DisableEndDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
    }
}