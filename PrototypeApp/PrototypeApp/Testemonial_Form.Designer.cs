namespace Apex
{
    partial class Testemonial_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testemonial_Form));
            this.DisableDate = new System.Windows.Forms.CheckBox();
            this.SearchD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchLoc = new System.Windows.Forms.ComboBox();
            this.SearchPro = new System.Windows.Forms.ComboBox();
            this.SearchIN = new System.Windows.Forms.TextBox();
            this.Testemonial_Grid = new System.Windows.Forms.DataGridView();
            this.Clear = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Edit = new System.Windows.Forms.Button();
            this.View_Info = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchLocN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchEx = new System.Windows.Forms.TextBox();
            this.InterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Testemonial_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // DisableDate
            // 
            this.DisableDate.AutoSize = true;
            this.DisableDate.Checked = true;
            this.DisableDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableDate.Location = new System.Drawing.Point(238, 182);
            this.DisableDate.Name = "DisableDate";
            this.DisableDate.Size = new System.Drawing.Size(97, 19);
            this.DisableDate.TabIndex = 14;
            this.DisableDate.Text = "Disable Date";
            this.DisableDate.UseVisualStyleBackColor = true;
            // 
            // SearchD
            // 
            this.SearchD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchD.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchD.Location = new System.Drawing.Point(127, 180);
            this.SearchD.Name = "SearchD";
            this.SearchD.Size = new System.Drawing.Size(105, 21);
            this.SearchD.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date : ";
            // 
            // SearchP
            // 
            this.SearchP.BackColor = System.Drawing.Color.White;
            this.SearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchP.Location = new System.Drawing.Point(127, 48);
            this.SearchP.Name = "SearchP";
            this.SearchP.Size = new System.Drawing.Size(826, 21);
            this.SearchP.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "File Path : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "File Name : ";
            // 
            // SearchN
            // 
            this.SearchN.BackColor = System.Drawing.Color.White;
            this.SearchN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchN.Location = new System.Drawing.Point(127, 15);
            this.SearchN.Name = "SearchN";
            this.SearchN.Size = new System.Drawing.Size(1109, 21);
            this.SearchN.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Interpreter Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Location : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Profession : ";
            // 
            // SearchLoc
            // 
            this.SearchLoc.BackColor = System.Drawing.Color.White;
            this.SearchLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchLoc.FormattingEnabled = true;
            this.SearchLoc.Items.AddRange(new object[] {
            "School",
            "Governorate",
            "Youth Center",
            "-Disable-"});
            this.SearchLoc.Location = new System.Drawing.Point(127, 114);
            this.SearchLoc.Name = "SearchLoc";
            this.SearchLoc.Size = new System.Drawing.Size(271, 21);
            this.SearchLoc.TabIndex = 22;
            this.SearchLoc.SelectedIndexChanged += new System.EventHandler(this.SearchLoc_SelectedIndexChanged);
            // 
            // SearchPro
            // 
            this.SearchPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchPro.FormattingEnabled = true;
            this.SearchPro.Items.AddRange(new object[] {
            "Student",
            "Parent",
            "-Disable-"});
            this.SearchPro.Location = new System.Drawing.Point(127, 147);
            this.SearchPro.Name = "SearchPro";
            this.SearchPro.Size = new System.Drawing.Size(271, 21);
            this.SearchPro.TabIndex = 23;
            // 
            // SearchIN
            // 
            this.SearchIN.BackColor = System.Drawing.Color.White;
            this.SearchIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIN.Location = new System.Drawing.Point(127, 81);
            this.SearchIN.Name = "SearchIN";
            this.SearchIN.Size = new System.Drawing.Size(1109, 21);
            this.SearchIN.TabIndex = 24;
            // 
            // Testemonial_Grid
            // 
            this.Testemonial_Grid.AllowUserToAddRows = false;
            this.Testemonial_Grid.AllowUserToDeleteRows = false;
            this.Testemonial_Grid.AllowUserToResizeRows = false;
            this.Testemonial_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Testemonial_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Testemonial_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterName,
            this.Loc,
            this.LocN,
            this.Profession,
            this.TestN,
            this.Path,
            this.Extension,
            this.Date});
            this.Testemonial_Grid.GridColor = System.Drawing.Color.White;
            this.Testemonial_Grid.Location = new System.Drawing.Point(12, 272);
            this.Testemonial_Grid.Name = "Testemonial_Grid";
            this.Testemonial_Grid.ReadOnly = true;
            this.Testemonial_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Testemonial_Grid.Size = new System.Drawing.Size(1224, 347);
            this.Testemonial_Grid.TabIndex = 25;
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.ImageIndex = 9;
            this.Clear.ImageList = this.imageList1;
            this.Clear.Location = new System.Drawing.Point(1106, 222);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(130, 44);
            this.Clear.TabIndex = 31;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
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
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.ImageIndex = 2;
            this.Edit.ImageList = this.imageList1;
            this.Edit.Location = new System.Drawing.Point(148, 222);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 44);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // View_Info
            // 
            this.View_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.View_Info.ImageIndex = 4;
            this.View_Info.ImageList = this.imageList1;
            this.View_Info.Location = new System.Drawing.Point(970, 222);
            this.View_Info.Name = "View_Info";
            this.View_Info.Size = new System.Drawing.Size(130, 44);
            this.View_Info.TabIndex = 30;
            this.View_Info.Text = "View";
            this.View_Info.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.ImageIndex = 0;
            this.Delete.ImageList = this.imageList1;
            this.Delete.Location = new System.Drawing.Point(284, 222);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 44);
            this.Delete.TabIndex = 28;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.ImageIndex = 5;
            this.Add.ImageList = this.imageList1;
            this.Add.Location = new System.Drawing.Point(12, 222);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 44);
            this.Add.TabIndex = 26;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.ImageIndex = 3;
            this.Search.ImageList = this.imageList1;
            this.Search.Location = new System.Drawing.Point(834, 222);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(130, 44);
            this.Search.TabIndex = 29;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Powered by : Polygon Network Company";
            // 
            // SearchLocN
            // 
            this.SearchLocN.BackColor = System.Drawing.Color.White;
            this.SearchLocN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLocN.Location = new System.Drawing.Point(510, 114);
            this.SearchLocN.Name = "SearchLocN";
            this.SearchLocN.Size = new System.Drawing.Size(726, 21);
            this.SearchLocN.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(404, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 34;
            this.label8.Text = "Location Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(959, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 35;
            this.label9.Text = "File Extension : ";
            // 
            // SearchEx
            // 
            this.SearchEx.BackColor = System.Drawing.Color.White;
            this.SearchEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEx.Location = new System.Drawing.Point(1058, 48);
            this.SearchEx.Name = "SearchEx";
            this.SearchEx.Size = new System.Drawing.Size(178, 21);
            this.SearchEx.TabIndex = 36;
            // 
            // InterName
            // 
            this.InterName.DataPropertyName = "InterName";
            this.InterName.HeaderText = "Interpreter Name";
            this.InterName.Name = "InterName";
            this.InterName.ReadOnly = true;
            this.InterName.Width = 148;
            // 
            // Loc
            // 
            this.Loc.DataPropertyName = "Loc";
            this.Loc.HeaderText = "Location";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Width = 147;
            // 
            // LocN
            // 
            this.LocN.DataPropertyName = "LocN";
            this.LocN.HeaderText = "Location Name";
            this.LocN.Name = "LocN";
            this.LocN.ReadOnly = true;
            this.LocN.Width = 148;
            // 
            // Profession
            // 
            this.Profession.DataPropertyName = "Profession";
            this.Profession.HeaderText = "Profession";
            this.Profession.Name = "Profession";
            this.Profession.ReadOnly = true;
            this.Profession.Width = 147;
            // 
            // TestN
            // 
            this.TestN.DataPropertyName = "TestN";
            this.TestN.FillWeight = 86.0406F;
            this.TestN.HeaderText = "File Name";
            this.TestN.Name = "TestN";
            this.TestN.ReadOnly = true;
            this.TestN.Width = 147;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.FillWeight = 86.0406F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 228;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Width = 108;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 127.9188F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 108;
            // 
            // Testemonial_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 646);
            this.Controls.Add(this.SearchEx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchLocN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.View_Info);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Testemonial_Grid);
            this.Controls.Add(this.SearchIN);
            this.Controls.Add(this.SearchPro);
            this.Controls.Add(this.SearchLoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DisableDate);
            this.Controls.Add(this.SearchD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Testemonial_Form";
            this.Text = "Testemonial";
            ((System.ComponentModel.ISupportInitialize)(this.Testemonial_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DisableDate;
        private System.Windows.Forms.DateTimePicker SearchD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SearchLoc;
        private System.Windows.Forms.ComboBox SearchPro;
        private System.Windows.Forms.TextBox SearchIN;
        private System.Windows.Forms.DataGridView Testemonial_Grid;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button View_Info;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchLocN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}