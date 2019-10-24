using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.DirectoryServices;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cjwdev.WindowsApi.NativeFileSystem;

namespace PolyDocServer
{
    public partial class ServerMain_Form : Form
    {
        public string connectionString = "";
        public string serverUsed;
        public string databaseUsed;
        private readonly ServerGlobalFunc GF = new ServerGlobalFunc();
        private readonly List<Module> Modules = new List<Module>();
        private readonly Dictionary<string, string> ModulePass = new Dictionary<string, string>();
        public ServerMain_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                GF.EditButtons(p);
            }
            Login_Logout();
        }
        public void Login_Logout()
        {
            this.Visible = false;
            ServerLogin_Form form = new ServerLogin_Form();
            form.ShowDialog();
            connectionString = form.connectionString;
            if (connectionString == "")
                Environment.Exit(1);
            serverUsed = form.server;
            ShowStartup();
            this.Visible = true;
        }

        private void ShowStartup()
        {
            Show(Startup_Panel);
            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.Enabled = false;
            }
            SetupServer.Enabled = true;
            Close.Enabled = true;
            Logout.Enabled = true;
        }
        private void Show(Panel panel)
        {
            foreach (Panel p in this.Controls.OfType<Panel>())
            {
                p.Visible = false;
            }
            panel.Visible = true;
        }
        private void RefreshDatabaseInfo()
        {
            DatabaseN.Text = databaseUsed;
            ServerN.Text = serverUsed;
            string get_users = "use[" + databaseUsed + "] SELECT Login_Name as [User] FROM dbo.dbRolesUsersMap (DEFAULT)" +
                               "where db_role = 'db_owner' or db_role = 'db_datareader'";
            string get_tables = "use[" + databaseUsed + "] SELECT table_name as [Table] FROM information_schema.tables";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_users, conn))
                        {
                            DataTable Data = new DataTable();
                            sqlAdapt.Fill(Data);
                            Users_Grid.DataSource = Data;
                        }
                        using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_tables, conn))
                        {
                            DataTable Data = new DataTable();
                            sqlAdapt.Fill(Data);
                            Tables_Grid.DataSource = Data;
                        }
                    }
                    catch (SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost();
                return;
            }
        }

        private void RefreshClientsConnected()
        {
            string get_clients = "SELECT loginame as [User]\n" +
                                 "FROM    sys.sysprocesses\n" +
                                 "WHERE DB_NAME(dbid) = '" + databaseUsed.Replace("'", "''") + "' and loginame != 'sa'\n" +
                                 "GROUP BY dbid, loginame\n";
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using(SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_clients , conn))
                        {
                            DataTable Data = new DataTable();
                            sqlAdapt.Fill(Data);
                            ConnectedClients_Grid.DataSource = Data;
                        }
                    }
                    catch(SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost();
                return;
            }
        }

        private void CheckConnection()
        {
            if(GF.IsServerConnected(connectionString))
            {
                State_Label.BackColor = Color.FromArgb(128, 255, 128);
                State_Label.Text = "Connected";
            }
            else
            {
                State_Label.BackColor = Color.FromArgb(255, 128, 128);
                State_Label.Text = "Disconnected";
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            string getTables = "use[" + DatabaseNTextBox.Text + "] SELECT table_name as [table] FROM information_schema.tables";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(getTables, conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            int count = 0;
                            while (reader.Read())
                            {
                                if (reader["Table"].ToString() == "sysdiagrams")
                                    continue;
                                count++;
                                if (!GF.ModuleExists(reader["Table"].ToString()))
                                {
                                    MessageBox.Show("Invalid database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            if(count < GF.ModuleNames.Length)
                            {
                                MessageBox.Show("Invalid database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            foreach (Button b in this.Controls.OfType<Button>())
                            {
                                b.Enabled = true;
                            }
                            SetupServer.Enabled = false;
                            databaseUsed = DatabaseNTextBox.Text;
                            SetupServer.Enabled = false;
                            Show(DatabaseInfo_Panel);
                            RefreshDatabaseInfo();
                        }
                    }
                    catch (SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost();
                return;
            }
        }

        private void DatabaseInfo_Click(object sender, EventArgs e)
        {
            Show(DatabaseInfo_Panel);
            RefreshDatabaseInfo();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                string res = FolderBrowser.SelectedPath;
                if (res[res.Length - 1] != '\\')
                    res += '\\';
                DataDirectory.Text = res + ServerGlobalFunc.MainFolderName;
            }
        }

        private void CreateModules()
        {
            Modules.Add(new Module("Testemonial",   "CREATE TABLE Professions\n" +
                                                    "(Profession VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "PRIMARY KEY (Profession));\n" +

                                                    "CREATE TABLE Locations\n" +
                                                    "(Location VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "PRIMARY KEY (Location));\n" +

                                                    "CREATE TABLE Testemonial\n" +
                                                    "(InterName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "Location VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "Profession VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "Name VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "Path VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "Extension VARCHAR(10) NOT NULL," +
                                                    "Date DATE NOT NULL,\n" +
                                                    "LocationN VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                    "Code VARCHAR(20) NOT NULL,\n" +
                                                    "PRIMARY KEY(Name, Path, Extension),\n" +
                                                    "FOREIGN KEY (Profession) REFERENCES Professions(Profession),\n" +
                                                    "FOREIGN KEY (Location) REFERENCES Locations(Location),\n" +
                                                    "\nUNIQUE(Code)\n);\n"));

            Modules.Add(new Module("Expenses",  "CREATE TABLE Expenses\n" +
                                                "(\nName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                                "\nPath VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                                "\nExtension VARCHAR(10) NOT NULL," +
                                                "\nPRIMARY KEY(Name, Path, Extension)\n);\n"));

            Modules.Add(new Module("Projects", "CREATE TABLE Projects\n" +
                                                "(Name VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                "Path VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                "Extension VARCHAR(10) NOT NULL,\n" +
                                                "ProjectName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                "Partner VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                "Location VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\n" +
                                                "StartDate DATE NOT NULL,\n" +
                                                "EndDate DATE NOT NULL,\n" +
                                                "Code VARCHAR(20) NOT NULL,\n" +
                                                "PRIMARY KEY (Name, Path, Extension),\n" +
                                                "UNIQUE (Code));\n"));

            Modules.Add(new Module("HR" , "CREATE TABLE Jobs\n" +
                                          "(JobName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                          "PRIMARY KEY (JobName));" +

                                          "CREATE TABLE HR" +
                                          "(Name VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                          "Path VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                          "Extension VARCHAR(10) NOT NULL," +
                                          "Code VARCHAR(20) NOT NULL," +
                                          "EmpName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                          "EmpBirthDate DATE NOT NULL," +
                                          "EmpEmploymentDate DATE NOT NULL," +
                                          "EmpID VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                          "EmpJob VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL," +
                                          "PRIMARY KEY (Name, Path, Extension)," +
                                          "FOREIGN KEY (EmpJob) REFERENCES Jobs(JobName)," +
                                          "UNIQUE (Code));"));
        }
        private void SetupDone_Click(object sender, EventArgs e)
        {
            if (!GF.CheckTextBoxes(Setup_Panel))
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CreateModules();
            string server = serverUsed;
            foreach (KeyValuePair<string, string> c in ModulePass)
            {
                if (!GF.CheckPasswordValidity(c.Value))
                {
                    MessageBox.Show(c.Key.Substring(0, c.Key.Length - 4) + " password has invalid characters.\nOnly letters, numbers and underscores are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string createDB = "CREATE DATABASE [" + DatabaseNSetup.Text + "]\n";
            string createFunc = "CREATE FUNCTION dbo.dbRolesUsersMap (@dbRole SYSNAME = '%')\nRETURNS TABLE\nAS\nRETURN (\nSELECT \nUser_Type = \nCASE mmbrp.[type] \nWHEN 'G' THEN 'Windows Group' \nWHEN 'S' THEN 'SQL User' \nWHEN 'U' THEN 'Windows User' \nEND,\nDatabase_User_Name = mmbrp.[name],\nLogin_Name = ul.[name],\nDB_Role = rolp.[name]\nFROM sys.database_role_members mmbr,\nsys.database_principals rolp,\nsys.database_principals mmbrp,\nsys.server_principals ul\nWHERE Upper (mmbrp.[type]) IN ( 'S', 'U', 'G' )\nAND Upper (mmbrp.[name]) NOT IN ('SYS','INFORMATION_SCHEMA')\nAND rolp.[principal_id] = mmbr.[role_principal_id]\nAND mmbrp.[principal_id] = mmbr.[member_principal_id]\nAND ul.[sid] = mmbrp.[sid]\nAND rolp.[name] LIKE '%' + @dbRole + '%'\n)\n";
            SqlCommand comm = new SqlCommand(createDB, conn);
            if (!TryExecute(comm, conn))
            {
                comm.Dispose();
                return;
            }
            comm.Dispose();
            conn.Close();


            if (!GF.IsServerConnected(connectionString.Replace("master", DatabaseNSetup.Text)))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn = new SqlConnection(connectionString.Replace("master", DatabaseNSetup.Text));
            conn.Open();
            comm = new SqlCommand(createFunc, conn);
            if (!TryExecute(comm, conn))
            {
                comm.Dispose();
                return;
            }
            comm.Dispose();


            string createQ = null;
            foreach(Module mod in Modules)
            {
                createQ += mod.GetCreateQ();
            }

            comm = new SqlCommand(createQ, conn);
            if (!TryExecute(comm, conn))
            {
                comm.Dispose();
                return;
            }
            comm.Dispose();
            conn.Close();


            CreateDirAndUsers();


            MessageBox.Show("Setup Complete!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.Enabled = true;
            }
            SetupServer.Enabled = false;
            databaseUsed = DatabaseNSetup.Text;
            SetupServer.Enabled = false;
            Show(DatabaseInfo_Panel);
            RefreshDatabaseInfo();
        }
        private void CreateDirAndUsers()
        {
            string directory = DataDirectory.Text;
            CreateDirectories(directory);
            CreateWindowsUser("PolyDoc-AdminUser" , "Nb6LjWTdO5XyLWy0k3sN", "PolyDoc Admin User");
            GivePermissions(directory);
        }
        private void CreateDirectories(string directory)
        {
            try
            {
                foreach (Module mod in Modules)
                {
                    Directory.CreateDirectory(directory + @"\" + mod.GetName());
                }
                List<SharePermissionEntry> PermissionsList = new List<SharePermissionEntry>();
                var PermEveryone = new SharePermissionEntry(string.Empty, "Everyone", SharePermission.FullControl, true);
                var PermUser = new SharePermissionEntry(string.Empty, "Administrators", SharePermission.FullControl, true);

                PermissionsList.Add(PermEveryone);
                PermissionsList.Add(PermUser);

                ShareExistingFolder(directory, ServerGlobalFunc.MainFolderName, "test", PermissionsList);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateWindowsUser(string Name, string Pass, string desc)
        {
            if (!CheckWindowsUser(Name))
            {
                return;
            }
            try
            {
                int NON_EXPIRE_FLAG = 0x10000;

                DirectoryEntry AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                DirectoryEntry NewUser = AD.Children.Add(Name, "user");
                NewUser.Invoke("SetPassword", new object[] { Pass });
                NewUser.Invoke("Put", new object[] { "Description", desc });
                NewUser.Properties["UserFlags"].Value = NON_EXPIRE_FLAG;
                NewUser.CommitChanges();
                DirectoryEntry grp;
                grp = AD.Children.Find("Guests", "group");
                if (grp != null) { grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); }
                AD.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not create Local Users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GivePermissions(string directory)
        {
            try
            {
                foreach (Module mod in Modules)
                {
                    try
                    {
                        var directoryInfo = new DirectoryInfo(directory);
                        var directorySecurity = directoryInfo.GetAccessControl();
                        NTAccount account = new NTAccount("PolyDoc-AdminUser");
                        SecurityIdentifier sId = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));
                        var fileSystemRule = new FileSystemAccessRule(sId,
                                                                      FileSystemRights.ReadAndExecute,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);


                        directoryInfo = new DirectoryInfo(directory + @"\" + mod.GetName());
                        directorySecurity = directoryInfo.GetAccessControl();
                        account = new NTAccount("PolyDoc-AdminUser");
                        sId = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));
                        fileSystemRule = new FileSystemAccessRule(sId,
                                                                      FileSystemRights.FullControl,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not give permissions to users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not give permissions to users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool TryExecute(SqlCommand comm, SqlConnection conn)
        {
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Could not create database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!GF.IsServerConnected(connectionString))
                {
                    MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                return false;
            }
            return true;
        }
        private bool CheckWindowsUser(string Username)
        {
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                if (envVar["Name"].ToString() == Username)
                {
                    searcher.Dispose();
                    return false;
                }
            }
            searcher.Dispose();
            return true;
        }

        private void SetupServer_Click(object sender, EventArgs e)
        {
            Show(Setup_Panel);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login_Logout();
        }

        private void ConnectedClients_Click(object sender, EventArgs e)
        {
            Show(ConnectedClients_Panel);
            RefreshClientsConnected();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshClientsConnected();
        }

        private void Reconnect_Click(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void ServerState_Click(object sender, EventArgs e)
        {
            Show(ServerState_Panel);
            CheckConnection();
        }
    }
}
