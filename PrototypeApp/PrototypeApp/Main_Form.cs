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

namespace PolyDoc
{
    public partial class Main_Form : Form
    {
        public string connectionString="";
        public string user;
        public string server;
        public string database;
        private readonly AnimationFunc Anim = new AnimationFunc();
        private readonly GlobalFunc GF = new GlobalFunc();
        public Main_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            Anim.AddAnimation(Testemonial, "Testemonials", 86, 347);
            Anim.AddAnimation(Expenses, "Expenses", 86, 347);
            Anim.AddAnimation(Projects, "Projects", 86, 347);
            Anim.AddAnimation(HR, "HR", 86, 347);
            Login_Logout();
        }
        
        public void Login_Logout()
        {
            this.Visible = false;
            Login_Form form = new Login_Form();
            form.ShowDialog();
            connectionString = form.connectionString;
            if (connectionString == "")
                System.Environment.Exit(1);
            user = form.user;
            server = form.server;
            database = form.database;
            if (user == null)
            {
                user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }
            this.Visible = true;
            CheckState();
        }

        public void CheckState()
        {
            Server.Text = server;
            Database.Text = database;
            UserName.Text = user;
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Disconnected();
                return;
            }
            foreach(Button b in Controls.OfType<Button>())
            {
                b.Enabled = true;
            }
            AdminSettings.Visible = false;
            AdminSettings.Enabled = false;
            AdminLabel.Visible = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (GF.CheckAdminPerm(user, connectionString, this, this))
                    {
                        AdminSettings.Visible = true;
                        AdminSettings.Enabled = true;
                        AdminLabel.Visible = true;
                    }
                    SqlCommand comm = new SqlCommand("select * from testemonial", conn);
                    try
                    {
                        comm.ExecuteScalar();
                        comm.Dispose();
                    }
                    catch (SqlException)
                    {
                        Testemonial.Enabled = false;
                    }
                    comm = new SqlCommand("select * from Expenses", conn);
                    try
                    {
                        comm.ExecuteScalar();
                        comm.Dispose();
                    }
                    catch (SqlException)
                    {
                        Expenses.Enabled = false;
                    }
                    comm = new SqlCommand("select * from Projects", conn);
                    try
                    {
                        comm.ExecuteScalar();
                        comm.Dispose();
                    }
                    catch (SqlException)
                    {
                        Projects.Enabled = false;
                    }
                    comm = new SqlCommand("select * from HR", conn);
                    try
                    {
                        comm.ExecuteScalar();
                        comm.Dispose();
                    }
                    catch (SqlException)
                    {
                        HR.Enabled = false;
                    }
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Server Connection Lost." , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                Disconnected();
                return;
            }
            State.ForeColor = Color.Green;
            State.Text = "Connected.";
        }

        public void Disconnected()
        {
            State.Text = "Disconnected.";
            State.ForeColor = Color.Red;
            foreach (Button b in Controls.OfType<Button>())
            {
                b.Enabled = false;
            }
            Reconnect.Enabled = true;
            Logout.Enabled = true;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings_Form form = new Settings_Form();
            form.ShowDialog();
            form.Dispose();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Settings, "Settings");
            ToolTip1.Dispose();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Admin_Settings_Form form = new Admin_Settings_Form();
            form.ShowDialog();
            form.Dispose();
        }

        private void Testemonial_Click(object sender, EventArgs e)
        {
            Testemonials_Form form = new Testemonials_Form();
            form.ShowDialog();
            form.Dispose();
        }

        private void Reconnect_Click(object sender, EventArgs e)
        {
            CheckState();
        }

        private void AddUser_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.AdminSettings, "Admin Settings");
        }

        private void AdminLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.AdminLabel, "Logged in as Admin");
        }

        private void Reconnect_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Reconnect, "Reconnect");
        }

        private void Expenses_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            GF.EndServerConnection(connectionString);
            Login_Logout();
        }

        private void Logout_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Logout, "Logout");
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            Projects_Form form = new Projects_Form();
            form.ShowDialog();
            form.Dispose();
        }

        private void HR_Click(object sender, EventArgs e)
        {
            HR_Form form = new HR_Form();
            form.ShowDialog();
            form.Dispose();
        }
    }
}
