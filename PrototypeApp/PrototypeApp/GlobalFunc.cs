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
using System.IO;

namespace PrototypeApp
{
    class GlobalFunc
    {
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
            if(table.ToLower() == "media")
            {
                string[] pk = x.Split('-');
                string check = "select count(name) from media where name='" + pk[0] + "' and path='" + pk[1] + "' and extension='" + pk[2] + "'";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand comm = new SqlCommand(check, conn);
                string count = comm.ExecuteScalar().ToString();
                if (count == "0")
                    return false;
                return true;
            }
            return false;
        }
    }
}
