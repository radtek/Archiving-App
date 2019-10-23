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

namespace PolyDoc
{
    public partial class Admin_Settings_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Admin_Settings_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            GF.EditButtons(CreateUserP);
            GF.EditButtons(ManageUserP);
            ShowCreate();
        }

        private void ShowCreate()
        {
            ManageUserP.Visible = false;
            CreateUserP.Visible = true;
        }

        private void ShowManage()
        {
            string get_users = "SELECT Login_Name as [User] FROM dbo.dbRolesUsersMap (DEFAULT)"+
                               "where db_role = 'db_owner' or db_role = 'db_datareader'";
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
                            ManageUserP.Visible = true;
                            CreateUserP.Visible = false;
                        }
                    }
                    catch(SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                }
            }
            catch(SqlException)
            {
                GF.ConnectionLost(this , MainForm);
                return;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (UserName.Text.Length == 0 || Password.Text.Length == 0 || PasswordCon.Text.Length == 0)
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UserName.Text.Replace("'", "''") != UserName.Text || Password.Text.Replace("'", "''") != Password.Text)
            {
                MessageBox.Show("Character ' is forbidden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Password.Text != PasswordCon.Text)
            {
                MessageBox.Show("Password and Confirm Password fields does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string get_users = "select count(name) from master.sys.server_principals where name='" + UserName.Text.Replace("'", "''") + "'";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string createQ = null;
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(get_users, conn))
                        {
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
                            if (check != "0")
                            {
                                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            createQ = "USE [master] " +
                                             "CREATE LOGIN [--username--] WITH PASSWORD=N'--password--', DEFAULT_DATABASE=[--database--], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF " +
                                             "USE [--database--] " +
                                             "CREATE USER [--username--] FOR LOGIN [--username--]\n";
                            if (Admin.Checked)
                            {
                                createQ += "USE [--database--] " +
                                           "ALTER ROLE [db_owner] ADD MEMBER [--username--] " +
                                           "exec master..sp_addsrvrolemember @loginame=N'--username--' , @rolename = N'sysadmin'\n";
                            }
                            else
                            {
                                createQ += "USE [--database--] " +
                                           "ALTER ROLE [db_datareader] ADD MEMBER [--username--] " +
                                           "USE [--database--] " +
                                           "ALTER ROLE [db_datawriter] ADD MEMBER [--username--]\n";
                            }
                            createQ = createQ.Replace("--username--", UserName.Text);
                            createQ = createQ.Replace("--password--", Password.Text);
                            createQ = createQ.Replace("--database--", ((Main_Form)MainForm).database);
                            if (TablePanel.Enabled)
                            {
                                createQ += "deny all on Testemonial to [" + UserName.Text + "]\n";
                                createQ += "deny all on Expenses to [" + UserName.Text + "]\n";
                                if (Testemonial_RO.Checked)
                                {
                                    createQ += "grant select on Testemonial to [" + UserName.Text + "]\n";
                                    createQ += "grant select on professions to [" + UserName.Text + "]\n";
                                    createQ += "grant select on locations to [" + UserName.Text + "]\n";
                                }
                                if (Testemonial_FC.Checked)
                                {
                                    createQ += "grant all on Testemonial to [" + UserName.Text + "]\n";
                                    createQ += "grant all on professions to [" + UserName.Text + "]\n";
                                    createQ += "grant all on locations to [" + UserName.Text + "]\n";
                                }
                                if (HR_RO.Checked)
                                {
                                    createQ += "grant select on HR to [" + UserName.Text + "]\n";
                                    createQ += "grant select on Jobs to [" + UserName.Text + "]\n";
                                }
                                if (HR_FC.Checked)
                                {
                                    createQ += "grant all on HR to [" + UserName.Text + "]\n";
                                    createQ += "grant all on Jobs to [" + UserName.Text + "]\n";
                                }
                                if (Projects_RO.Checked)
                                    createQ += "grant select on Projects to [" + UserName.Text + "]\n";
                                if (Projects_FC.Checked)
                                    createQ += "grant all on Projects to [" + UserName.Text + "]\n";
                                if (Expenses_RO.Checked)
                                    createQ += "grant select on Expenses to [" + UserName.Text + "]\n";
                                if (Expenses_FC.Checked)
                                    createQ += "grant all on Expenses to [" + UserName.Text + "]\n";
                            }
                        }
                    }
                    catch(SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(createQ, conn))
                        {
                            comm.ExecuteNonQuery();
                            MessageBox.Show("Account created successfully!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
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
                GF.ConnectionLost(this, MainForm);
                return;
            }
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

        private void DeleteUsers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in Users_Grid.SelectedRows)
                    {
                        string remove = "DROP USER [" + row.Cells[0].Value.ToString() + "]\n" +
                                        "USE[master]\nDROP LOGIN[" + row.Cells[0].Value.ToString() + "]\n";
                        try
                        {
                            using (SqlCommand comm = new SqlCommand(remove, conn))
                            {

                                comm.ExecuteNonQuery();
                            }
                        }
                        catch (SqlException)
                        {
                            GF.CommandFailed();
                            return;
                        }
                    }
                }
            }
            catch(SqlException)
            {
                GF.ConnectionLost(this , MainForm);
                return;
            }
        }
        private void RowMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete")
            {
                DeleteUsers();
            }
            ShowManage();
        }

        private void ViewUser()
        {
            View_Edit_User form = new View_Edit_User(Users_Grid.CurrentRow.Cells["User"].Value.ToString());
            form.ShowDialog();
            form.Dispose();
            if(!GF.IsServerConnected(connectionString))
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
        }
        private void Users_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            ViewUser();
        }

        private void View_Click(object sender, EventArgs e)
        {
            ViewUser();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteUsers();
            ShowManage();
        }
    }
}
