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

namespace Apex
{
    class GlobalFunc
    {
        private readonly string LogsLoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Apex Archiving Software/Logs/DatabaseInfo.txt";
        private readonly string DataLoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Apex Archiving Software/Data";
        
        public const string MainFolderName = "CECF";
        public const string FilesDirectory = @"\\192.168.1.4\" + MainFolderName;

        public void CheckLogs()
        {
            if (!File.Exists(LogsLoc))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Apex Archiving Software/Logs");
                using (StreamWriter outputFile = new StreamWriter(LogsLoc))
                {
                    outputFile.WriteLine("Server=" + Environment.NewLine + "Database=" + Environment.NewLine + "Authentication=");
                }
            }
        }

        public string GetConnection(string user , string pass , string authentication , string server=null , string database=null)
        {
            CheckLogs();
            if (server == null && database == null)
            {
                using (StreamReader file = new StreamReader(LogsLoc))
                {
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        string[] line = ln.Split('=');
                        if (line[0] == "Server") server = line[1];
                        if (line[0] == "Database") database = line[1];
                    }
                    file.Close();
                }
            }
            string connectionString = null;
            if(authentication == "SQL Server Authentication")
                connectionString = "Data Source=" + server + ";Initial Catalog =" + database + "; User id=" + user +";Password=" + pass + ";";
            else if(authentication == "Windows Authentication")
                connectionString = "Data Source=" + server + ";Initial Catalog =" + database + "; Integrated Security=True;";
            return connectionString;
        }

        public string GetServer()
        {
            CheckLogs();
            string server = null;
            using (StreamReader file = new StreamReader(LogsLoc))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] line = ln.Split('=');
                    if (line[0] == "Server")
                    {
                        server = line[1];
                        break;
                    }
                }
                file.Close();
            }
            return server;
        }

        public string GetDatabase()
        {
            CheckLogs();
            string database = null;
            using (StreamReader file = new StreamReader(LogsLoc))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] line = ln.Split('=');
                    if (line[0] == "Database")
                    {
                        database = line[1];
                        break;
                    }
                }
                file.Close();
            }
            return database;
        }

        public string GetAuthentication()
        {
            CheckLogs();
            string authentication = null;
            using (StreamReader file = new StreamReader(LogsLoc))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    string[] line = ln.Split('=');
                    if (line[0] == "Authentication")
                    {
                        authentication = line[1];
                        break;
                    }
                }
                file.Close();
            }
            return authentication;
        }
        public void UpdateLogs(string server , string database , string authentication)
        {
            CheckLogs();
            using (StreamWriter outputFile = new StreamWriter(LogsLoc))
            {
                outputFile.WriteLine("Server=" + server + Environment.NewLine + "Database=" + database + Environment.NewLine + "Authentication=" + authentication);
            }
        }

        /*
        public void UpdateSettings(string setting , string value)
        {
            string ln;
            using (StreamReader file = new StreamReader(DataLoc + "/Settings.txt"))
            {
                while ((ln = file.ReadLine()) != null)
                {
                    string[] line = ln.Split('=');
                    if(line[0] == "Directory Path")
                }
            }
        }
        */
        public bool IsServerConnected(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                    conn.Open();
                return true;
            }
            catch (SqlException e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }
        }

        public void EndServerConnection(string connectionString)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                    SqlConnection.ClearPool(conn);
            }
            catch (SqlException)
            {
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    string[] Local = ip.ToString().Split('.');
                    if (Local[0] == "192" && Local[1] == "168" && Local[2] == "1")
                        return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public bool CheckExtension(string x , string extensions)
        {
            string temp="";
            bool start = false;
            foreach(char c in extensions)
            {
                if (c == '*')
                {
                    start = true;
                    continue;
                }
                if(c==')' || c=='|')
                {
                    start = false;
                    if (x == temp)
                        return true;
                    temp = "";
                }
                if (start)
                    temp += c;
            }
            return false;
        }
        public bool CheckExistance(string x , string table , string connectionString)
        {
            string[] pk = x.Split('-');
            string check = "select count(name) from " + table + " where name=N'" + pk[0] + "' and path=N'" + FilesDirectory + @"\" + table + "' and extension='" + pk[1] + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(check, conn);
            string count = comm.ExecuteScalar().ToString();
            conn.Close();
            comm.Dispose();
            if (count == "0")
                return false;
            return true;
        }
        public void DeleteRecords(DataGridView Grid , string table , string cell1 , string cell2 , string cell3 , string connectionString , Form parent , Form MainForm)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DialogResult res = MessageBox.Show("Are you sure you want to permanently delete the selected records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow r in Grid.SelectedRows)
                    {
                        string name = r.Cells[cell1].Value.ToString().Replace("'", "''"), path = r.Cells[cell2].Value.ToString().Replace("'", "''"), ext = r.Cells[cell3].Value.ToString();
                        try
                        {
                            using (new NetworkConnection(FilesDirectory, new NetworkCredential("Apex-AdminUser", "123")))
                            {
                                File.Delete(path + @"\" + name + ext);
                            }
                        }
                        catch (Exception) { }
                        string delete_records = "delete from " + table + " where name = N'" + name + "' and path =N'" + path + "' and extension ='" + ext + "'";
                        using (SqlCommand comm = new SqlCommand(delete_records, conn))
                            comm.ExecuteNonQuery();
                        Grid.Rows.Remove(r);
                    }
                }
            }
            catch(SqlException)
            {
                ConnectionLost(parent, MainForm);
                return;
            }
            MessageBox.Show("Successfully deleted selected records!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void OpenRecord(DataGridView grid , DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string path = grid.CurrentRow.Cells["Path"].Value.ToString() + "\\" + grid.CurrentRow.Cells["FileName"].Value.ToString() + grid.CurrentRow.Cells["Extension"].Value.ToString();
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
            else MessageBox.Show("Error 404.\nFile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ClearRecords(DataGridView Grid)
        {
            while (Grid.Rows.Count > 0)
            {
                Grid.Rows.Remove(Grid.Rows[0]);
            }
        }
        public string RemoveTime(string x)
        {
            string[] parts = x.Split('/');
            string res = parts[0] + "/" + parts[1] + "/" + parts[2][0] + parts[2][1] + parts[2][2] + parts[2][3];
            return res;
        }
        public void GetLocations(ComboBox Locs , bool Search)
        {
            string loc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Apex Archiving Software/Data/Locations.txt";
            CheckData("Locations");
            using (StreamReader file = new StreamReader(loc))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Locs.Items.Add(ln);
                }
                file.Close();
                if (Search)
                {
                    Locs.Items.Add("-Disable-");
                    Locs.Text = "-Disable-";
                }
            }
        }
        public void GetProfessions(ComboBox Pros, bool Search)
        {
            string loc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Apex Archiving Software/Data/Professions.txt";
            CheckData("Professions");
            using (StreamReader file = new StreamReader(loc))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Pros.Items.Add(ln);
                }
                file.Close();
                if (Search)
                {
                    Pros.Items.Add("-Disable-");
                    Pros.Text = "-Disable-";
                }
            }
        }
        public void CheckData(string name)
        {
            if(name == "Locations")
            {
                string loc = DataLoc + "/Locations.txt";
                if (!File.Exists(loc))
                {
                    Directory.CreateDirectory(DataLoc);
                    var file = File.CreateText(loc);
                    file.Close();
                }
            }
            if(name == "Professions")
            {
                string loc = DataLoc + "/Professions.txt";
                if (!File.Exists(loc))
                {
                    Directory.CreateDirectory(DataLoc);
                    var file = File.CreateText(loc);
                    file.Close();
                }
            }
            if(name == "Settings")
            {
                string loc = DataLoc + "/Settings.txt";
                if (!File.Exists(loc))
                {
                    Directory.CreateDirectory(DataLoc);
                    using (StreamWriter outputFile = new StreamWriter(loc))
                    {
                        outputFile.WriteLine("Directory Path=" + Environment.NewLine);
                    }
                }
            }
        }
        public string GetCode(string table, Dictionary<string, bool> map, string connectionString , Form parent , Form MainForm)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string code = table.Substring(0 , 3).ToUpper() + DateTime.Now.Year.ToString();
                    string check = "select count(*) from " + table + " where code = '";
                    int counter = -1;
                    string res;
                    string finalCode;
                    do
                    {
                        counter++;
                        if (counter % 10 == counter)
                            finalCode = code + "0" + counter.ToString();
                        else finalCode = code + counter.ToString();
                        string temp_check = check + finalCode + "'";
                        SqlCommand comm = new SqlCommand(temp_check, conn);
                        res = comm.ExecuteScalar().ToString();
                        comm.Dispose();
                    }
                    while (res == "1" || (map.ContainsKey(finalCode) && map[finalCode] == true));
                    return finalCode;
                }
            }
            catch(SqlException)
            {
                ConnectionLost(parent, MainForm);
                return "Invalid";
            }
        }
        public void EditButtons(Control parent)
        {
            foreach (Button c in parent.Controls.OfType<Button>())
            {
                c.FlatAppearance.BorderColor = Color.White;
            }
        }

        public bool CheckTextBoxes(Control parent)
        {
            foreach (TextBox c in parent.Controls.OfType<TextBox>())
            {
                if (!c.Enabled)
                    continue;
                if (c.Text == "" && c.Enabled)
                    return false;
                bool allSpaces = true;
                foreach(char ch in c.Text)
                    if(ch != ' ')
                    {
                        allSpaces = false;
                        break;
                    }
                if (allSpaces)
                    return false;
            }
            return true;
        }

        public bool CheckPasswordValidity(string pass)
        {
            foreach(char c in pass)
            {
                if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z') && c != '_' && (c < '0' || c > '9'))
                    return false;
            }
            return true;
        }

        public bool CheckPerm(string user , string perm , string database , string table , string connectionString , Form parent , Form MainForm , Control cont=null)
        {
            string checkPerm = "SELECT count(Login_Name) from (" +
                                      "SELECT Login_Name\n" +
                                      "FROM sys.database_permissions , (SELECT distinct Database_User_Name , Login_Name FROM dbo.dbRolesUsersMap (DEFAULT)) as x\n" +
                                      "where DB_NAME()='" + database.Replace("'" , "''") + "' and USER_NAME(grantee_principal_id) != 'public' and Database_User_Name = USER_NAME(grantee_principal_id)\n" +
                                      "and Login_Name='" + user.Replace("'", "''") + "' and permission_name = '" + perm + "' and OBJECT_NAME(major_id)='" + table + "' and state_desc='grant') as y";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(checkPerm, conn))
                        {
                            string ans = comm.ExecuteScalar().ToString();
                            if (ans == "1")
                            {
                                if (cont != null)
                                    cont.Enabled = true;
                                return true;
                            }
                            else
                            {
                                if (cont != null)
                                    cont.Enabled = false;
                                return false;
                            }
                        }
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                ConnectionLost(parent, MainForm);
                return false;
            }
        }
        public bool CheckAdminPerm(string user, string connectionString, Form parent, Form MainForm, Control cont=null)
        {
            string checkAdmin = "select count(Login_Name)\n" +
                                        "from dbo.dbRolesUsersMap (DEFAULT)\n" +
                                        "where Login_Name = '" + user + "' and db_role = 'db_owner'\n";
            try
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand comm = new SqlCommand(checkAdmin, conn))
                        {
                            string ans = comm.ExecuteScalar().ToString();
                            if (ans == "1")
                            {
                                if (cont != null)
                                    cont.Enabled = true;
                                return true;
                            }
                            else
                            {
                                if (cont != null)
                                    cont.Enabled = false;
                                return false;
                            }
                        }
                    }
                }
                catch(SqlException)
                {
                    CommandFailed();
                    return false;
                }
            }
            catch(SqlException)
            {
                ConnectionLost(parent, MainForm);
                return false;
            }
        }
        public void ConnectionLost(Form parent , Form MainForm)
        {
            MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ((Main_Form)MainForm).Disconnected();
            parent.Close();
        }

        public void CommandFailed()
        {
            MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
