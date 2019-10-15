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
    public partial class Main_Form : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;

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
            Anim.AddAnimation(Media , "Media" , 86 , 347);
            Anim.AddAnimation(Correspondence , "Correspondence", 86, 347);
            Anim.AddAnimation(Testemonial, "Testemonial", 86, 347);
            Anim.AddAnimation(Expenses, "Expenses", 86, 347);
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
            Media.Enabled = true;
            Correspondence.Enabled = true;
            Settings.Enabled = true;
            Testemonial.Enabled = true;
            Expenses.Enabled = true;
            AdminSettings.Visible = false;
            AdminSettings.Enabled = false;
            AdminLabel.Visible = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT count(*) FROM dbo.dbRolesUsersMap (DEFAULT) where Login_Name='"+user.Replace("'" , "''")+"' and DB_Role='db_owner'", conn);
            try
            {
                string check = comm.ExecuteScalar().ToString();
                if (check != "0")
                {
                    AdminSettings.Visible = true;
                    AdminSettings.Enabled = true;
                    AdminLabel.Visible = true;
                }
            }
            catch(SqlException)
            {
            }
            comm = new SqlCommand("select * from testemonial", conn);
            try
            {
                comm.ExecuteScalar();
            }
            catch (SqlException)
            {
                Testemonial.Enabled = false;
                Settings.Enabled = false;
            }
            comm = new SqlCommand("select * from Expenses", conn);
            try
            {
                comm.ExecuteScalar();
            }
            catch (SqlException)
            {
                Expenses.Enabled = false;
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
            conn.Close();
        }

        public void Disconnected()
        {
            State.Text = "Disconnected.";
            State.ForeColor = Color.Red;
            Testemonial.Enabled = false;
            Expenses.Enabled = false;
            AdminSettings.Enabled = false;
            Settings.Enabled = false;
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
            Settings_Form form = new Settings_Form();
            form.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Settings_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Settings, "Settings");
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Admin_Settings_Form form = new Admin_Settings_Form();
            form.Show();
        }

        private void Testemonial_Click(object sender, EventArgs e)
        {
            Testemonial_Form form = new Testemonial_Form();
            form.ShowDialog();
            
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
            Login_Logout();
        }

        private void Logout_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Logout, "Logout");
        }
    }
}
