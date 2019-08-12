namespace Apex
{
    partial class Correspondence_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correspondence_Form));
            this.SearchP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SearchN = new System.Windows.Forms.TextBox();
            this.Correspondence_Grid = new System.Windows.Forms.DataGridView();
            this.SR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchD = new System.Windows.Forms.DateTimePicker();
            this.DisableDate = new System.Windows.Forms.CheckBox();
            this.OnlyS = new System.Windows.Forms.CheckBox();
            this.OnlyR = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SFileN = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.View_Info = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Correspondence_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchP
            // 
            this.SearchP.BackColor = System.Drawing.Color.White;
            this.SearchP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchP.Location = new System.Drawing.Point(162, 42);
            this.SearchP.Name = "SearchP";
            this.SearchP.Size = new System.Drawing.Size(978, 21);
            this.SearchP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "File Path : ";
            // 
            // SearchS
            // 
            this.SearchS.BackColor = System.Drawing.Color.White;
            this.SearchS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchS.Location = new System.Drawing.Point(162, 75);
            this.SearchS.Name = "SearchS";
            this.SearchS.Size = new System.Drawing.Size(978, 21);
            this.SearchS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Subject : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sender/Receiver Name : ";
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
            this.SearchN.Location = new System.Drawing.Point(162, 108);
            this.SearchN.Name = "SearchN";
            this.SearchN.Size = new System.Drawing.Size(978, 21);
            this.SearchN.TabIndex = 3;
            // 
            // Correspondence_Grid
            // 
            this.Correspondence_Grid.AllowUserToAddRows = false;
            this.Correspondence_Grid.AllowUserToDeleteRows = false;
            this.Correspondence_Grid.AllowUserToResizeColumns = false;
            this.Correspondence_Grid.AllowUserToResizeRows = false;
            this.Correspondence_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Correspondence_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Correspondence_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SR,
            this.FileN,
            this.SRName,
            this.Subj,
            this.Date,
            this.Path,
            this.Extension});
            this.Correspondence_Grid.Location = new System.Drawing.Point(12, 229);
            this.Correspondence_Grid.Name = "Correspondence_Grid";
            this.Correspondence_Grid.ReadOnly = true;
            this.Correspondence_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Correspondence_Grid.Size = new System.Drawing.Size(1128, 453);
            this.Correspondence_Grid.TabIndex = 13;
            this.Correspondence_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Correspondence_Grid_CellDoubleClick);
            // 
            // SR
            // 
            this.SR.DataPropertyName = "SR";
            this.SR.FillWeight = 44.79263F;
            this.SR.HeaderText = "Sent /Received";
            this.SR.Name = "SR";
            this.SR.ReadOnly = true;
            this.SR.Width = 81;
            // 
            // FileN
            // 
            this.FileN.DataPropertyName = "FileN";
            this.FileN.FillWeight = 107.8605F;
            this.FileN.HeaderText = "File Name";
            this.FileN.Name = "FileN";
            this.FileN.ReadOnly = true;
            this.FileN.Width = 195;
            // 
            // SRName
            // 
            this.SRName.DataPropertyName = "SRName";
            this.SRName.FillWeight = 124.8518F;
            this.SRName.HeaderText = "Sender/Receiver";
            this.SRName.Name = "SRName";
            this.SRName.ReadOnly = true;
            this.SRName.Width = 226;
            // 
            // Subj
            // 
            this.Subj.DataPropertyName = "Subj";
            this.Subj.FillWeight = 151.7395F;
            this.Subj.HeaderText = "Subject";
            this.Subj.Name = "Subj";
            this.Subj.ReadOnly = true;
            this.Subj.Width = 274;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 60.71302F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 110;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.FillWeight = 110.0426F;
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 199;
            // 
            // Extension
            // 
            this.Extension.DataPropertyName = "Extension";
            this.Extension.HeaderText = "Extension";
            this.Extension.Name = "Extension";
            this.Extension.ReadOnly = true;
            this.Extension.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date : ";
            // 
            // SearchD
            // 
            this.SearchD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchD.CalendarMonthBackground = System.Drawing.Color.White;
            this.SearchD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SearchD.Location = new System.Drawing.Point(162, 141);
            this.SearchD.Name = "SearchD";
            this.SearchD.Size = new System.Drawing.Size(102, 21);
            this.SearchD.TabIndex = 4;
            // 
            // DisableDate
            // 
            this.DisableDate.AutoSize = true;
            this.DisableDate.Checked = true;
            this.DisableDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableDate.Location = new System.Drawing.Point(270, 143);
            this.DisableDate.Name = "DisableDate";
            this.DisableDate.Size = new System.Drawing.Size(97, 19);
            this.DisableDate.TabIndex = 5;
            this.DisableDate.Text = "Disable Date";
            this.DisableDate.UseVisualStyleBackColor = true;
            // 
            // OnlyS
            // 
            this.OnlyS.AutoSize = true;
            this.OnlyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyS.Location = new System.Drawing.Point(1006, 143);
            this.OnlyS.Name = "OnlyS";
            this.OnlyS.Size = new System.Drawing.Size(51, 19);
            this.OnlyS.TabIndex = 6;
            this.OnlyS.Text = "Sent";
            this.OnlyS.UseVisualStyleBackColor = true;
            // 
            // OnlyR
            // 
            this.OnlyR.AutoSize = true;
            this.OnlyR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyR.Location = new System.Drawing.Point(1063, 143);
            this.OnlyR.Name = "OnlyR";
            this.OnlyR.Size = new System.Drawing.Size(77, 19);
            this.OnlyR.TabIndex = 7;
            this.OnlyR.Text = "Received";
            this.OnlyR.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "File Name : ";
            // 
            // SFileN
            // 
            this.SFileN.BackColor = System.Drawing.Color.White;
            this.SFileN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFileN.Location = new System.Drawing.Point(162, 9);
            this.SFileN.Name = "SFileN";
            this.SFileN.Size = new System.Drawing.Size(978, 21);
            this.SFileN.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.ImageIndex = 2;
            this.Edit.ImageList = this.imageList1;
            this.Edit.Location = new System.Drawing.Point(148, 179);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 44);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // View_Info
            // 
            this.View_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.View_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.View_Info.ImageIndex = 4;
            this.View_Info.ImageList = this.imageList1;
            this.View_Info.Location = new System.Drawing.Point(874, 179);
            this.View_Info.Name = "View_Info";
            this.View_Info.Size = new System.Drawing.Size(130, 44);
            this.View_Info.TabIndex = 12;
            this.View_Info.Text = "View";
            this.View_Info.UseVisualStyleBackColor = true;
            this.View_Info.Click += new System.EventHandler(this.View_Info_Click);
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.ImageIndex = 0;
            this.Delete.ImageList = this.imageList1;
            this.Delete.Location = new System.Drawing.Point(284, 179);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 44);
            this.Delete.TabIndex = 10;
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
            this.Add.Location = new System.Drawing.Point(12, 179);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 44);
            this.Add.TabIndex = 8;
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
            this.Search.Location = new System.Drawing.Point(738, 179);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(130, 44);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.ImageIndex = 9;
            this.Clear.ImageList = this.imageList1;
            this.Clear.Location = new System.Drawing.Point(1010, 179);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(130, 44);
            this.Clear.TabIndex = 32;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            this.Clear.MouseHover += new System.EventHandler(this.Clear_MouseHover);
            // 
            // Correspondence_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 694);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SFileN);
            this.Controls.Add(this.OnlyR);
            this.Controls.Add(this.OnlyS);
            this.Controls.Add(this.DisableDate);
            this.Controls.Add(this.SearchD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.View_Info);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SearchN);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Correspondence_Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Correspondence_Form";
            this.Text = "Correspondence";
            ((System.ComponentModel.ISupportInitialize)(this.Correspondence_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button View_Info;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox SearchN;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView Correspondence_Grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker SearchD;
        private System.Windows.Forms.CheckBox DisableDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox OnlyS;
        private System.Windows.Forms.CheckBox OnlyR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SFileN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SR;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.Button Clear;
    }
}