namespace PolyDoc
{
    partial class Add_HR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_HR));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Browse_File_Wind = new System.Windows.Forms.OpenFileDialog();
            this.RowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmpJob = new System.Windows.Forms.ComboBox();
            this.AddEmpEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddEmpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.Browse = new System.Windows.Forms.Button();
            this.SelectedFiles = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpEmploymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddEmpID = new System.Windows.Forms.TextBox();
            this.AddEmpName = new System.Windows.Forms.TextBox();
            this.RowMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFiles)).BeginInit();
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
            this.imageList1.Images.SetKeyName(9, "close.png");
            // 
            // Browse_File_Wind
            // 
            this.Browse_File_Wind.Multiselect = true;
            // 
            // RowMenu
            // 
            this.RowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDelete});
            this.RowMenu.Name = "RowMenu";
            this.RowMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(107, 22);
            this.MenuDelete.Text = "Delete";
            // 
            // AddEmpJob
            // 
            this.AddEmpJob.BackColor = System.Drawing.Color.White;
            this.AddEmpJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmpJob.FormattingEnabled = true;
            this.AddEmpJob.Location = new System.Drawing.Point(132, 83);
            this.AddEmpJob.Name = "AddEmpJob";
            this.AddEmpJob.Size = new System.Drawing.Size(494, 23);
            this.AddEmpJob.TabIndex = 80;
            // 
            // AddEmpEmploymentDate
            // 
            this.AddEmpEmploymentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpEmploymentDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.AddEmpEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpEmploymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddEmpEmploymentDate.Location = new System.Drawing.Point(132, 222);
            this.AddEmpEmploymentDate.Name = "AddEmpEmploymentDate";
            this.AddEmpEmploymentDate.Size = new System.Drawing.Size(105, 21);
            this.AddEmpEmploymentDate.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Employment Date : ";
            // 
            // AddEmpBirthDate
            // 
            this.AddEmpBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBirthDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.AddEmpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddEmpBirthDate.Location = new System.Drawing.Point(132, 175);
            this.AddEmpBirthDate.Name = "AddEmpBirthDate";
            this.AddEmpBirthDate.Size = new System.Drawing.Size(105, 21);
            this.AddEmpBirthDate.TabIndex = 77;
            // 
            // Browse
            // 
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browse.ImageIndex = 7;
            this.Browse.ImageList = this.imageList1;
            this.Browse.Location = new System.Drawing.Point(496, 251);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(130, 44);
            this.Browse.TabIndex = 68;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // SelectedFiles
            // 
            this.SelectedFiles.AllowUserToAddRows = false;
            this.SelectedFiles.AllowUserToDeleteRows = false;
            this.SelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedFiles.BackgroundColor = System.Drawing.Color.White;
            this.SelectedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.FileN,
            this.EmpName,
            this.EmpJob,
            this.EmpID,
            this.EmpBirthDate,
            this.EmpEmploymentDate,
            this.Extension,
            this.FilePath});
            this.SelectedFiles.Location = new System.Drawing.Point(632, 36);
            this.SelectedFiles.Name = "SelectedFiles";
            this.SelectedFiles.ReadOnly = true;
            this.SelectedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedFiles.Size = new System.Drawing.Size(709, 402);
            this.SelectedFiles.TabIndex = 71;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 95;
            // 
            // FileN
            // 
            this.FileN.DataPropertyName = "FileN";
            this.FileN.HeaderText = "File Name";
            this.FileN.Name = "FileN";
            this.FileN.ReadOnly = true;
            this.FileN.Width = 95;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 95;
            // 
            // EmpJob
            // 
            this.EmpJob.DataPropertyName = "EmpJob";
            this.EmpJob.HeaderText = "Job";
            this.EmpJob.Name = "EmpJob";
            this.EmpJob.ReadOnly = true;
            this.EmpJob.Width = 96;
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Width = 95;
            // 
            // EmpBirthDate
            // 
            this.EmpBirthDate.DataPropertyName = "EmpBirthDate";
            this.EmpBirthDate.HeaderText = "Date Of Birth";
            this.EmpBirthDate.Name = "EmpBirthDate";
            this.EmpBirthDate.ReadOnly = true;
            this.EmpBirthDate.Width = 95;
            // 
            // EmpEmploymentDate
            // 
            this.EmpEmploymentDate.DataPropertyName = "EmpEmploymentDate";
            this.EmpEmploymentDate.HeaderText = "Employment Date";
            this.EmpEmploymentDate.Name = "EmpEmploymentDate";
            this.EmpEmploymentDate.ReadOnly = true;
            this.EmpEmploymentDate.Width = 95;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "FIleExtension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Visible = false;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.White;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.ImageIndex = 9;
            this.Cancel.ImageList = this.imageList1;
            this.Cancel.Location = new System.Drawing.Point(148, 394);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 44);
            this.Cancel.TabIndex = 70;
            this.Cancel.Text = "Close";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.ImageIndex = 5;
            this.Add.ImageList = this.imageList1;
            this.Add.Location = new System.Drawing.Point(12, 394);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 44);
            this.Add.TabIndex = 69;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Selected Files :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 73;
            this.label3.Text = "Employee Name : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 74;
            this.label7.Text = "Job : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 75;
            this.label8.Text = "Employee ID : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 72;
            this.label5.Text = "Date Of Birth : ";
            // 
            // AddEmpID
            // 
            this.AddEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpID.Location = new System.Drawing.Point(132, 130);
            this.AddEmpID.Name = "AddEmpID";
            this.AddEmpID.Size = new System.Drawing.Size(494, 21);
            this.AddEmpID.TabIndex = 67;
            this.AddEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddEmpID_KeyPress);
            // 
            // AddEmpName
            // 
            this.AddEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpName.Location = new System.Drawing.Point(132, 36);
            this.AddEmpName.Name = "AddEmpName";
            this.AddEmpName.Size = new System.Drawing.Size(494, 21);
            this.AddEmpName.TabIndex = 66;
            // 
            // Add_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.AddEmpJob);
            this.Controls.Add(this.AddEmpEmploymentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddEmpBirthDate);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SelectedFiles);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddEmpID);
            this.Controls.Add(this.AddEmpName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Add_HR";
            this.Text = "Add Employee";
            this.RowMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog Browse_File_Wind;
        private System.Windows.Forms.ContextMenuStrip RowMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ComboBox AddEmpJob;
        private System.Windows.Forms.DateTimePicker AddEmpEmploymentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker AddEmpBirthDate;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.DataGridView SelectedFiles;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddEmpID;
        private System.Windows.Forms.TextBox AddEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileN;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpEmploymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
    }
}