namespace PrototypeApp
{
    partial class Add_Media
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
            this.File_Name = new System.Windows.Forms.TextBox();
            this.File_Path = new System.Windows.Forms.TextBox();
            this.File_Desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.File_Extension = new System.Windows.Forms.TextBox();
            this.Browse_File_Wind = new System.Windows.Forms.OpenFileDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // File_Name
            // 
            this.File_Name.Location = new System.Drawing.Point(78, 27);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(488, 20);
            this.File_Name.TabIndex = 0;
            // 
            // File_Path
            // 
            this.File_Path.Location = new System.Drawing.Point(75, 74);
            this.File_Path.Name = "File_Path";
            this.File_Path.Size = new System.Drawing.Size(491, 20);
            this.File_Path.TabIndex = 1;
            // 
            // File_Desc
            // 
            this.File_Desc.Location = new System.Drawing.Point(15, 193);
            this.File_Desc.Multiline = true;
            this.File_Desc.Name = "File_Desc";
            this.File_Desc.Size = new System.Drawing.Size(551, 199);
            this.File_Desc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Path : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "File Extension : ";
            // 
            // File_Extension
            // 
            this.File_Extension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.File_Extension.Location = new System.Drawing.Point(99, 121);
            this.File_Extension.Name = "File_Extension";
            this.File_Extension.Size = new System.Drawing.Size(467, 20);
            this.File_Extension.TabIndex = 7;
            // 
            // Browse_File_Wind
            // 
            this.Browse_File_Wind.FileName = "Browse_File_Wind";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(458, 147);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(108, 23);
            this.Browse.TabIndex = 8;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(15, 398);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(108, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(129, 398);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(108, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Add_Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 427);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.File_Extension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.File_Desc);
            this.Controls.Add(this.File_Path);
            this.Controls.Add(this.File_Name);
            this.Name = "Add_Media";
            this.Text = "Add_Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox File_Name;
        private System.Windows.Forms.TextBox File_Path;
        private System.Windows.Forms.TextBox File_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox File_Extension;
        private System.Windows.Forms.OpenFileDialog Browse_File_Wind;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}