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
        public const string FilesDirectory = @"\\192.168.1.5\" + MainFolderName;

        public void CheckLogs()
        {
            if (!File.Exists(LogsLoc))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Apex Archiving Software/Logs");
                using (StreamWriter outputFile = new StreamWriter(LogsLoc))
                {
                    outputFile.WriteLine("Server=" + Environment.NewLine + "Database=");
                }
            }
        }

        public string GetConnection(string user , string pass , string server=null , string database=null)
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
            string connectionString = "Data Source=" + server + ";Initial Catalog =" + database + "; User id=" + user +";Password=" + pass + ";";
            return connectionString;
        }

        public string GetServer()
        {
            CheckLogs();
            string server = null, database;
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
            return server;
        }

        public string GetDatabase()
        {
            CheckLogs();
            string server, database = null;
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
            return database;
        }

        public void UpdateLogs(string server , string database)
        {
            CheckLogs();
            using (StreamWriter outputFile = new StreamWriter(LogsLoc))
            {
                outputFile.WriteLine("Server=" + server + Environment.NewLine + "Database=" + database);
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
        public void DeleteRecords(DataGridView Grid , string table , string cell1 , string cell2 , string cell3 , string connectionString)
        {
            if (Grid.SelectedRows.Count == 0)
                return;
            DialogResult res = MessageBox.Show("Are you sure you want to permanently delete the selected records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            foreach (DataGridViewRow r in Grid.SelectedRows)
            {
                string name = r.Cells[cell1].Value.ToString().Replace("'" , "''"), path = r.Cells[cell2].Value.ToString().Replace("'", "''"), ext = r.Cells[cell3].Value.ToString();
                string delete_records = "delete from " + table + " where name = N'" + name + "' and path =N'" + path + "' and extension ='" + ext + "'";
                SqlCommand comm = new SqlCommand(delete_records, conn);
                comm.ExecuteNonQuery();
                Grid.Rows.Remove(r);
                comm.Dispose();
            }
            MessageBox.Show("Successfully deleted selected records!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
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
        public string GetCode(string table , Dictionary<string, bool> map , string connectionString)
        {
            if(table=="Testemonial")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string code = "TES" + DateTime.Now.Year.ToString();
                string check = "select count(*) from Testemonial where code = '";
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
                while (res == "1" || (map.ContainsKey(finalCode) && map[finalCode]==true));
                conn.Close();
                return finalCode;
            }
            return "Invalid";
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
                if (c.Text == "")
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
    }
}
