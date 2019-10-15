namespace Apex
{
    partial class SetupServer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupServer_Form));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.DataDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.DatabaseN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerN = new System.Windows.Forms.TextBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.Testemonial_RUP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Expenses_RUP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Testemonial_FUP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Expenses_FUP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "-Login with an account that has admin permissions.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "-Choose where your files will be stored.";
            // 
            // Browse
            // 
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browse.ImageIndex = 7;
            this.Browse.ImageList = this.imageList1;
            this.Browse.Location = new System.Drawing.Point(812, 260);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(130, 44);
            this.Browse.TabIndex = 36;
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
            this.imageList1.Images.SetKeyName(10, "login.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data Directory : ";
            // 
            // DataDirectory
            // 
            this.DataDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDirectory.Location = new System.Drawing.Point(121, 233);
            this.DataDirectory.Name = "DataDirectory";
            this.DataDirectory.Size = new System.Drawing.Size(821, 21);
            this.DataDirectory.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password : ";
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Done.ImageIndex = 8;
            this.Done.ImageList = this.imageList1;
            this.Done.Location = new System.Drawing.Point(676, 502);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(130, 44);
            this.Done.TabIndex = 30;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(121, 109);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(821, 21);
            this.Password.TabIndex = 21;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Cancel2
            // 
            this.Cancel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel2.ImageIndex = 6;
            this.Cancel2.ImageList = this.imageList1;
            this.Cancel2.Location = new System.Drawing.Point(812, 502);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(130, 44);
            this.Cancel2.TabIndex = 31;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = true;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Database Name : ";
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(121, 62);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(821, 21);
            this.UserName.TabIndex = 20;
            // 
            // DatabaseN
            // 
            this.DatabaseN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseN.Location = new System.Drawing.Point(121, 156);
            this.DatabaseN.Name = "DatabaseN";
            this.DatabaseN.Size = new System.Drawing.Size(821, 21);
            this.DatabaseN.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Server Name : ";
            // 
            // ServerN
            // 
            this.ServerN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerN.Location = new System.Drawing.Point(121, 15);
            this.ServerN.Name = "ServerN";
            this.ServerN.Size = new System.Drawing.Size(821, 21);
            this.ServerN.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Testemonial Read Only User Password : ";
            // 
            // Testemonial_RUP
            // 
            this.Testemonial_RUP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Testemonial_RUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testemonial_RUP.Location = new System.Drawing.Point(253, 349);
            this.Testemonial_RUP.Name = "Testemonial_RUP";
            this.Testemonial_RUP.Size = new System.Drawing.Size(689, 21);
            this.Testemonial_RUP.TabIndex = 39;
            this.Testemonial_RUP.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Expenses Read Only User Password :";
            // 
            // Expenses_RUP
            // 
            this.Expenses_RUP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Expenses_RUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_RUP.Location = new System.Drawing.Point(253, 416);
            this.Expenses_RUP.Name = "Expenses_RUP";
            this.Expenses_RUP.Size = new System.Drawing.Size(689, 21);
            this.Expenses_RUP.TabIndex = 41;
            this.Expenses_RUP.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "Testemonial Full Control User Password : ";
            // 
            // Testemonial_FUP
            // 
            this.Testemonial_FUP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Testemonial_FUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testemonial_FUP.Location = new System.Drawing.Point(253, 373);
            this.Testemonial_FUP.Name = "Testemonial_FUP";
            this.Testemonial_FUP.Size = new System.Drawing.Size(689, 21);
            this.Testemonial_FUP.TabIndex = 43;
            this.Testemonial_FUP.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Expenses Full Control User Password :";
            // 
            // Expenses_FUP
            // 
            this.Expenses_FUP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Expenses_FUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses_FUP.Location = new System.Drawing.Point(253, 440);
            this.Expenses_FUP.Name = "Expenses_FUP";
            this.Expenses_FUP.Size = new System.Drawing.Size(689, 21);
            this.Expenses_FUP.TabIndex = 45;
            this.Expenses_FUP.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 464);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(367, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "-Write passwords for different user permissions for every module";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 8;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(412, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 48;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetupServer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 558);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Testemonial_RUP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Expenses_RUP);
            this.Controls.Add(this.Cancel2);
            this.Controls.Add(this.Expenses_FUP);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ServerN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Testemonial_FUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataDirectory);
            this.Controls.Add(this.DatabaseN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupServer_Form";
            this.Text = "Setup Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerN;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button Cancel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DatabaseN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DataDirectory;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Testemonial_RUP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Expenses_RUP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Testemonial_FUP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Expenses_FUP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}