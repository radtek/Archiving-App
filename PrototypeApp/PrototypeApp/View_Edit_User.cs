using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex
{
    public partial class View_Edit_User : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        readonly string Database = ((Main_Form) MainForm).database;
        readonly string User;
        readonly GlobalFunc GF = new GlobalFunc();
        readonly List<string> Modules = new List<string>();
        public View_Edit_User(string UserName)
        {
            InitializeComponent();
            this.Text = UserName;
            User = UserName;
            GF.EditButtons(this);
            string getTables = "SELECT table_name as [Table] FROM information_schema.tables";
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using(SqlCommand comm = new SqlCommand(getTables , conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while(reader.Read())
                            {
                                Modules.Add(reader["Table"].ToString());
                            }
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
                GF.ConnectionLost(this , MainForm);
                return;
            }

            foreach (string c in Modules)
                Permissions_Grid.Rows.Add(c);
            ShowData();
        }

        void ShowData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string checkAdmin = "select count(Login_Name)\n" +
                                        "from dbo.dbRolesUsersMap (DEFAULT)\n" +
                                        "where Login_Name = '"+User.Replace("'" , "''")+"' and db_role = 'db_owner'\n";
                    using (SqlCommand comm = new SqlCommand(checkAdmin, conn))
                    {
                        string ans = comm.ExecuteScalar().ToString();
                        if (ans == "1")
                        {
                            AdminLabel.Visible = true;
                            Permissions_Grid.Rows.Clear();
                            Permissions_Grid.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
                            this.Size = new Size(816, 555);
                            Permissions_Grid.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
                            return;
                        }
                    }
                    int count = -1;
                    foreach (string c in Modules)
                    {
                        count++;
                        string checkRead = "SELECT count(Login_Name)\n" +
                               "FROM sys.database_permissions , (SELECT Database_User_Name , Login_Name , DB_Role FROM dbo.dbRolesUsersMap (DEFAULT)\n" +
                               "				                 where db_role = 'db_owner' or db_role = 'db_datareader') as x\n" +
                               "where DB_NAME()='" + Database.Replace("'", "''") + "' and USER_NAME(grantee_principal_id) != 'public' and Database_User_Name = USER_NAME(grantee_principal_id)" +
                               "and Login_Name = '" + User.Replace("'", "''") + "' and OBJECT_NAME(major_id) = '" + c.Replace("'", "''") + "' and permission_name = 'select' and state_desc = 'grant'";
                        string checkFullControl = "SELECT count(Login_Name) from (" +
                                                  "SELECT Login_Name\n" +
                                                  "FROM sys.database_permissions , (SELECT Database_User_Name , Login_Name , DB_Role FROM dbo.dbRolesUsersMap (DEFAULT)\n" +
                                                  "				                    where db_role = 'db_owner' or db_role = 'db_datareader') as x\n" +
                                                  "where DB_NAME()='" + Database.Replace("'", "''") + "' and USER_NAME(grantee_principal_id) != 'public' and Database_User_Name = USER_NAME(grantee_principal_id)\n" +
                                                  "and Login_Name='" + User.Replace("'" , "''") + "' and permission_name in ('delete' , 'insert' , 'references' , 'select' , 'update') and OBJECT_NAME(major_id)='" + c.Replace("'", "''") + "' and state_desc='grant'\n" +
                                                  "group by Login_Name\n" +
                                                  "having count(permission_name) = 5) as y\n";
                        using (SqlCommand comm = new SqlCommand(checkFullControl, conn))
                        {
                                string ans = comm.ExecuteScalar().ToString();
                            if (ans == "1")
                            {
                                Permissions_Grid.Rows[count].Cells[2].Value = true;
                                continue;
                            }
                        }
                        using (SqlCommand comm = new SqlCommand(checkRead, conn))
                        {
                            string ans = comm.ExecuteScalar().ToString();
                            if (ans == "1")
                            {
                                Permissions_Grid.Rows[count].Cells[1].Value = true;
                                continue;
                            }
                        }
                    }
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }



        }
        private void Permissions_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Permissions_Grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void Permissions_Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Permissions_Grid.CurrentRow == null)
                return;
            for (int i = 1; i < Permissions_Grid.Columns.Count; i++)
            {
                if (i != Permissions_Grid.CurrentCell.ColumnIndex)
                    Permissions_Grid.CurrentRow.Cells[i].Value = false;
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "";
            foreach (string c in Modules)
                query += "deny all on " + c + " to [" + User + "]\n";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand comm = new SqlCommand(query, conn))
                    {
                        comm.ExecuteNonQuery();
                    }
                }
                query = "";
                foreach (DataGridViewRow row in Permissions_Grid.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[1].Value) == true)
                        query += "grant select on " + row.Cells[0].Value.ToString() + " to [" + User + "]\n";
                    if (Convert.ToBoolean(row.Cells[2].Value) == true)
                        query += "grant all on " + row.Cells[0].Value.ToString() + " to [" + User + "]\n";
                }
                if (query != "")
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand comm = new SqlCommand(query, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                    }
                MessageBox.Show("Successfully changed user permissions!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            catch(SqlException)
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
        }
    }
}
