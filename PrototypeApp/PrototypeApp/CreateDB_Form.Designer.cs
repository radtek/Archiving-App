namespace Apex
{
    partial class CreateDB_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDB_Form));
            this.CreateDBP = new System.Windows.Forms.Panel();
            this.LoginP = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerN = new System.Windows.Forms.TextBox();
            this.Notice = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Login = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DatabaseN = new System.Windows.Forms.TextBox();
            this.Process = new System.Windows.Forms.Label();
            this.Bar = new System.Windows.Forms.ProgressBar();
            this.CreateDBP.SuspendLayout();
            this.LoginP.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateDBP
            // 
            this.CreateDBP.Controls.Add(this.Process);
            this.CreateDBP.Controls.Add(this.Bar);
            this.CreateDBP.Controls.Add(this.Create);
            this.CreateDBP.Controls.Add(this.Cancel2);
            this.CreateDBP.Controls.Add(this.label2);
            this.CreateDBP.Controls.Add(this.DatabaseN);
            this.CreateDBP.Location = new System.Drawing.Point(12, 12);
            this.CreateDBP.Name = "CreateDBP";
            this.CreateDBP.Size = new System.Drawing.Size(555, 260);
            this.CreateDBP.TabIndex = 0;
            // 
            // LoginP
            // 
            this.LoginP.Controls.Add(this.Login);
            this.LoginP.Controls.Add(this.Notice);
            this.LoginP.Controls.Add(this.label4);
            this.LoginP.Controls.Add(this.Password);
            this.LoginP.Controls.Add(this.label3);
            this.LoginP.Controls.Add(this.UserName);
            this.LoginP.Controls.Add(this.label1);
            this.LoginP.Controls.Add(this.ServerN);
            this.LoginP.Controls.Add(this.Cancel);
            this.LoginP.Location = new System.Drawing.Point(12, 12);
            this.LoginP.Name = "LoginP";
            this.LoginP.Size = new System.Drawing.Size(555, 260);
            this.LoginP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password : ";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(94, 100);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(461, 21);
            this.Password.TabIndex = 21;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username : ";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(94, 53);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(461, 21);
            this.UserName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Server Name : ";
            // 
            // ServerN
            // 
            this.ServerN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerN.Location = new System.Drawing.Point(94, 6);
            this.ServerN.Name = "ServerN";
            this.ServerN.Size = new System.Drawing.Size(461, 21);
            this.ServerN.TabIndex = 19;
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notice.Location = new System.Drawing.Point(0, 160);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(358, 30);
            this.Notice.TabIndex = 25;
            this.Notice.Text = "Notice :\r\nLogin in with an account that has permission to create databases";
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
            // Login
            // 
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.ImageIndex = 10;
            this.Login.ImageList = this.imageList1;
            this.Login.Location = new System.Drawing.Point(289, 216);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(130, 44);
            this.Login.TabIndex = 26;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.ImageIndex = 6;
            this.Cancel.ImageList = this.imageList1;
            this.Cancel.Location = new System.Drawing.Point(425, 216);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(130, 44);
            this.Cancel.TabIndex = 27;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Create
            // 
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.ImageIndex = 8;
            this.Create.ImageList = this.imageList1;
            this.Create.Location = new System.Drawing.Point(289, 216);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(130, 44);
            this.Create.TabIndex = 30;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Cancel2
            // 
            this.Cancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel2.ImageIndex = 6;
            this.Cancel2.ImageList = this.imageList1;
            this.Cancel2.Location = new System.Drawing.Point(425, 216);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(130, 44);
            this.Cancel2.TabIndex = 31;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = true;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Database Name : ";
            // 
            // DatabaseN
            // 
            this.DatabaseN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseN.Location = new System.Drawing.Point(112, 85);
            this.DatabaseN.Name = "DatabaseN";
            this.DatabaseN.Size = new System.Drawing.Size(443, 21);
            this.DatabaseN.TabIndex = 28;
            // 
            // Process
            // 
            this.Process.AutoSize = true;
            this.Process.BackColor = System.Drawing.Color.Transparent;
            this.Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.Location = new System.Drawing.Point(0, 149);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(0, 15);
            this.Process.TabIndex = 33;
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(3, 167);
            this.Bar.MarqueeAnimationSpeed = 0;
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(549, 23);
            this.Bar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Bar.TabIndex = 32;
            // 
            // CreateDB_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 284);
            this.Controls.Add(this.CreateDBP);
            this.Controls.Add(this.LoginP);
            this.MaximizeBox = false;
            this.Name = "CreateDB_Form";
            this.Text = "CreateDB_Form";
            this.CreateDBP.ResumeLayout(false);
            this.CreateDBP.PerformLayout();
            this.LoginP.ResumeLayout(false);
            this.LoginP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreateDBP;
        private System.Windows.Forms.Panel LoginP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerN;
        private System.Windows.Forms.Label Notice;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Cancel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DatabaseN;
        private System.Windows.Forms.Label Process;
        private System.Windows.Forms.ProgressBar Bar;
    }
}