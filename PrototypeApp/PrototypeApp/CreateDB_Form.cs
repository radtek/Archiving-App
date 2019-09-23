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
using System.Drawing.Text;

namespace Apex
{
    public partial class CreateDB_Form : Form
    {
        public string connectionString = "";
        GlobalFunc GF = new GlobalFunc();
        public CreateDB_Form()
        {
            InitializeComponent();
            Login.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
            Cancel2.FlatAppearance.BorderColor = Color.White;
            Create.FlatAppearance.BorderColor = Color.White;
            Previous();
        }

        private void Next()
        {
            CreateDBP.Visible = true;
            LoginP.Visible = false;
        }

        private void Previous()
        {
            CreateDBP.Visible = false;
            Login.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string user = UserName.Text;
            string database = "master";
            string server = ServerN.Text;
            string pass = Password.Text;
            connectionString = "Data Source=" + server + ";Initial Catalog =" + database + "; User id=" + user + ";Password=" + pass + ";";
            if(!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Next();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Process.Text = "Creating database...";
            Bar.Style = ProgressBarStyle.Marquee;
            Bar.MarqueeAnimationSpeed = 30;
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Previous();
                Process.Text = "";
                Bar.Style = ProgressBarStyle.Continuous;
                Bar.MarqueeAnimationSpeed = 0;
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string createDB = "CREATE DATABASE [" + DatabaseN.Text + "]\n";
            string createFunc = "CREATE FUNCTION dbo.dbRolesUsersMap (@dbRole SYSNAME = '%')\nRETURNS TABLE\nAS\nRETURN (\nSELECT \nUser_Type = \nCASE mmbrp.[type] \nWHEN 'G' THEN 'Windows Group' \nWHEN 'S' THEN 'SQL User' \nWHEN 'U' THEN 'Windows User' \nEND,\nDatabase_User_Name = mmbrp.[name],\nLogin_Name = ul.[name],\nDB_Role = rolp.[name]\nFROM sys.database_role_members mmbr,\nsys.database_principals rolp,\nsys.database_principals mmbrp,\nsys.server_principals ul\nWHERE Upper (mmbrp.[type]) IN ( 'S', 'U', 'G' )\nAND Upper (mmbrp.[name]) NOT IN ('SYS','INFORMATION_SCHEMA')\nAND rolp.[principal_id] = mmbr.[role_principal_id]\nAND mmbrp.[principal_id] = mmbr.[member_principal_id]\nAND ul.[sid] = mmbrp.[sid]\nAND rolp.[name] LIKE '%' + @dbRole + '%'\n)\n";
            SqlCommand comm = new SqlCommand(createDB, conn);
            if (!CheckConnection(comm, conn))
            {
                Process.Text = "";
                Bar.Style = ProgressBarStyle.Continuous;
                Bar.MarqueeAnimationSpeed = 0;
                return;
            }
            conn.Close();
            if (!GF.IsServerConnected(connectionString.Replace("master", DatabaseN.Text)))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Previous();
                Process.Text = "";
                Bar.Style = ProgressBarStyle.Continuous;
                Bar.MarqueeAnimationSpeed = 0;
                return;
            }
            conn = new SqlConnection(connectionString.Replace("master" , DatabaseN.Text));
            conn.Open();
            comm = new SqlCommand(createFunc, conn);
            if (!CheckConnection(comm , conn))
                return;
            string createTes = "CREATE TABLE Testemonial\n(\nInterName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nLocation VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nProfession VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nPath VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nExtension VARCHAR(10) NOT NULL,\nDate DATE NOT NULL,\nLocationN VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nCode VARCHAR(20) NOT NULL,\nPRIMARY KEY(Name, Path, Extension),\nUNIQUE(Code)\n);\n";
            string createExp = "CREATE TABLE Expenses\n(\nName VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nPath VARCHAR(70)COLLATE Arabic_CI_AI_KS_WS NOT NULL,\nExtension VARCHAR(10) NOT NULL,\nPRIMARY KEY(Name, Path, Extension)\n);\n";
            string createQ = createTes + createExp;
            comm = new SqlCommand(createQ, conn);
            if (!CheckConnection(comm, conn))
            {
                Process.Text = "";
                Bar.Style = ProgressBarStyle.Continuous;
                Bar.MarqueeAnimationSpeed = 0;
                return;
            }
            conn.Close();
            MessageBox.Show("Database created Successfully!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private bool CheckConnection(SqlCommand comm , SqlConnection conn)
        {
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not create database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!GF.IsServerConnected(connectionString))
                {
                    MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Previous();
                }
                conn.Close();
                return false;
            }
            return true;
        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
