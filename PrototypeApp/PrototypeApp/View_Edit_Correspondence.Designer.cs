namespace Apex
{
    partial class View_Edit_Correspondence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Edit_Correspondence));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Cancel = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.New_Name = new System.Windows.Forms.TextBox();
            this.New_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.New_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.New_SRName = new System.Windows.Forms.TextBox();
            this.New_SR = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.File_Name = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.Label();
            this.File_Path = new System.Windows.Forms.Label();
            this.SRName = new System.Windows.Forms.Label();
            this.File_Date = new System.Windows.Forms.Label();
            this.SR = new System.Windows.Forms.Label();
            this.File_Extension = new System.Windows.Forms.Label();
            this.New_Extension = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
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
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.ImageIndex = 6;
            this.Cancel.ImageList = this.imageList1;
            this.Cancel.Location = new System.Drawing.Point(148, 383);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 44);
            this.Cancel.TabIndex = 30;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Done
            // 
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Done.ImageIndex = 8;
            this.Done.ImageList = this.imageList1;
            this.Done.Location = new System.Drawing.Point(12, 383);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(130, 44);
            this.Done.TabIndex = 29;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Visible = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.ImageIndex = 9;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(545, 383);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(130, 44);
            this.Close.TabIndex = 28;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "File Name : ";
            // 
            // New_Name
            // 
            this.New_Name.BackColor = System.Drawing.Color.White;
            this.New_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Name.Location = new System.Drawing.Point(162, 15);
            this.New_Name.Name = "New_Name";
            this.New_Name.Size = new System.Drawing.Size(513, 21);
            this.New_Name.TabIndex = 32;
            this.New_Name.Visible = false;
            // 
            // New_Date
            // 
            this.New_Date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Date.CalendarMonthBackground = System.Drawing.Color.White;
            this.New_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.New_Date.Location = new System.Drawing.Point(162, 260);
            this.New_Date.Name = "New_Date";
            this.New_Date.Size = new System.Drawing.Size(102, 21);
            this.New_Date.TabIndex = 36;
            this.New_Date.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date : ";
            // 
            // New_Path
            // 
            this.New_Path.BackColor = System.Drawing.Color.White;
            this.New_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Path.Location = new System.Drawing.Point(162, 64);
            this.New_Path.Name = "New_Path";
            this.New_Path.Size = new System.Drawing.Size(513, 21);
            this.New_Path.TabIndex = 33;
            this.New_Path.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "File Path : ";
            // 
            // New_Subject
            // 
            this.New_Subject.BackColor = System.Drawing.Color.White;
            this.New_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Subject.Location = new System.Drawing.Point(162, 162);
            this.New_Subject.Name = "New_Subject";
            this.New_Subject.Size = new System.Drawing.Size(513, 21);
            this.New_Subject.TabIndex = 34;
            this.New_Subject.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Subject : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sender/Receiver Name : ";
            // 
            // New_SRName
            // 
            this.New_SRName.BackColor = System.Drawing.Color.White;
            this.New_SRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_SRName.Location = new System.Drawing.Point(162, 211);
            this.New_SRName.Name = "New_SRName";
            this.New_SRName.Size = new System.Drawing.Size(513, 21);
            this.New_SRName.TabIndex = 35;
            this.New_SRName.Visible = false;
            // 
            // New_SR
            // 
            this.New_SR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_SR.FormattingEnabled = true;
            this.New_SR.Items.AddRange(new object[] {
            "Sent",
            "Received"});
            this.New_SR.Location = new System.Drawing.Point(162, 309);
            this.New_SR.Name = "New_SR";
            this.New_SR.Size = new System.Drawing.Size(102, 23);
            this.New_SR.TabIndex = 42;
            this.New_SR.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Sent/Received : ";
            // 
            // File_Name
            // 
            this.File_Name.AutoSize = true;
            this.File_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Name.Location = new System.Drawing.Point(162, 18);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(0, 15);
            this.File_Name.TabIndex = 44;
            // 
            // Subject
            // 
            this.Subject.AutoSize = true;
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(162, 165);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(0, 15);
            this.Subject.TabIndex = 45;
            // 
            // File_Path
            // 
            this.File_Path.AutoSize = true;
            this.File_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Path.Location = new System.Drawing.Point(162, 67);
            this.File_Path.Name = "File_Path";
            this.File_Path.Size = new System.Drawing.Size(0, 15);
            this.File_Path.TabIndex = 46;
            // 
            // SRName
            // 
            this.SRName.AutoSize = true;
            this.SRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRName.Location = new System.Drawing.Point(162, 214);
            this.SRName.Name = "SRName";
            this.SRName.Size = new System.Drawing.Size(0, 15);
            this.SRName.TabIndex = 47;
            // 
            // File_Date
            // 
            this.File_Date.AutoSize = true;
            this.File_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Date.Location = new System.Drawing.Point(162, 263);
            this.File_Date.Name = "File_Date";
            this.File_Date.Size = new System.Drawing.Size(0, 15);
            this.File_Date.TabIndex = 48;
            // 
            // SR
            // 
            this.SR.AutoSize = true;
            this.SR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SR.Location = new System.Drawing.Point(162, 312);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(0, 15);
            this.SR.TabIndex = 49;
            // 
            // File_Extension
            // 
            this.File_Extension.AutoSize = true;
            this.File_Extension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File_Extension.Location = new System.Drawing.Point(162, 116);
            this.File_Extension.Name = "File_Extension";
            this.File_Extension.Size = new System.Drawing.Size(0, 15);
            this.File_Extension.TabIndex = 52;
            // 
            // New_Extension
            // 
            this.New_Extension.BackColor = System.Drawing.Color.White;
            this.New_Extension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Extension.Location = new System.Drawing.Point(162, 113);
            this.New_Extension.Name = "New_Extension";
            this.New_Extension.Size = new System.Drawing.Size(513, 21);
            this.New_Extension.TabIndex = 50;
            this.New_Extension.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 116);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 15);
            this.label.TabIndex = 51;
            this.label.Text = "File Extension : ";
            // 
            // Edit
            // 
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.ImageIndex = 2;
            this.Edit.ImageList = this.imageList1;
            this.Edit.Location = new System.Drawing.Point(12, 383);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(130, 44);
            this.Edit.TabIndex = 53;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // View_Edit_Correspondence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 439);
            this.Controls.Add(this.New_Extension);
            this.Controls.Add(this.New_SR);
            this.Controls.Add(this.New_Name);
            this.Controls.Add(this.New_Date);
            this.Controls.Add(this.New_Path);
            this.Controls.Add(this.New_Subject);
            this.Controls.Add(this.New_SRName);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.File_Extension);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SR);
            this.Controls.Add(this.File_Date);
            this.Controls.Add(this.SRName);
            this.Controls.Add(this.File_Path);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View_Edit_Correspondence";
            this.Text = "File Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox New_Name;
        private System.Windows.Forms.DateTimePicker New_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox New_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox New_Subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox New_SRName;
        private System.Windows.Forms.ComboBox New_SR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label File_Name;
        private System.Windows.Forms.Label Subject;
        private System.Windows.Forms.Label File_Path;
        private System.Windows.Forms.Label SRName;
        private System.Windows.Forms.Label File_Date;
        private System.Windows.Forms.Label SR;
        private System.Windows.Forms.Label File_Extension;
        private System.Windows.Forms.TextBox New_Extension;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Edit;
    }
}