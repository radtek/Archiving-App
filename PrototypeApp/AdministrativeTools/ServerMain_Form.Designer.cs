namespace PolyDocServer
{
    partial class ServerMain_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerMain_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DatabaseInfo = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SetupServer = new System.Windows.Forms.Button();
            this.ServerState = new System.Windows.Forms.Button();
            this.Startup_Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseNTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseInfo_Panel = new System.Windows.Forms.Panel();
            this.ServerN = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.DatabaseN = new System.Windows.Forms.Label();
            this.Users_Grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tables_Grid = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectedClients = new System.Windows.Forms.Button();
            this.Setup_Panel = new System.Windows.Forms.Panel();
            this.SetupDone = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.DatabaseNSetup = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.PolyDoc_Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DataDirectory = new System.Windows.Forms.TextBox();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.Logout = new System.Windows.Forms.Button();
            this.ConnectedClients_Panel = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ConnectedClients_Grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerState_Panel = new System.Windows.Forms.Panel();
            this.Reconnect = new System.Windows.Forms.Button();
            this.State_Label = new System.Windows.Forms.Label();
            this.Startup_Panel.SuspendLayout();
            this.DatabaseInfo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tables_Grid)).BeginInit();
            this.Setup_Panel.SuspendLayout();
            this.ConnectedClients_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedClients_Grid)).BeginInit();
            this.ServerState_Panel.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(10, "login.png");
            this.imageList1.Images.SetKeyName(11, "database2.png");
            this.imageList1.Images.SetKeyName(12, "business-affiliate-network.png");
            this.imageList1.Images.SetKeyName(13, "server.png");
            this.imageList1.Images.SetKeyName(14, "exit.png");
            this.imageList1.Images.SetKeyName(15, "refresh-button2.png");
            this.imageList1.Images.SetKeyName(16, "refresh-arrow.png");
            // 
            // DatabaseInfo
            // 
            this.DatabaseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatabaseInfo.ImageIndex = 4;
            this.DatabaseInfo.ImageList = this.imageList1;
            this.DatabaseInfo.Location = new System.Drawing.Point(0, 44);
            this.DatabaseInfo.Name = "DatabaseInfo";
            this.DatabaseInfo.Size = new System.Drawing.Size(254, 44);
            this.DatabaseInfo.TabIndex = 43;
            this.DatabaseInfo.Text = "Database Info";
            this.DatabaseInfo.UseVisualStyleBackColor = true;
            this.DatabaseInfo.Click += new System.EventHandler(this.DatabaseInfo_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close.ImageIndex = 9;
            this.Close.ImageList = this.imageList1;
            this.Close.Location = new System.Drawing.Point(0, 454);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(254, 44);
            this.Close.TabIndex = 44;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SetupServer
            // 
            this.SetupServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetupServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupServer.ImageIndex = 13;
            this.SetupServer.ImageList = this.imageList1;
            this.SetupServer.Location = new System.Drawing.Point(0, 0);
            this.SetupServer.Name = "SetupServer";
            this.SetupServer.Size = new System.Drawing.Size(254, 44);
            this.SetupServer.TabIndex = 45;
            this.SetupServer.Text = "Setup Server";
            this.SetupServer.UseVisualStyleBackColor = true;
            this.SetupServer.Click += new System.EventHandler(this.SetupServer_Click);
            // 
            // ServerState
            // 
            this.ServerState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServerState.ImageIndex = 11;
            this.ServerState.ImageList = this.imageList1;
            this.ServerState.Location = new System.Drawing.Point(0, 132);
            this.ServerState.Name = "ServerState";
            this.ServerState.Size = new System.Drawing.Size(254, 44);
            this.ServerState.TabIndex = 46;
            this.ServerState.Text = "Server State";
            this.ServerState.UseVisualStyleBackColor = true;
            this.ServerState.Click += new System.EventHandler(this.ServerState_Click);
            // 
            // Startup_Panel
            // 
            this.Startup_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Startup_Panel.Controls.Add(this.label2);
            this.Startup_Panel.Controls.Add(this.Done);
            this.Startup_Panel.Controls.Add(this.label1);
            this.Startup_Panel.Controls.Add(this.DatabaseNTextBox);
            this.Startup_Panel.Location = new System.Drawing.Point(253, 0);
            this.Startup_Panel.Name = "Startup_Panel";
            this.Startup_Panel.Size = new System.Drawing.Size(786, 498);
            this.Startup_Panel.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 15);
            this.label2.TabIndex = 50;
            this.label2.Text = "- Type database name if it already exists";
            // 
            // Done
            // 
            this.Done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Done.ImageIndex = 8;
            this.Done.ImageList = this.imageList1;
            this.Done.Location = new System.Drawing.Point(644, 442);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(130, 44);
            this.Done.TabIndex = 48;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Database Name : ";
            // 
            // DatabaseNTextBox
            // 
            this.DatabaseNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNTextBox.Location = new System.Drawing.Point(119, 157);
            this.DatabaseNTextBox.Name = "DatabaseNTextBox";
            this.DatabaseNTextBox.Size = new System.Drawing.Size(655, 21);
            this.DatabaseNTextBox.TabIndex = 48;
            // 
            // DatabaseInfo_Panel
            // 
            this.DatabaseInfo_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseInfo_Panel.Controls.Add(this.ServerN);
            this.DatabaseInfo_Panel.Controls.Add(this.label15);
            this.DatabaseInfo_Panel.Controls.Add(this.DatabaseN);
            this.DatabaseInfo_Panel.Controls.Add(this.Users_Grid);
            this.DatabaseInfo_Panel.Controls.Add(this.Tables_Grid);
            this.DatabaseInfo_Panel.Controls.Add(this.label5);
            this.DatabaseInfo_Panel.Controls.Add(this.label4);
            this.DatabaseInfo_Panel.Controls.Add(this.label3);
            this.DatabaseInfo_Panel.Location = new System.Drawing.Point(253, 0);
            this.DatabaseInfo_Panel.Name = "DatabaseInfo_Panel";
            this.DatabaseInfo_Panel.Size = new System.Drawing.Size(786, 498);
            this.DatabaseInfo_Panel.TabIndex = 51;
            // 
            // ServerN
            // 
            this.ServerN.AutoSize = true;
            this.ServerN.Location = new System.Drawing.Point(116, 14);
            this.ServerN.Name = "ServerN";
            this.ServerN.Size = new System.Drawing.Size(0, 15);
            this.ServerN.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Server Name :";
            // 
            // DatabaseN
            // 
            this.DatabaseN.AutoSize = true;
            this.DatabaseN.Location = new System.Drawing.Point(116, 58);
            this.DatabaseN.Name = "DatabaseN";
            this.DatabaseN.Size = new System.Drawing.Size(0, 15);
            this.DatabaseN.TabIndex = 8;
            // 
            // Users_Grid
            // 
            this.Users_Grid.AllowUserToAddRows = false;
            this.Users_Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Users_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Users_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Users_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Users_Grid.Location = new System.Drawing.Point(10, 135);
            this.Users_Grid.Name = "Users_Grid";
            this.Users_Grid.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Users_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users_Grid.Size = new System.Drawing.Size(375, 351);
            this.Users_Grid.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn1.HeaderText = "Username";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 332;
            // 
            // Tables_Grid
            // 
            this.Tables_Grid.AllowUserToAddRows = false;
            this.Tables_Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Tables_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tables_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Tables_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tables_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table});
            this.Tables_Grid.Location = new System.Drawing.Point(399, 135);
            this.Tables_Grid.Name = "Tables_Grid";
            this.Tables_Grid.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables_Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Tables_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tables_Grid.Size = new System.Drawing.Size(375, 351);
            this.Tables_Grid.TabIndex = 6;
            // 
            // Table
            // 
            this.Table.DataPropertyName = "Table";
            this.Table.HeaderText = "Table";
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Width = 332;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Database Users :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Database Tables :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database Name :";
            // 
            // ConnectedClients
            // 
            this.ConnectedClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectedClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectedClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectedClients.ImageIndex = 12;
            this.ConnectedClients.ImageList = this.imageList1;
            this.ConnectedClients.Location = new System.Drawing.Point(0, 88);
            this.ConnectedClients.Name = "ConnectedClients";
            this.ConnectedClients.Size = new System.Drawing.Size(254, 44);
            this.ConnectedClients.TabIndex = 52;
            this.ConnectedClients.Text = "Connected Clients";
            this.ConnectedClients.UseVisualStyleBackColor = true;
            this.ConnectedClients.Click += new System.EventHandler(this.ConnectedClients_Click);
            // 
            // Setup_Panel
            // 
            this.Setup_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setup_Panel.Controls.Add(this.SetupDone);
            this.Setup_Panel.Controls.Add(this.label16);
            this.Setup_Panel.Controls.Add(this.DatabaseNSetup);
            this.Setup_Panel.Controls.Add(this.label11);
            this.Setup_Panel.Controls.Add(this.Browse);
            this.Setup_Panel.Controls.Add(this.PolyDoc_Password);
            this.Setup_Panel.Controls.Add(this.label6);
            this.Setup_Panel.Controls.Add(this.label13);
            this.Setup_Panel.Controls.Add(this.DataDirectory);
            this.Setup_Panel.Location = new System.Drawing.Point(253, 0);
            this.Setup_Panel.Name = "Setup_Panel";
            this.Setup_Panel.Size = new System.Drawing.Size(786, 498);
            this.Setup_Panel.TabIndex = 53;
            // 
            // SetupDone
            // 
            this.SetupDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetupDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupDone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetupDone.ImageIndex = 8;
            this.SetupDone.ImageList = this.imageList1;
            this.SetupDone.Location = new System.Drawing.Point(644, 442);
            this.SetupDone.Name = "SetupDone";
            this.SetupDone.Size = new System.Drawing.Size(130, 44);
            this.SetupDone.TabIndex = 78;
            this.SetupDone.Text = "Done";
            this.SetupDone.UseVisualStyleBackColor = true;
            this.SetupDone.Click += new System.EventHandler(this.SetupDone_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 61;
            this.label16.Text = "Database Name : ";
            // 
            // DatabaseNSetup
            // 
            this.DatabaseNSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseNSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseNSetup.Location = new System.Drawing.Point(122, 26);
            this.DatabaseNSetup.Name = "DatabaseNSetup";
            this.DatabaseNSetup.Size = new System.Drawing.Size(652, 21);
            this.DatabaseNSetup.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 15);
            this.label11.TabIndex = 76;
            this.label11.Text = "PolyDoc Windows User Password :";
            // 
            // Browse
            // 
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browse.ImageIndex = 7;
            this.Browse.ImageList = this.imageList1;
            this.Browse.Location = new System.Drawing.Point(644, 97);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(130, 44);
            this.Browse.TabIndex = 66;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // PolyDoc_Password
            // 
            this.PolyDoc_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PolyDoc_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolyDoc_Password.Location = new System.Drawing.Point(213, 266);
            this.PolyDoc_Password.Name = "PolyDoc_Password";
            this.PolyDoc_Password.Size = new System.Drawing.Size(561, 21);
            this.PolyDoc_Password.TabIndex = 75;
            this.PolyDoc_Password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "-Choose where your files will be stored.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 65;
            this.label13.Text = "Data Directory : ";
            // 
            // DataDirectory
            // 
            this.DataDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDirectory.Location = new System.Drawing.Point(122, 70);
            this.DataDirectory.Name = "DataDirectory";
            this.DataDirectory.Size = new System.Drawing.Size(652, 21);
            this.DataDirectory.TabIndex = 64;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.ImageIndex = 14;
            this.Logout.ImageList = this.imageList1;
            this.Logout.Location = new System.Drawing.Point(0, 410);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(254, 44);
            this.Logout.TabIndex = 54;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ConnectedClients_Panel
            // 
            this.ConnectedClients_Panel.Controls.Add(this.Refresh);
            this.ConnectedClients_Panel.Controls.Add(this.label7);
            this.ConnectedClients_Panel.Controls.Add(this.ConnectedClients_Grid);
            this.ConnectedClients_Panel.Location = new System.Drawing.Point(253, 0);
            this.ConnectedClients_Panel.Name = "ConnectedClients_Panel";
            this.ConnectedClients_Panel.Size = new System.Drawing.Size(786, 498);
            this.ConnectedClients_Panel.TabIndex = 55;
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh.ImageIndex = 16;
            this.Refresh.ImageList = this.imageList1;
            this.Refresh.Location = new System.Drawing.Point(599, 442);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(175, 44);
            this.Refresh.TabIndex = 49;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Connected Clients :";
            // 
            // ConnectedClients_Grid
            // 
            this.ConnectedClients_Grid.AllowUserToAddRows = false;
            this.ConnectedClients_Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectedClients_Grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ConnectedClients_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectedClients_Grid.BackgroundColor = System.Drawing.Color.White;
            this.ConnectedClients_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConnectedClients_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.ConnectedClients_Grid.Location = new System.Drawing.Point(10, 47);
            this.ConnectedClients_Grid.Name = "ConnectedClients_Grid";
            this.ConnectedClients_Grid.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectedClients_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ConnectedClients_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConnectedClients_Grid.Size = new System.Drawing.Size(764, 389);
            this.ConnectedClients_Grid.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "User";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 721;
            // 
            // ServerState_Panel
            // 
            this.ServerState_Panel.Controls.Add(this.Reconnect);
            this.ServerState_Panel.Controls.Add(this.State_Label);
            this.ServerState_Panel.Location = new System.Drawing.Point(253, 0);
            this.ServerState_Panel.Name = "ServerState_Panel";
            this.ServerState_Panel.Size = new System.Drawing.Size(786, 498);
            this.ServerState_Panel.TabIndex = 56;
            // 
            // Reconnect
            // 
            this.Reconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Reconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reconnect.ImageIndex = 15;
            this.Reconnect.ImageList = this.imageList1;
            this.Reconnect.Location = new System.Drawing.Point(599, 442);
            this.Reconnect.Name = "Reconnect";
            this.Reconnect.Size = new System.Drawing.Size(175, 44);
            this.Reconnect.TabIndex = 50;
            this.Reconnect.Text = "Reconnect";
            this.Reconnect.UseVisualStyleBackColor = true;
            this.Reconnect.Click += new System.EventHandler(this.Reconnect_Click);
            // 
            // State_Label
            // 
            this.State_Label.BackColor = System.Drawing.Color.White;
            this.State_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State_Label.Location = new System.Drawing.Point(3, 131);
            this.State_Label.Name = "State_Label";
            this.State_Label.Size = new System.Drawing.Size(780, 93);
            this.State_Label.TabIndex = 0;
            this.State_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServerMain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 498);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ConnectedClients);
            this.Controls.Add(this.ServerState);
            this.Controls.Add(this.SetupServer);
            this.Controls.Add(this.DatabaseInfo);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Setup_Panel);
            this.Controls.Add(this.DatabaseInfo_Panel);
            this.Controls.Add(this.ServerState_Panel);
            this.Controls.Add(this.ConnectedClients_Panel);
            this.Controls.Add(this.Startup_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerMain_Form";
            this.Text = "PolyDoc Archiving Software Server";
            this.Startup_Panel.ResumeLayout(false);
            this.Startup_Panel.PerformLayout();
            this.DatabaseInfo_Panel.ResumeLayout(false);
            this.DatabaseInfo_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Users_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tables_Grid)).EndInit();
            this.Setup_Panel.ResumeLayout(false);
            this.Setup_Panel.PerformLayout();
            this.ConnectedClients_Panel.ResumeLayout(false);
            this.ConnectedClients_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectedClients_Grid)).EndInit();
            this.ServerState_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button DatabaseInfo;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button SetupServer;
        private System.Windows.Forms.Button ServerState;
        private System.Windows.Forms.Panel Startup_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DatabaseNTextBox;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DatabaseInfo_Panel;
        private System.Windows.Forms.Button ConnectedClients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DatabaseN;
        private System.Windows.Forms.DataGridView Users_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView Tables_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.Panel Setup_Panel;
        private System.Windows.Forms.Button SetupDone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DatabaseNSetup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox PolyDoc_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DataDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Panel ConnectedClients_Panel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ConnectedClients_Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Panel ServerState_Panel;
        private System.Windows.Forms.Button Reconnect;
        private System.Windows.Forms.Label State_Label;
        private System.Windows.Forms.Label ServerN;
        private System.Windows.Forms.Label label15;
    }
}