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

namespace Apex
{
    class GlobalFunc
    {
        public string GetConnection(string user="" , string pass="" , int x=0)
        {
            string loc = Directory.GetCurrentDirectory()+"/Logs";
            string server = "", database = "";
            if(!File.Exists(loc+"/DatabaseInfo.txt"))
            {
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(loc, "DatabaseInfo.txt")))
                {
                    outputFile.WriteLine("Server=" + Environment.NewLine + "Database=");
                }
            }
            using (StreamReader file = new StreamReader(Path.Combine(loc, "DatabaseInfo.txt")))
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
            string connectionString = "Data Source=" + server + ";Initial Catalog =" + database + "; User id=" + user +";Password=" + pass + ";";
            if (x == 1)
                return server;
            if (x == 2)
                return database;
            else return connectionString;
        }

        public bool IsServerConnected(string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
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
            if (count == "0")
                return false;
            return true;
        }
        public string RemoveTime(string x)
        {
            string[] parts = x.Split('/');
            string res = parts[0] + "/" + parts[1] + "/" + parts[2][0] + parts[2][1] + parts[2][2] + parts[2][3];
            return res;
        }
        public void GetLocations(ComboBox Locs , bool Search)
        {
            StreamReader file = new StreamReader("Data/Locations.txt");
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
            else
                Locs.SelectedIndex = 0;
        }
        public void GetProfessions(ComboBox Pros , bool Search)
        {
            StreamReader file = new StreamReader("Data/Professions.txt");
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
            else
                Pros.SelectedIndex = 0;
        }
        public string GetCode(string table , Dictionary<string, bool> map , string connectionString)
        {
            if(table=="Testemonial")
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string code = "TES2019";
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
                }
                while (res == "1" || (map.ContainsKey(finalCode) && map[finalCode]==true));
                return finalCode;
            }
            return "Invalid";
        }
    }
}
