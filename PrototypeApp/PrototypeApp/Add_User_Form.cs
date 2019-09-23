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

namespace Apex
{
    public partial class Admin_Settings_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Admin_Settings_Form()
        {
            InitializeComponent();
            Close.FlatAppearance.BorderColor = Color.White;
            CreateUserB.FlatAppearance.BorderColor = Color.White;
            ManageUserB.FlatAppearance.BorderColor = Color.White;
            Create.FlatAppearance.BorderColor = Color.White;
            Add.FlatAppearance.BorderColor = Color.White;
            ShowCreate();
        }

        private void ShowCreate()
        {
            ManageUserP.Visible = false;
            CreateUserP.Visible = true;
        }

        private void ShowManage()
        {
            string get_users = "SELECT Login_Name as [User] , DB_Role as [Role] FROM dbo.dbRolesUsersMap (DEFAULT) where Login_Name != '" + ((Main_Form)MainForm).user+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            if(!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
            conn.Open();
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_users, conn);
            DataTable Data = new DataTable();
            sqlAdapt.Fill(Data);
            Users_Grid.DataSource = Data;
            conn.Close();
            ManageUserP.Visible = true;
            CreateUserP.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
            if (UserName.Text.Length==0 || Password.Text.Length == 0 || PasswordCon.Text.Length == 0)
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserName.Text.Replace("'", "''") != UserName.Text || Password.Text.Replace("'" , "''") != Password.Text)
            {
                MessageBox.Show("Character ' is forbidden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Password.Text != PasswordCon.Text)
            {
                MessageBox.Show("Password and Confirm Password fields does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string get_users = "select count(name) from master.sys.server_principals where name='"+UserName.Text.Replace("'","''")+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(get_users, conn);
            string check;
            try
            {
                check = comm.ExecuteScalar().ToString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error encountered while creating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (check!="0")
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string createQ = "USE [master]\nCREATE LOGIN [--username--] WITH PASSWORD=N'--password--', DEFAULT_DATABASE=[--database--], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF\nUSE [--database--]\nCREATE USER [--username--] FOR LOGIN [--username--]\n";
            if (Admin.Checked)
            {
                createQ += "USE [--database--]\nALTER ROLE [db_owner] ADD MEMBER [--username--]\nexec master..sp_addsrvrolemember @loginame=N'--username--' , @rolename = N'sysadmin'";
            }
            else
            {
                createQ += "USE [--database--]\nALTER ROLE [db_datareader] ADD MEMBER [--username--]\nUSE [--database--]\nALTER ROLE [db_datawriter] ADD MEMBER [--username--]\n";
            }
            createQ = createQ.Replace("--username--", UserName.Text);
            createQ = createQ.Replace("--password--", Password.Text);
            createQ = createQ.Replace("--database--", GF.GetConnection("", "", 2));
            if (TablePanel.Enabled)
            {
                createQ += "grant all on Testemonial to [" + UserName.Text + "]\n";
                createQ += "grant all on Expenses to [" + UserName.Text + "]\n";
                if (!Testemonial.Checked)
                    createQ += "deny all on Testemonial to [" + UserName.Text + "]\n";
                if (!Expenses.Checked)
                    createQ += "deny all on Expenses to [" + UserName.Text + "]\n";
            }
            comm = new SqlCommand(createQ, conn);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error encountered while creating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn.Close();
            MessageBox.Show("Account created successfully!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Add_User_Form_Load(object sender, EventArgs e)
        {

        }

        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
            if(!Admin.Checked)
            {
                TablePanel.Enabled = true;
                return;
            }
            TablePanel.Enabled = false;
            MessageBox.Show("Users with admin permissions can modify and delete the database and other users accounts.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUserB_Click(object sender, EventArgs e)
        {
            ShowCreate();
        }

        private void ManageUserB_Click(object sender, EventArgs e)
        {
            ShowManage();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
            if (UserName2.Text.Length == 0)
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(UserName2.Text.Replace("'" , "''") != UserName2.Text)
            {
                MessageBox.Show("Character ' is forbidden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string check = "SELECT count(*) FROM dbo.dbRolesUsersMap (DEFAULT) where Login_Name='"+UserName2.Text.Replace("'" , "''")+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(check, conn);
            string res = comm.ExecuteScalar().ToString();
            if(res!="0")
            {
                string addQ = "";
                if (Admin2.Checked)
                {
                    addQ += "ALTER ROLE [db_owner] ADD MEMBER [--username--]\nexec master..sp_addsrvrolemember @loginame=N'--username--' , @rolename = N'sysadmin'\n";
                }
                else
                {
                    addQ += "ALTER ROLE [db_datareader] ADD MEMBER [--username--]\nALTER ROLE [db_datawriter] ADD MEMBER [--username--]\n";
                }
                addQ = addQ.Replace("--username--", UserName2.Text);
                if (TablePanel2.Enabled)
                {
                    addQ += "grant all on Testemonial to [" + UserName2.Text + "]\n";
                    addQ += "grant all on Expenses to [" + UserName2.Text + "]\n";
                    if (!Testemonial2.Checked)
                        addQ += "deny all on Testemonial to [" + UserName2.Text + "]\n";
                    if (!Expenses2.Checked)
                        addQ += "deny all on Expenses to [" + UserName2.Text + "]\n";
                }
                comm = new SqlCommand(addQ, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                ShowManage();
            }
            else
            {
                string addQ = "CREATE USER [--username--] FOR LOGIN [--username--]\n";
                if (Admin2.Checked)
                {
                    addQ += "ALTER ROLE [db_owner] ADD MEMBER [--username--]\nexec master..sp_addsrvrolemember @loginame=N'--username--' , @rolename = N'sysadmin'\n";
                }
                else
                {
                    addQ += "ALTER ROLE [db_datareader] ADD MEMBER [--username--]\nALTER ROLE [db_datawriter] ADD MEMBER [--username--]\n";
                }
                addQ = addQ.Replace("--username--", UserName2.Text);
                if (TablePanel2.Enabled)
                {
                    addQ += "grant all on Testemonial to [" + UserName2.Text + "]\n";
                    addQ += "grant all on Expenses to [" + UserName2.Text + "]\n";
                    if (!Testemonial2.Checked)
                        addQ += "deny all on Testemonial to [" + UserName2.Text + "]\n";
                    if (!Expenses2.Checked)
                        addQ += "deny all on Expenses to [" + UserName2.Text + "]\n";
                }
                comm = new SqlCommand(addQ, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                ShowManage();
            }
        }

        private void Admin2_CheckedChanged(object sender, EventArgs e)
        {
            if (!Admin2.Checked)
            {
                TablePanel2.Enabled = true;
                return;
            }
            TablePanel2.Enabled = false;
            MessageBox.Show("Users with admin permissions can modify and delete the database and other users accounts.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Users_Grid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int pos = Users_Grid.HitTest(e.X, e.Y).RowIndex;
                if (pos < 0)
                    return;
                if (!Users_Grid.Rows[pos].Selected)
                {
                    Users_Grid.ClearSelection();
                    Users_Grid.Rows[pos].Selected = true;
                }
                RowMenu.Show(Users_Grid, new Point(e.X, e.Y));
            }
        }

        private void RowMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if(!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
            conn.Open();
            if (e.ClickedItem.Text == "Delete")
            {
                foreach (DataGridViewRow row in Users_Grid.SelectedRows)
                {
                    string remove = "DROP USER [" + row.Cells[0].Value.ToString() + "]";
                    SqlCommand comm = new SqlCommand(remove, conn);
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Error encountered while deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ShowManage();
                        return;
                    }
                }
            }
            conn.Close();
            ShowManage();
        }
    }
}
