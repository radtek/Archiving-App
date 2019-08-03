namespace PrototypeApp
{
    partial class View_Media
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.File_Desc = new System.Windows.Forms.TextBox();
            this.File_Name = new System.Windows.Forms.Label();
            this.File_Path = new System.Windows.Forms.Label();
            this.File_Extension = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Path : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Extension : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description : ";
            // 
            // File_Desc
            // 
            this.File_Desc.Location = new System.Drawing.Point(15, 167);
            this.File_Desc.Multiline = true;
            this.File_Desc.Name = "File_Desc";
            this.File_Desc.ReadOnly = true;
            this.File_Desc.Size = new System.Drawing.Size(773, 285);
            this.File_Desc.TabIndex = 4;
            // 
            // File_Name
            // 
            this.File_Name.AutoSize = true;
            this.File_Name.Location = new System.Drawing.Point(81, 34);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(0, 13);
            this.File_Name.TabIndex = 5;
            // 
            // File_Path
            // 
            this.File_Path.AutoSize = true;
            this.File_Path.Location = new System.Drawing.Point(75, 73);
            this.File_Path.Name = "File_Path";
            this.File_Path.Size = new System.Drawing.Size(0, 13);
            this.File_Path.TabIndex = 6;
            // 
            // File_Extension
            // 
            this.File_Extension.AutoSize = true;
            this.File_Extension.Location = new System.Drawing.Point(99, 112);
            this.File_Extension.Name = "File_Extension";
            this.File_Extension.Size = new System.Drawing.Size(0, 13);
            this.File_Extension.TabIndex = 7;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(670, 458);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(118, 23);
            this.Close.TabIndex = 8;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // View_Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.File_Extension);
            this.Controls.Add(this.File_Path);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.File_Desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "View_Media";
            this.Text = "View_Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox File_Desc;
        private System.Windows.Forms.Label File_Name;
        private System.Windows.Forms.Label File_Path;
        private System.Windows.Forms.Label File_Extension;
        private System.Windows.Forms.Button Close;
    }
}