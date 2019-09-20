namespace Apex
{
    partial class Add_Testemonial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Testemonial));
            this.AddDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.AddLocN = new System.Windows.Forms.TextBox();
            this.AddIN = new System.Windows.Forms.TextBox();
            this.Browse_File_Wind = new System.Windows.Forms.OpenFileDialog();
            this.SelectedFiles = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddLoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPro = new System.Windows.Forms.ComboBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.RowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFiles)).BeginInit();
            this.RowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddDate
            // 
            this.AddDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.AddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AddDate.Location = new System.Drawing.Point(127, 224);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(102, 21);
            this.AddDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date : ";
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
            this.Browse.TabIndex = 5;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
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
            // AddLocN
            // 
            this.AddLocN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocN.Location = new System.Drawing.Point(127, 130);
            this.AddLocN.Name = "AddLocN";
            this.AddLocN.Size = new System.Drawing.Size(499, 21);
            this.AddLocN.TabIndex = 2;
            // 
            // AddIN
            // 
            this.AddIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddIN.Location = new System.Drawing.Point(127, 36);
            this.AddIN.Name = "AddIN";
            this.AddIN.Size = new System.Drawing.Size(499, 21);
            this.AddIN.TabIndex = 0;
            // 
            // Browse_File_Wind
            // 
            this.Browse_File_Wind.FileName = "Browse_File_Wind";
            this.Browse_File_Wind.Multiselect = true;
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
            this.InterName,
            this.Loc,
            this.LocN,
            this.Pro,
            this.Date,
            this.Extension,
            this.FilePath});
            this.SelectedFiles.Location = new System.Drawing.Point(632, 36);
            this.SelectedFiles.Name = "SelectedFiles";
            this.SelectedFiles.ReadOnly = true;
            this.SelectedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedFiles.Size = new System.Drawing.Size(709, 402);
            this.SelectedFiles.TabIndex = 8;
            this.SelectedFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectedFiles_MouseClick);
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
            // InterName
            // 
            this.InterName.DataPropertyName = "InterName";
            this.InterName.HeaderText = "Interpreter Name";
            this.InterName.Name = "InterName";
            this.InterName.ReadOnly = true;
            this.InterName.Width = 95;
            // 
            // Loc
            // 
            this.Loc.DataPropertyName = "Loc";
            this.Loc.HeaderText = "Location";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Width = 96;
            // 
            // LocN
            // 
            this.LocN.DataPropertyName = "LocN";
            this.LocN.HeaderText = "Location Name";
            this.LocN.Name = "LocN";
            this.LocN.ReadOnly = true;
            this.LocN.Width = 95;
            // 
            // Pro
            // 
            this.Pro.DataPropertyName = "Pro";
            this.Pro.HeaderText = "Profession";
            this.Pro.Name = "Pro";
            this.Pro.ReadOnly = true;
            this.Pro.Width = 95;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 95;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Profession : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Interpreter Name : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Location : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 42;
            this.label8.Text = "Location Name : ";
            // 
            // AddLoc
            // 
            this.AddLoc.BackColor = System.Drawing.Color.White;
            this.AddLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddLoc.FormattingEnabled = true;
            this.AddLoc.Location = new System.Drawing.Point(127, 83);
            this.AddLoc.Name = "AddLoc";
            this.AddLoc.Size = new System.Drawing.Size(499, 21);
            this.AddLoc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Selected Files :";
            // 
            // AddPro
            // 
            this.AddPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddPro.FormattingEnabled = true;
            this.AddPro.Location = new System.Drawing.Point(127, 177);
            this.AddPro.Name = "AddPro";
            this.AddPro.Size = new System.Drawing.Size(499, 21);
            this.AddPro.TabIndex = 3;
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
            this.Cancel.TabIndex = 7;
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
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
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
            // Add_Testemonial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SelectedFiles);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddPro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddLoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddLocN);
            this.Controls.Add(this.AddIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Testemonial";
            this.Text = "Add Testemonial";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFiles)).EndInit();
            this.RowMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker AddDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox AddLocN;
        private System.Windows.Forms.TextBox AddIN;
        private System.Windows.Forms.OpenFileDialog Browse_File_Wind;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView SelectedFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AddLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddPro;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileN;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.ContextMenuStrip RowMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
    }
}