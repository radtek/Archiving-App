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
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace PolyDocServer
{
    class ServerGlobalFunc
    {
        private readonly string LogsLoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/PolyDoc Archiving Software/Logs/DatabaseInfo.txt";
        private readonly string DataLoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/PolyDoc Archiving Software/Data";

        public const string MainFolderName = "PolyDoc Storage";
        public const string FilesDirectory = @"\\192.168.1.5\" + MainFolderName;
        public string[] ModuleNames = { "Testemonial", "Expenses" , "Projects" , "HR"};

        public void CheckLogs()
        {
            if (!File.Exists(LogsLoc))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/PolyDoc Archiving Software/Logs");
                using (StreamWriter outputFile = new StreamWriter(LogsLoc))
                {
                    outputFile.WriteLine("Server=" + Environment.NewLine + "Database=" + Environment.NewLine + "Authentication=");
                }
            }
        }

        public string GetConnection(string user, string pass, string authentication, string server = null, string database = null)
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
            if (authentication == "SQL Server Authentication")
                connectionString = "Data Source=" + server + ";Initial Catalog =" + database + "; User id=" + user + ";Password=" + pass + ";";
            else if (authentication == "Windows Authentication")
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
        public void UpdateLogs(string server, string database, string authentication)
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
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                conn.Close();
                return true;
            }
            catch (SqlException)
            {
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

        public bool CheckExtension(string x, string extensions)
        {
            string temp = "";
            bool start = false;
            foreach (char c in extensions)
            {
                if (c == '*')
                {
                    start = true;
                    continue;
                }
                if (c == ')' || c == '|')
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
        public bool CheckExistance(string x, string table, string connectionString)
        {
            string[] pk = x.Split('-');
            string check = "select count(name) from " + table + " where name=N'" + pk[0] + "' and path=N'" + pk[1] + "' and extension='" + pk[2] + "'";
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
        public void DeleteRecords(DataGridView Grid, string table, string cell1, string cell2, string cell3, string connectionString)
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
                            using (new NetworkConnection(FilesDirectory, new NetworkCredential(table + "FULL", "123")))
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
            catch (SqlException)
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Successfully deleted selected records!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (c.Text == "")
                    return false;
                bool allSpaces = true;
                foreach (char ch in c.Text)
                    if (ch != ' ')
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
            foreach (char c in pass)
            {
                if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z') && c != '_' && (c < '0' || c > '9'))
                    return false;
            }
            return true;
        }

        public bool ModuleExists(string mod)
        {
            foreach(string c in ModuleNames)
            {
                if (mod == c)
                    return true;
            }
            return false;
        }
        public void ConnectionLost()
        {
            MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CommandFailed()
        {
            MessageBox.Show("Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
