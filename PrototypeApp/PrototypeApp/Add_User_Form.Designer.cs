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
            this.Create = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordCon = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.CreateUserP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Testemonial = new System.Windows.Forms.CheckBox();
            this.Expenses = new System.Windows.Forms.CheckBox();
            this.ManageUserP = new System.Windows.Forms.Panel();
            this.Users_Grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.CreateUserB = new System.Windows.Forms.Button();
            this.ManageUserB = new System.Windows.Forms.Button();
            this.TablePanel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Testemonial2 = new System.Windows.Forms.CheckBox();
            this.Expenses2 = new System.Windows.Forms.CheckBox();
            this.Admin2 = new System.Windows.Forms.CheckBox();
            this.RowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateUserP.SuspendLayout();
            this.ManageUserP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_Grid)).BeginInit();
            this.TablePanel.SuspendLayout();
            this.TablePanel2.SuspendLayout();
            this.RowMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Password : ";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(119, 56);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(705, 21);
            this.Password.TabIndex = 1;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Username : ";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(119, 9);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(705, 21);
            this.UserName.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Create.ImageIndex = 5;
            this.Create.ImageList = this.imageList1;
            this.Create.Location = new System.Drawing.Point(694, 292);
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
            this.imageList1.Images.SetKeyName(11, "network.png");
            this.imageList1.Images.SetKeyName(12, "add-user.png");
            // 
            // Close
            // 
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.ImageIndex = 10;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(706, 12);
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
            this.label5.Location = new System.Drawing.Point(-3, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Confirm Password : ";
            // 
            // PasswordCon
            // 
            this.PasswordCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCon.Location = new System.Drawing.Point(119, 103);
            this.PasswordCon.Name = "PasswordCon";
            this.PasswordCon.Size = new System.Drawing.Size(705, 21);
            this.PasswordCon.TabIndex = 2;
            this.PasswordCon.UseSystemPasswordChar = true;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(666, 130);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(158, 19);
            this.Admin.TabIndex = 3;
            this.Admin.Text = "Give admin permissions";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
            // 
            // CreateUserP
            // 
            this.CreateUserP.Controls.Add(this.TablePanel);
            this.CreateUserP.Controls.Add(this.Admin);
            this.CreateUserP.Controls.Add(this.label5);
            this.CreateUserP.Controls.Add(this.Create);
            this.CreateUserP.Controls.Add(this.PasswordCon);
            this.CreateUserP.Controls.Add(this.label3);
            this.CreateUserP.Controls.Add(this.label4);
            this.CreateUserP.Controls.Add(this.UserName);
            this.CreateUserP.Controls.Add(this.Password);
            this.CreateUserP.Location = new System.Drawing.Point(12, 62);
            this.CreateUserP.Name = "CreateUserP";
            this.CreateUserP.Size = new System.Drawing.Size(824, 336);
            this.CreateUserP.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "User gets access to : ";
            // 
            // Testemonial
            // 
            this.Testemonial.AutoSize = true;
            this.Testemonial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testemonial.Location = new System.Drawing.Point(9, 27);
            this.Testemonial.Name = "Testemonial";
            this.Testemonial.Size = new System.Drawing.Size(94, 19);
            this.Testemonial.TabIndex = 0;
            this.Testemonial.Text = "Testemonial";
            this.Testemonial.UseVisualStyleBackColor = true;
            // 
            // Expenses
            // 
            this.Expenses.AutoSize = true;
            this.Expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses.Location = new System.Drawing.Point(9, 52);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(80, 19);
            this.Expenses.TabIndex = 1;
            this.Expenses.Text = "Expenses";
            this.Expenses.UseVisualStyleBackColor = true;
            // 
            // ManageUserP
            // 
            this.ManageUserP.Controls.Add(this.label7);
            this.ManageUserP.Controls.Add(this.Admin2);
            this.ManageUserP.Controls.Add(this.TablePanel2);
            this.ManageUserP.Controls.Add(this.Add);
            this.ManageUserP.Controls.Add(this.label2);
            this.ManageUserP.Controls.Add(this.UserName2);
            this.ManageUserP.Controls.Add(this.Users_Grid);
            this.ManageUserP.Location = new System.Drawing.Point(12, 62);
            this.ManageUserP.Name = "ManageUserP";
            this.ManageUserP.Size = new System.Drawing.Size(824, 336);
            this.ManageUserP.TabIndex = 27;
            // 
            // Users_Grid
            // 
            this.Users_Grid.AllowUserToAddRows = false;
            this.Users_Grid.AllowUserToDeleteRows = false;
            this.Users_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Users_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Users_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Role});
            this.Users_Grid.Location = new System.Drawing.Point(388, 32);
            this.Users_Grid.Name = "Users_Grid";
            this.Users_Grid.ReadOnly = true;
            this.Users_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_Grid.Size = new System.Drawing.Size(436, 304);
            this.Users_Grid.TabIndex = 5;
            this.Users_Grid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Users_Grid_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username : ";
            // 
            // UserName2
            // 
            this.UserName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName2.Location = new System.Drawing.Point(77, 76);
            this.UserName2.Name = "UserName2";
            this.UserName2.Size = new System.Drawing.Size(305, 21);
            this.UserName2.TabIndex = 24;
            // 
            // Add
            // 
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.ImageIndex = 5;
            this.Add.ImageList = this.imageList1;
            this.Add.Location = new System.Drawing.Point(252, 292);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(130, 44);
            this.Add.TabIndex = 26;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // TablePanel
            // 
            this.TablePanel.Controls.Add(this.label1);
            this.TablePanel.Controls.Add(this.Testemonial);
            this.TablePanel.Controls.Add(this.Expenses);
            this.TablePanel.Location = new System.Drawing.Point(3, 158);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(132, 102);
            this.TablePanel.TabIndex = 27;
            // 
            // CreateUserB
            // 
            this.CreateUserB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateUserB.ImageIndex = 12;
            this.CreateUserB.ImageList = this.imageList1;
            this.CreateUserB.Location = new System.Drawing.Point(232, 12);
            this.CreateUserB.Name = "CreateUserB";
            this.CreateUserB.Size = new System.Drawing.Size(220, 44);
            this.CreateUserB.TabIndex = 28;
            this.CreateUserB.Text = "Create users";
            this.CreateUserB.UseVisualStyleBackColor = true;
            this.CreateUserB.Click += new System.EventHandler(this.CreateUserB_Click);
            // 
            // ManageUserB
            // 
            this.ManageUserB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageUserB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageUserB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageUserB.ImageIndex = 11;
            this.ManageUserB.ImageList = this.imageList1;
            this.ManageUserB.Location = new System.Drawing.Point(12, 12);
            this.ManageUserB.Name = "ManageUserB";
            this.ManageUserB.Size = new System.Drawing.Size(220, 44);
            this.ManageUserB.TabIndex = 29;
            this.ManageUserB.Text = "Manage users";
            this.ManageUserB.UseVisualStyleBackColor = true;
            this.ManageUserB.Click += new System.EventHandler(this.ManageUserB_Click);
            // 
            // TablePanel2
            // 
            this.TablePanel2.Controls.Add(this.label6);
            this.TablePanel2.Controls.Add(this.Testemonial2);
            this.TablePanel2.Controls.Add(this.Expenses2);
            this.TablePanel2.Location = new System.Drawing.Point(3, 144);
            this.TablePanel2.Name = "TablePanel2";
            this.TablePanel2.Size = new System.Drawing.Size(132, 102);
            this.TablePanel2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "User gets access to : ";
            // 
            // Testemonial2
            // 
            this.Testemonial2.AutoSize = true;
            this.Testemonial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testemonial2.Location = new System.Drawing.Point(9, 27);
            this.Testemonial2.Name = "Testemonial2";
            this.Testemonial2.Size = new System.Drawing.Size(94, 19);
            this.Testemonial2.TabIndex = 0;
            this.Testemonial2.Text = "Testemonial";
            this.Testemonial2.UseVisualStyleBackColor = true;
            // 
            // Expenses2
            // 
            this.Expenses2.AutoSize = true;
            this.Expenses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expenses2.Location = new System.Drawing.Point(9, 52);
            this.Expenses2.Name = "Expenses2";
            this.Expenses2.Size = new System.Drawing.Size(80, 19);
            this.Expenses2.TabIndex = 1;
            this.Expenses2.Text = "Expenses";
            this.Expenses2.UseVisualStyleBackColor = true;
            // 
            // Admin2
            // 
            this.Admin2.AutoSize = true;
            this.Admin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin2.Location = new System.Drawing.Point(224, 103);
            this.Admin2.Name = "Admin2";
            this.Admin2.Size = new System.Drawing.Size(158, 19);
            this.Admin2.TabIndex = 29;
            this.Admin2.Text = "Give admin permissions";
            this.Admin2.UseVisualStyleBackColor = true;
            this.Admin2.CheckedChanged += new System.EventHandler(this.Admin2_CheckedChanged);
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
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "Username";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 197;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 196;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 30;
            this.label7.Text = "Database users : ";
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 410);
            this.Controls.Add(this.ManageUserB);
            this.Controls.Add(this.CreateUserB);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.ManageUserP);
            this.Controls.Add(this.CreateUserP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_User_Form";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_User_Form_Load);
            this.CreateUserP.ResumeLayout(false);
            this.CreateUserP.PerformLayout();
            this.ManageUserP.ResumeLayout(false);
            this.ManageUserP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_Grid)).EndInit();
            this.TablePanel.ResumeLayout(false);
            this.TablePanel.PerformLayout();
            this.TablePanel2.ResumeLayout(false);
            this.TablePanel2.PerformLayout();
            this.RowMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordCon;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.Panel CreateUserP;
        private System.Windows.Forms.Panel ManageUserP;
        private System.Windows.Forms.CheckBox Testemonial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Expenses;
        private System.Windows.Forms.DataGridView Users_Grid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName2;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Button CreateUserB;
        private System.Windows.Forms.Button ManageUserB;
        private System.Windows.Forms.Panel TablePanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Testemonial2;
        private System.Windows.Forms.CheckBox Expenses2;
        private System.Windows.Forms.CheckBox Admin2;
        private System.Windows.Forms.ContextMenuStrip RowMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Label label7;
    }
}