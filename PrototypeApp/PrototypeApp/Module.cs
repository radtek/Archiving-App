using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDoc
{
    class Module
    {
        public string modName;
        public List<string> relatedTables;

        public Module(string name , List<string> related)
        {
            modName = name;
            relatedTables = related;
        }
        public void GrantOrDeny(string perm , bool grant , string user, string connectionString)
        {
            string q = "";
            if(grant)
            {
                q += "grant " + perm + " on " + modName + " to [" + user + "]\n";
                foreach(string c in relatedTables)
                {
                    q+= "grant " + perm + " on " + c + " to [" + user + "]\n";
                }
            }
            else
            {
                q += "deny " + perm + " on " + modName + " to [" + user + "]\n";
                foreach (string c in relatedTables)
                {
                    q += "deny " + perm + " on " + c + " to [" + user + "]\n";
                }
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(q, conn))
                {
                    comm.ExecuteNonQuery();
                }
            }
        }
    }
}
