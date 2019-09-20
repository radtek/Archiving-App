namespace Apex
{
    partial class Add_User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User_Form));
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.Expenses = new System.Windows.Forms.CheckBox();
            this.Testemonial = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordCon = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password : ";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(131, 68);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(409, 21);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username : ";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(131, 21);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(409, 21);
            this.UserName.TabIndex = 0;
            // 
            // TablePanel
            // 
            this.TablePanel.Controls.Add(this.Expenses);
            this.TablePanel.Controls.Add(this.Testemonial);
            this.TablePanel.Controls.Add(this.label1);
            this.TablePanel.Location = new System.Drawing.Point(12, 170);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(200, 100);
            this.TablePanel.TabIndex = 3;
            // 
            // Expenses
            // 
            this.Expenses.AutoSize = true;
            this.Expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses.Location = new System.Drawing.Point(3, 52);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(80, 19);
            this.Expenses.TabIndex = 1;
            this.Expenses.Text = "Expenses";
            this.Expenses.UseVisualStyleBackColor = true;
            // 
            // Testemonial
            // 
            this.Testemonial.AutoSize = true;
            this.Testemonial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testemonial.Location = new System.Drawing.Point(3, 27);
            this.Testemonial.Name = "Testemonial";
            this.Testemonial.Size = new System.Drawing.Size(94, 19);
            this.Testemonial.TabIndex = 0;
            this.Testemonial.Text = "Testemonial";
            this.Testemonial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "User gets access to : ";
            // 
            // Create
            // 
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.ImageIndex = 5;
            this.Create.ImageList = this.imageList1;
            this.Create.Location = new System.Drawing.Point(274, 297);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(130, 44);
            this.Create.TabIndex = 4;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
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
            this.imageList1.Images.SetKeyName(10, "close.png");
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.ImageIndex = 10;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(410, 297);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(130, 44);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Confirm Password : ";
            // 
            // PasswordCon
            // 
            this.PasswordCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCon.Location = new System.Drawing.Point(131, 115);
            this.PasswordCon.Name = "PasswordCon";
            this.PasswordCon.Size = new System.Drawing.Size(409, 21);
            this.PasswordCon.TabIndex = 2;
            this.PasswordCon.UseSystemPasswordChar = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(382, 142);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(158, 19);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Give admin permissions";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 353);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordCon);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_User_Form";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_User_Form_Load);
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordCon;
        private System.Windows.Forms.CheckBox Testemonial;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.CheckBox Expenses;
    }
}