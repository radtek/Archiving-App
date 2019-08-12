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
using Apex;

namespace Apex
{
    public partial class Main_Form : Form
    {
        public string connectionString="";
        string user;
        AnimationFunc Anim = new AnimationFunc();
        GlobalFunc GF = new GlobalFunc();
        string[] res = { "", "", "" };
        public Main_Form()
        {
            InitializeComponent();
            Media.FlatAppearance.BorderColor = Color.White;
            Correspondence.FlatAppearance.BorderColor = Color.White;
            Logout.FlatAppearance.BorderColor = Color.White;
            Anim.AddAnimation(Media , "Media" , 86 , 347);
            Anim.AddAnimation(Correspondence , "Correspondence", 86, 347);
            Login_Logout();
        }
        
        public void Login_Logout()
        {
            this.Visible = false;
            Login_Form form = new Login_Form();
            form.ShowDialog();
            connectionString = form.connectionString;
            user = form.user;
            string get_permissions = "";
            string loc = Directory.GetCurrentDirectory()+"/Logs";
            using (StreamReader file = new StreamReader(Path.Combine(loc, "PermissionsQ.txt")))
            {
                get_permissions = file.ReadLine();
                get_permissions += user;
                get_permissions += file.ReadLine();
                file.Close();
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(get_permissions , conn);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.Read())
            {
                res[0] = reader[0].ToString();
                res[1] = reader[1].ToString();
                res[2] = reader[2].ToString();
            }
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
                return;
            }
            Media.Enabled = true;
            Correspondence.Enabled = true;
            if (res[0] == "Media" && res[1] == "SELECT" && res[2] == "DENY")
            {
                Media.Enabled = false;
            }
            if (res[0] == "Correspondence" && res[1] == "SELECT" && res[2] == "DENY")
            {
                Correspondence.Enabled = false;
            }
            res[0] = "";
            res[1] = "";
            res[2] = "";
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
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.Logout, "Logout");
        }
    }
}
