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
    public partial class Main_Form : Form
    {
        public string connectionString="";
        public string user;
        AnimationFunc Anim = new AnimationFunc();
        GlobalFunc GF = new GlobalFunc();
        public Main_Form()
        {
            InitializeComponent();
            Media.FlatAppearance.BorderColor = Color.White;
            Correspondence.FlatAppearance.BorderColor = Color.White;
            Testemonial.FlatAppearance.BorderColor = Color.White;
            AddUser.FlatAppearance.BorderColor = Color.White;
            Logout.FlatAppearance.BorderColor = Color.White;
            Anim.AddAnimation(Media , "Media" , 86 , 347);
            Anim.AddAnimation(Correspondence , "Correspondence", 86, 347);
            Anim.AddAnimation(Testemonial, "Testemonial", 86, 347);
            Login_Logout();
        }
        
        public void Login_Logout()
        {
            this.Visible = false;
            Login_Form form = new Login_Form();
            form.ShowDialog();
            connectionString = form.connectionString;
            user = form.user;
            this.Visible = true;
            CheckState();
        }

        public void CheckState()
        {
            Server.Text = GF.GetConnection("","",1);
            Database.Text = GF.GetConnection("","",2);
            UserName.Text = user;
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                State.ForeColor = Color.Red;
                State.Text = "Not Connected.";
                Media.Enabled = false;
                Correspondence.Enabled = false;
                AddUser.Visible = false;
                AdminLabel.Visible = false;
                return;
            }
            Media.Enabled = true;
            Correspondence.Enabled = true;
            AddUser.Visible = true;
            AdminLabel.Visible = true;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT count(name) FROM master.sys.server_principals  WHERE    IS_SRVROLEMEMBER ('sysadmin',name) = 1 and name ='" + user + "'", conn);
            try
            {
                string check = comm.ExecuteScalar().ToString();
                if (check != "0")
                {
                    AddUser.Visible = true;
                    AdminLabel.Visible = true;
                }
                else
                {
                    AddUser.Visible = false;
                    AdminLabel.Visible = false;
                }
            }
            catch(SqlException)
            {
                AddUser.Visible = false;
            }
            comm = new SqlCommand("select * from media", conn);
            try
            {
                comm.ExecuteScalar();
            }
            catch(SqlException)
            {
                Media.Enabled = false;
            }
            comm = new SqlCommand("select * from correspondence", conn);
            try
            {
                comm.ExecuteScalar();
            }
            catch (SqlException)
            {
                Correspondence.Enabled = false;
            }
            State.ForeColor = Color.Green;
            State.Text = "Connected.";
        }

        private void Media_Click(object sender, EventArgs e)
        {
            if (State.ForeColor == Color.Red)
            {
                MessageBox.Show("Not connected to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Media_Form form = new Media_Form();
            form.ShowDialog();
        }

        private void Correspondence_Click(object sender, EventArgs e)
        {
            if (State.ForeColor == Color.Red)
            {
                MessageBox.Show("Not connected to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Correspondence_Form form = new Correspondence_Form();
            form.ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Login_Logout();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Settings_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Logout, "Logout");
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Add_User_Form form = new Add_User_Form();
            form.Show();
        }

        private void AddUser_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.AddUser, "Add User");
        }

        private void AdminLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.AdminLabel, "Logged in as Admin");
        }

        private void Testemonial_Click(object sender, EventArgs e)
        {
            Testemonial_Form form = new Testemonial_Form();
            form.ShowDialog();
        }
    }
}
