namespace Apex
{
    partial class Media_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media_Form));
            this.Search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SearchN = new System.Windows.Forms.TextBox();
            this.Media_Grid = new System.Windows.Forms.DataGridView();
            this.MediaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.View_Info = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DisableDate = new System.Windows.Forms.CheckBox();
            this.SearchD = new System.Windows.Forms.DateTimePicker();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.ImageIndex = 3;
            this.Search.ImageList = this.imageList1;
            this.Search.Location = new System.Drawing.Point(506, 119);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(130, 44);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
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
            // SearchN
            // 
            this.SearchN.BackColor = System.Drawing.Color.White;
            this.SearchN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchN.Location = new System.Drawing.Point(111, 15);
            this.SearchN.Name = "SearchN";
            this.SearchN.Size = new System.Drawing.Size(797, 21);
            this.SearchN.TabIndex = 0;
            // 
            // Media_Grid
            // 
            this.Media_Grid.AllowUserToAddRows = false;
            this.Media_Grid.AllowUserToDeleteRows = false;
            this.Media_Grid.AllowUserToResizeColumns = false;
            this.Media_Grid.AllowUserToResizeRows = false;
            this.Media_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Media_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Media_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MediaN,
            this.Path,
            this.Date,
            this.Extension});
            this.Media_Grid.Location = new System.Drawing.Point(12, 169);
            this.Media_Grid.Name = "Media_Grid";
            this.Media_Grid.ReadOnly = true;
            this.Media_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Media_Grid.Size = new System.Drawing.Size(896, 500);
            this.Media_Grid.TabIndex = 9;
            this.Media_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Images_Grid_CellDoubleClick);
            // 
            // MediaN
            // 
            this.MediaN.DataPropertyName = "MediaN";
            this.MediaN.FillWeight = 86.0406F;
            this.MediaN.HeaderText = "Name";
            this.MediaN.Name = "MediaN";
            this.MediaN.ReadOnly = true;
            this.MediaN.Width = 245;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.FillWeight = 86.0406F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 444;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 127.9188F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 164;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Visible = false;
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.ImageIndex = 5;
            this.Add.ImageList = this.imageList1;
            this.Add.Location = new System.Drawing.Point(12, 119);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 44);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.ImageIndex = 0;
            this.Delete.ImageList = this.imageList1;
            this.Delete.Location = new System.Drawing.Point(284, 119);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 44);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // View_Info
            // 
            this.View_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.View_Info.ImageIndex = 4;
            this.View_Info.ImageList = this.imageList1;
            this.View_Info.Location = new System.Drawing.Point(642, 119);
            this.View_Info.Name = "View_Info";
            this.View_Info.Size = new System.Drawing.Size(130, 44);
            this.View_Info.TabIndex = 8;
            this.View_Info.Text = "View";
            this.View_Info.UseVisualStyleBackColor = true;
            this.View_Info.Click += new System.EventHandler(this.View_Info_Click);
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.ImageIndex = 2;
            this.Edit.ImageList = this.imageList1;
            this.Edit.Location = new System.Drawing.Point(148, 119);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 44);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "File Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Path : ";
            // 
            // SearchP
            // 
            this.SearchP.BackColor = System.Drawing.Color.White;
            this.SearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchP.Location = new System.Drawing.Point(111, 48);
            this.SearchP.Name = "SearchP";
            this.SearchP.Size = new System.Drawing.Size(797, 21);
            this.SearchP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date : ";
            // 
            // DisableDate
            // 
            this.DisableDate.AutoSize = true;
            this.DisableDate.Checked = true;
            this.DisableDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableDate.Location = new System.Drawing.Point(219, 83);
            this.DisableDate.Name = "DisableDate";
            this.DisableDate.Size = new System.Drawing.Size(97, 19);
            this.DisableDate.TabIndex = 3;
            this.DisableDate.Text = "Disable Date";
            this.DisableDate.UseVisualStyleBackColor = true;
            // 
            // SearchD
            // 
            this.SearchD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchD.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchD.Location = new System.Drawing.Point(111, 81);
            this.SearchD.Name = "SearchD";
            this.SearchD.Size = new System.Drawing.Size(102, 21);
            this.SearchD.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.ImageIndex = 9;
            this.Clear.ImageList = this.imageList1;
            this.Clear.Location = new System.Drawing.Point(778, 119);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(130, 44);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            this.Clear.MouseHover += new System.EventHandler(this.Clear_MouseHover);
            // 
            // Media_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 681);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DisableDate);
            this.Controls.Add(this.SearchD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.View_Info);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SearchN);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Media_Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Media_Form";
            this.Text = "Media";
            this.Load += new System.EventHandler(this.Media_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchN;
        private System.Windows.Forms.DataGridView Media_Grid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button View_Info;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox DisableDate;
        private System.Windows.Forms.DateTimePicker SearchD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.Button Clear;
    }
}