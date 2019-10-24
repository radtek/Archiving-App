namespace PolyDoc
{
    partial class HR_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.SearchEmpID = new System.Windows.Forms.TextBox();
            this.DisableEmploymentDate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.PB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.View_Info = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBirthDate = new System.Windows.Forms.DateTimePicker();
            this.DisableBirthDate = new System.Windows.Forms.CheckBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.HR_Grid = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchEx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchEmpName = new System.Windows.Forms.TextBox();
            this.SearchEmpJob = new System.Windows.Forms.ComboBox();
            this.SearchP = new System.Windows.Forms.TextBox();
            this.SearchN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HR_Grid)).BeginInit();
            this.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(640, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 102;
            this.label7.Text = "Employee ID : ";
            // 
            // SearchEmpID
            // 
            this.SearchEmpID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchEmpID.BackColor = System.Drawing.Color.White;
            this.SearchEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmpID.Location = new System.Drawing.Point(732, 81);
            this.SearchEmpID.Name = "SearchEmpID";
            this.SearchEmpID.Size = new System.Drawing.Size(504, 21);
            this.SearchEmpID.TabIndex = 4;
            this.SearchEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchEmpID_KeyPress);
            // 
            // DisableEmploymentDate
            // 
            this.DisableEmploymentDate.AutoSize = true;
            this.DisableEmploymentDate.Checked = true;
            this.DisableEmploymentDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableEmploymentDate.Location = new System.Drawing.Point(237, 182);
            this.DisableEmploymentDate.Name = "DisableEmploymentDate";
            this.DisableEmploymentDate.Size = new System.Drawing.Size(97, 19);
            this.DisableEmploymentDate.TabIndex = 10;
            this.DisableEmploymentDate.Text = "Disable Date";
            this.DisableEmploymentDate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 99;
            this.label6.Text = "Employment Date : ";
            // 
            // SearchEmploymentDate
            // 
            this.SearchEmploymentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmploymentDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmploymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchEmploymentDate.Location = new System.Drawing.Point(126, 178);
            this.SearchEmploymentDate.Name = "SearchEmploymentDate";
            this.SearchEmploymentDate.Size = new System.Drawing.Size(105, 21);
            this.SearchEmploymentDate.TabIndex = 9;
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
            this.PB.TabIndex = 97;
            this.PB.Text = " Powered by : Polygon Network Company";
            this.PB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(573, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 47);
            this.label11.TabIndex = 96;
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
            this.label10.TabIndex = 95;
            this.label10.Text = "Code : ";
            // 
            // SearchCode
            // 
            this.SearchCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCode.BackColor = System.Drawing.Color.White;
            this.SearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCode.Location = new System.Drawing.Point(732, 114);
            this.SearchCode.Name = "SearchCode";
            this.SearchCode.Size = new System.Drawing.Size(504, 21);
            this.SearchCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 87;
            this.label1.Text = "File Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 89;
            this.label2.Text = "File Path : ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 91;
            this.label3.Text = "Date Of Birth : ";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 92;
            this.label4.Text = "Employee Name : ";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Job : ";
            // 
            // SearchBirthDate
            // 
            this.SearchBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBirthDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SearchBirthDate.Location = new System.Drawing.Point(126, 145);
            this.SearchBirthDate.Name = "SearchBirthDate";
            this.SearchBirthDate.Size = new System.Drawing.Size(105, 21);
            this.SearchBirthDate.TabIndex = 7;
            // 
            // DisableBirthDate
            // 
            this.DisableBirthDate.AutoSize = true;
            this.DisableBirthDate.Checked = true;
            this.DisableBirthDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableBirthDate.Location = new System.Drawing.Point(237, 149);
            this.DisableBirthDate.Name = "DisableBirthDate";
            this.DisableBirthDate.Size = new System.Drawing.Size(97, 19);
            this.DisableBirthDate.TabIndex = 8;
            this.DisableBirthDate.Text = "Disable Date";
            this.DisableBirthDate.UseVisualStyleBackColor = true;
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
            // HR_Grid
            // 
            this.HR_Grid.AllowUserToAddRows = false;
            this.HR_Grid.AllowUserToDeleteRows = false;
            this.HR_Grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HR_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HR_Grid.BackgroundColor = System.Drawing.Color.White;
            this.HR_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HR_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.EmpID,
            this.EmpName,
            this.EmpJob,
            this.EmpBirthDate,
            this.EmpEmploymentDate,
            this.FileName,
            this.Path,
            this.Extension});
            this.HR_Grid.GridColor = System.Drawing.Color.White;
            this.HR_Grid.Location = new System.Drawing.Point(15, 272);
            this.HR_Grid.Name = "HR_Grid";
            this.HR_Grid.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_Grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.HR_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HR_Grid.Size = new System.Drawing.Size(1221, 347);
            this.HR_Grid.TabIndex = 16;
            this.HR_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HR_Grid_CellDoubleClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 135;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "Empolyee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Width = 135;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 135;
            // 
            // EmpJob
            // 
            this.EmpJob.DataPropertyName = "EmpJob";
            this.EmpJob.HeaderText = "Job";
            this.EmpJob.Name = "EmpJob";
            this.EmpJob.ReadOnly = true;
            this.EmpJob.Width = 135;
            // 
            // EmpBirthDate
            // 
            this.EmpBirthDate.DataPropertyName = "EmpBirthDate";
            this.EmpBirthDate.HeaderText = "Birth Date";
            this.EmpBirthDate.Name = "EmpBirthDate";
            this.EmpBirthDate.ReadOnly = true;
            this.EmpBirthDate.Width = 135;
            // 
            // EmpEmploymentDate
            // 
            this.EmpEmploymentDate.DataPropertyName = "EmpEmploymentDate";
            this.EmpEmploymentDate.HeaderText = "Empoyment Date";
            this.EmpEmploymentDate.Name = "EmpEmploymentDate";
            this.EmpEmploymentDate.ReadOnly = true;
            this.EmpEmploymentDate.Width = 135;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "Name";
            this.FileName.FillWeight = 86.0406F;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 117;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.FillWeight = 86.0406F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 116;
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
            this.label9.TabIndex = 94;
            this.label9.Text = "File Extension : ";
            // 
            // SearchEmpName
            // 
            this.SearchEmpName.BackColor = System.Drawing.Color.White;
            this.SearchEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmpName.Location = new System.Drawing.Point(126, 81);
            this.SearchEmpName.Name = "SearchEmpName";
            this.SearchEmpName.Size = new System.Drawing.Size(508, 21);
            this.SearchEmpName.TabIndex = 3;
            // 
            // SearchEmpJob
            // 
            this.SearchEmpJob.BackColor = System.Drawing.Color.White;
            this.SearchEmpJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchEmpJob.FormattingEnabled = true;
            this.SearchEmpJob.Location = new System.Drawing.Point(126, 112);
            this.SearchEmpJob.Name = "SearchEmpJob";
            this.SearchEmpJob.Size = new System.Drawing.Size(508, 23);
            this.SearchEmpJob.TabIndex = 5;
            // 
            // SearchP
            // 
            this.SearchP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchP.BackColor = System.Drawing.Color.White;
            this.SearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchP.Location = new System.Drawing.Point(126, 48);
            this.SearchP.Name = "SearchP";
            this.SearchP.Size = new System.Drawing.Size(830, 21);
            this.SearchP.TabIndex = 1;
            // 
            // SearchN
            // 
            this.SearchN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchN.BackColor = System.Drawing.Color.White;
            this.SearchN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchN.Location = new System.Drawing.Point(126, 15);
            this.SearchN.Name = "SearchN";
            this.SearchN.Size = new System.Drawing.Size(1110, 21);
            this.SearchN.TabIndex = 0;
            // 
            // HR_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchEmpID);
            this.Controls.Add(this.DisableEmploymentDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchEmploymentDate);
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
            this.Controls.Add(this.SearchBirthDate);
            this.Controls.Add(this.DisableBirthDate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.HR_Grid);
            this.Controls.Add(this.SearchEx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchEmpName);
            this.Controls.Add(this.SearchEmpJob);
            this.Controls.Add(this.SearchP);
            this.Controls.Add(this.SearchN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HR_Form";
            this.Text = "HR";
            ((System.ComponentModel.ISupportInitialize)(this.HR_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchEmpID;
        private System.Windows.Forms.CheckBox DisableEmploymentDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker SearchEmploymentDate;
        private System.Windows.Forms.Label PB;
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
        private System.Windows.Forms.DateTimePicker SearchBirthDate;
        private System.Windows.Forms.CheckBox DisableBirthDate;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView HR_Grid;
        private System.Windows.Forms.TextBox SearchEx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchEmpName;
        private System.Windows.Forms.ComboBox SearchEmpJob;
        private System.Windows.Forms.TextBox SearchP;
        private System.Windows.Forms.TextBox SearchN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmploymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
    }
}