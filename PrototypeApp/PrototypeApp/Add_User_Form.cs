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
    public partial class Add_User_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Add_User_Form()
        {
            InitializeComponent();
            Close.FlatAppearance.BorderColor = Color.White;
            Create.FlatAppearance.BorderColor = Color.White;
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

            if(Password.Text != PasswordCon.Text)
            {
                MessageBox.Show("Password and Confirm Password fields does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string get_users = "select count(name) from master.sys.server_principals where name='"+UserName.Text.Replace("'","''")+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(get_users, conn);
            string check = comm.ExecuteScalar().ToString();
            if(check!="0")
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
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Account created successfully!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
    }
}
