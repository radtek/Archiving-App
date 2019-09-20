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
        AnimationFunc Anim = new AnimationFunc();
        GlobalFunc GF = new GlobalFunc();
        public Main_Form()
        {
            InitializeComponent();
            byte[] fontData = Properties.Resources.Uni_Sans_Heavy;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Uni_Sans_Heavy.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Uni_Sans_Heavy.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            myFont = new Font(fonts.Families[0], 10.0F);

            Media.FlatAppearance.BorderColor = Color.White;
            Correspondence.FlatAppearance.BorderColor = Color.White;
            Testemonial.FlatAppearance.BorderColor = Color.White;
            Expenses.FlatAppearance.BorderColor = Color.White;
            AddUser.FlatAppearance.BorderColor = Color.White;
            Settings.FlatAppearance.BorderColor = Color.White;
            Logout.FlatAppearance.BorderColor = Color.White;
            Reconnect.FlatAppearance.BorderColor = Color.White;
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
                Disconnected();
                return;
            }
            Media.Enabled = true;
            Correspondence.Enabled = true;
            Testemonial.Enabled = true;
            Expenses.Enabled = true;
            AddUser.Visible = false;
            AddUser.Enabled = false;
            AdminLabel.Visible = false;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select count(m.name) from sys.database_role_members rm join sys.database_principals p on rm.role_principal_id = p.principal_id join sys.database_principals m on rm.member_principal_id=m.principal_id where m.name='" + user + "' and p.name='db_owner'", conn);
            try
            {
                string check = comm.ExecuteScalar().ToString();
                if (check != "0")
                {
                    AddUser.Visible = true;
                    AddUser.Enabled = true;
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
            AddUser.Enabled = false;
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
            ToolTip1.SetToolTip(this.Logout, "Logout");
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Add_User_Form form = new Add_User_Form();
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
            ToolTip1.SetToolTip(this.AddUser, "Add User");
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

        private void Settings_MouseHover_1(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Settings, "Settings");
        }

        private void Expenses_Click(object sender, EventArgs e)
        {

        }
    }
}
