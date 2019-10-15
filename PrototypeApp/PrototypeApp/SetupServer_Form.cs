using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FluentFTP;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Drawing.Text;
using System.DirectoryServices;
using System.Security.Permissions;
using System.Collections;
using System.Management;
using System.Security.Principal;
using System.Security.AccessControl;
//using Cjwdev.WindowsApi;
using static Cjwdev.WindowsApi.NativeFileSystem;

namespace Apex
{
    public partial class SetupServer_Form : Form
    {
        public string connectionString = "";
        readonly GlobalFunc GF = new GlobalFunc();
        private readonly string[] Modules = {"Testemonial", "Expenses"};
        private readonly Dictionary<string, string> ModulePass = new Dictionary<string, string>();
        private readonly string createTes = "CREATE TABLE Testemonial\n(\nInterName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nLocation VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nProfession VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nPath VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nExtension VARCHAR(10) NOT NULL,\nDate DATE NOT NULL,\nLocationN VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nCode VARCHAR(20) NOT NULL,\nPRIMARY KEY(Name, Path, Extension),\nUNIQUE(Code)\n);\n";
        private readonly string createExp = "CREATE TABLE Expenses\n(\nName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nPath VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nExtension VARCHAR(10) NOT NULL,\nPRIMARY KEY(Name, Path, Extension)\n);\n";
        public SetupServer_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if(!GF.CheckTextBoxes(this))
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string user = UserName.Text;
            string database = "master";
            string server = ServerN.Text;
            if(!GF.CheckPasswordValidity(Password.Text))
            {
                MessageBox.Show("Password has invalid characters.\nOnly letters, numbers and underscores are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string pass = Password.Text;
            ModulePass.Add("TestemonialREAD", Testemonial_RUP.Text);
            ModulePass.Add("TestemonialFULL", Testemonial_FUP.Text);
            ModulePass.Add("ExpensesREAD", Expenses_RUP.Text);
            ModulePass.Add("ExpensesFULL", Expenses_FUP.Text);
            foreach(KeyValuePair<string , string> c in ModulePass)
            {
                if (!GF.CheckPasswordValidity(c.Value))
                {
                    MessageBox.Show(c.Key.Substring(0 , c.Key.Length-4)+ " password has invalid characters.\nOnly letters, numbers and underscores are valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            connectionString = GF.GetConnection(user , pass , server , database);
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string createDB = "CREATE DATABASE [" + DatabaseN.Text + "]\n";
            string createFunc = "CREATE FUNCTION dbo.dbRolesUsersMap (@dbRole SYSNAME = '%')\nRETURNS TABLE\nAS\nRETURN (\nSELECT \nUser_Type = \nCASE mmbrp.[type] \nWHEN 'G' THEN 'Windows Group' \nWHEN 'S' THEN 'SQL User' \nWHEN 'U' THEN 'Windows User' \nEND,\nDatabase_User_Name = mmbrp.[name],\nLogin_Name = ul.[name],\nDB_Role = rolp.[name]\nFROM sys.database_role_members mmbr,\nsys.database_principals rolp,\nsys.database_principals mmbrp,\nsys.server_principals ul\nWHERE Upper (mmbrp.[type]) IN ( 'S', 'U', 'G' )\nAND Upper (mmbrp.[name]) NOT IN ('SYS','INFORMATION_SCHEMA')\nAND rolp.[principal_id] = mmbr.[role_principal_id]\nAND mmbrp.[principal_id] = mmbr.[member_principal_id]\nAND ul.[sid] = mmbrp.[sid]\nAND rolp.[name] LIKE '%' + @dbRole + '%'\n)\n";
            SqlCommand comm = new SqlCommand(createDB, conn);
            if (!TryExecute(comm, conn))
            {
                comm.Dispose();
                return;
            }
            comm.Dispose();
            conn.Close();


            if (!GF.IsServerConnected(connectionString.Replace("master", DatabaseN.Text)))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn = new SqlConnection(connectionString.Replace("master" , DatabaseN.Text));
            conn.Open();
            comm = new SqlCommand(createFunc, conn);
            if (!TryExecute(comm, conn))
            {
                comm.Dispose();
                return;
            }
            comm.Dispose();


            string createQ = createTes + createExp;
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
            this.Close();
        }
        private bool TryExecute(SqlCommand comm , SqlConnection conn)
        {
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException)
            {
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

        private void CreateDirAndUsers()
        {
            string directory = DataDirectory.Text;
            CreateDirectories(directory);
            CreateWindowsUsers();
            GivePermissions(directory);
        }
        private void CreateDirectories(string directory)
        {
            //try
           // {
                foreach (string mod in Modules)
                {
                    Directory.CreateDirectory(directory + @"\" + mod);
                }
                ManagementClass managementClass = new ManagementClass("Win32_Share");
                ManagementBaseObject inParams = managementClass.GetMethodParameters("Create");
                ManagementBaseObject outParams;
                inParams["Description"] = "";
                inParams["Name"] = "CECF";
                inParams["Path"] = directory;
                inParams["Type"] = 0x0;
                inParams["Access"] = null;
                outParams = managementClass.InvokeMethod("Create", inParams, null);
                if ((uint)(outParams.Properties["ReturnValue"].Value) != 0)
                {
                    throw new Exception("Unable to share directory.");
                }

          
                var PermissionsList = new List<SharePermissionEntry>();
                SharedFolder x;
                // Create a new permission entry for the Everyone group and specify that we want to allow them Read access
                var PermEveryone = new SharePermissionEntry(string.Empty, "Everyone", SharedFolder.SharePermissions.Read, true);
                // Create a new permission entry for the currently logged on user and specify that we want to allow them Full Control
                var PermUser = new SharePermissionEntry(Environment.UserDomainName, Environment.UserName, SharedFolder.SharePermissions.FullControl, true);

                // Add the two entries declared above to our list
                PermissionsList.Add(PermUser);
                PermissionsList.Add(PermEveryone);

                // Share the folder as "Test Share" and pass in the desired permissions list
                SharedFolder.NET_API_STATUS Result = SharedFolder.ShareExistingFolder("Test Share", "This is a test share", @"C:\SomeFolder", PermissionsList);

                // Show the result
                if (Result == SharedFolder.NET_API_STATUS.NERR_Success)
                    MessageBox.Show("Share created successfully!");
                else
                    MessageBox.Show("Share was not created as the following error was returned: " + Result.ToString);
            


            //}
            //catch(Exception)
            //{
            //MessageBox.Show("Could not create directories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void GivePermissions(string directory)
        {
            try
            {
                foreach (string mod in Modules)
                {
                    try
                    {
                        var directoryInfo = new DirectoryInfo(directory);
                        var directorySecurity = directoryInfo.GetAccessControl();
                        NTAccount account = new NTAccount(mod + "READ");
                        SecurityIdentifier sId = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));
                        var fileSystemRule = new FileSystemAccessRule(sId,
                                                                      FileSystemRights.ReadAndExecute,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.None,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);

                        directoryInfo = new DirectoryInfo(directory);
                        directorySecurity = directoryInfo.GetAccessControl();
                        account = new NTAccount(mod + "FULL");
                        sId = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));
                        fileSystemRule = new FileSystemAccessRule(sId,
                                                                      FileSystemRights.ReadAndExecute,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.None,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);


                        directoryInfo = new DirectoryInfo(directory + @"\" + mod);
                        directorySecurity = directoryInfo.GetAccessControl();
                        account = new NTAccount(mod + "READ");
                        sId = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));
                        fileSystemRule = new FileSystemAccessRule(sId,
                                                                      FileSystemRights.ReadAndExecute,
                                                                      InheritanceFlags.ObjectInherit |
                                                                      InheritanceFlags.ContainerInherit,
                                                                      PropagationFlags.None,
                                                                      AccessControlType.Allow);

                        directorySecurity.AddAccessRule(fileSystemRule);
                        directoryInfo.SetAccessControl(directorySecurity);


                        directoryInfo = new DirectoryInfo(directory + @"\" + mod);
                        directorySecurity = directoryInfo.GetAccessControl();
                        account = new NTAccount(mod + "FULL");
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
            catch(Exception)
            {
                MessageBox.Show("Could not give permissions to users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckWindowsUser(string Username)
        {
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                if(envVar["Name"].ToString() == Username)
                {
                    searcher.Dispose();
                    return false;
                }
            }
            searcher.Dispose();
            return true;
        }
        private void CreateWindowsUser(string Name, string Pass , string desc)
        {
            if(!CheckWindowsUser(Name))
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
            catch(Exception)
            {
                MessageBox.Show("Could not create Local Users.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateWindowsUsers()
        {
            foreach(string mod in Modules)
            {
                CreateWindowsUser(mod + "READ", ModulePass[mod + "READ"], "Read Only " + mod);
                CreateWindowsUser(mod + "FULL", ModulePass[mod + "FULL"], "Full Control " + mod);
            }
        }
        private void Cancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                string res = FolderBrowser.SelectedPath;
                if (res[res.Length - 1] != '\\')
                    res += '\\';
                DataDirectory.Text = res + GlobalFunc.MainFolderName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDirectories(DataDirectory.Text);
            //MessageBox.Show("");
            GivePermissions(DataDirectory.Text);
        }
    }
}
