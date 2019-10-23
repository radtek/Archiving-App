namespace Apex
{
    partial class Add_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Project));
            this.Browse_File_Wind = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.RowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStartDate = new System.Windows.Forms.DateTimePicker();
            this.Browse = new System.Windows.Forms.Button();
            this.SelectedFiles = new System.Windows.Forms.DataGridView();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddPartner = new System.Windows.Forms.TextBox();
            this.AddProjectN = new System.Windows.Forms.TextBox();
            this.AddEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.AddLoc = new System.Windows.Forms.ComboBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse_File_Wind
            // 
            this.Browse_File_Wind.FileName = "Browse_File_Wind";
            this.Browse_File_Wind.Multiselect = true;
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
            // RowMenu
            // 
            this.RowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDelete});
            this.RowMenu.Name = "RowMenu";
            this.RowMenu.Size = new System.Drawing.Size(108, 26);
            this.RowMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RowMenu_ItemClicked);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(107, 22);
            this.MenuDelete.Text = "Delete";
            // 
            // AddStartDate
            // 
            this.AddStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStartDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.AddStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddStartDate.Location = new System.Drawing.Point(127, 175);
            this.AddStartDate.Name = "AddStartDate";
            this.AddStartDate.Size = new System.Drawing.Size(105, 21);
            this.AddStartDate.TabIndex = 62;
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
            this.Browse.TabIndex = 52;
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
            this.ProjectN,
            this.Location,
            this.Partner,
            this.StartDate,
            this.EndDate,
            this.Extension,
            this.FilePath});
            this.SelectedFiles.Location = new System.Drawing.Point(632, 36);
            this.SelectedFiles.Name = "SelectedFiles";
            this.SelectedFiles.ReadOnly = true;
            this.SelectedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedFiles.Size = new System.Drawing.Size(709, 402);
            this.SelectedFiles.TabIndex = 55;
            this.SelectedFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectedFiles_MouseClick);
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
            this.Cancel.TabIndex = 54;
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
            this.Add.TabIndex = 53;
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
            this.label1.TabIndex = 61;
            this.label1.Text = "Selected Files :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Project Name : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Location : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 60;
            this.label8.Text = "Partner Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "Start Date : ";
            // 
            // AddPartner
            // 
            this.AddPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartner.Location = new System.Drawing.Point(127, 130);
            this.AddPartner.Name = "AddPartner";
            this.AddPartner.Size = new System.Drawing.Size(499, 21);
            this.AddPartner.TabIndex = 50;
            // 
            // AddProjectN
            // 
            this.AddProjectN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectN.Location = new System.Drawing.Point(127, 36);
            this.AddProjectN.Name = "AddProjectN";
            this.AddProjectN.Size = new System.Drawing.Size(499, 21);
            this.AddProjectN.TabIndex = 48;
            // 
            // AddEndDate
            // 
            this.AddEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEndDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.AddEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddEndDate.Location = new System.Drawing.Point(127, 222);
            this.AddEndDate.Name = "AddEndDate";
            this.AddEndDate.Size = new System.Drawing.Size(105, 21);
            this.AddEndDate.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "End Date : ";
            // 
            // AddLoc
            // 
            this.AddLoc.BackColor = System.Drawing.Color.White;
            this.AddLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddLoc.FormattingEnabled = true;
            this.AddLoc.Items.AddRange(new object[] {
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
            this.AddLoc.Location = new System.Drawing.Point(127, 83);
            this.AddLoc.Name = "AddLoc";
            this.AddLoc.Size = new System.Drawing.Size(499, 23);
            this.AddLoc.TabIndex = 65;
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
            // ProjectN
            // 
            this.ProjectN.DataPropertyName = "ProjectN";
            this.ProjectN.HeaderText = "Project Name";
            this.ProjectN.Name = "ProjectN";
            this.ProjectN.ReadOnly = true;
            this.ProjectN.Width = 95;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 96;
            // 
            // Partner
            // 
            this.Partner.DataPropertyName = "Partner";
            this.Partner.HeaderText = "Partner";
            this.Partner.Name = "Partner";
            this.Partner.ReadOnly = true;
            this.Partner.Width = 95;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 95;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End Date";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 95;
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
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.AddLoc);
            this.Controls.Add(this.AddEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddStartDate);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SelectedFiles);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddPartner);
            this.Controls.Add(this.AddProjectN);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Project";
            this.Text = "Add Project";
            this.RowMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Browse_File_Wind;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip RowMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.DateTimePicker AddStartDate;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.DataGridView SelectedFiles;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddPartner;
        private System.Windows.Forms.TextBox AddProjectN;
        private System.Windows.Forms.DateTimePicker AddEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AddLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partner;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
    }
}