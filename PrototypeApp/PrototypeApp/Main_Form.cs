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


namespace PrototypeApp
{
    public partial class Main_Form : Form
    {
        public string connectionString;
        AnimationFunc Anim = new AnimationFunc();
        GlobalFunc GF = new GlobalFunc();
        public Main_Form()
        {
            InitializeComponent();
            Media.FlatAppearance.BorderColor = Color.White;
            Correspondence.FlatAppearance.BorderColor = Color.White;
            Settings.FlatAppearance.BorderColor = Color.White;
            Anim.AddAnimation(Media , "Media" , 86 , 302);
            Anim.AddAnimation(Correspondence , "Correspondence", 86, 302);
            connectionString = GF.GetConnection();
            CheckState();
        }
        
        public void CheckState()
        {
            Server.Text = GF.GetConnection(1);
            Database.Text = GF.GetConnection(2);
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                State.ForeColor = Color.Red;
                State.Text = "Not Connected.";
                return;
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
            Settings_Form form = new Settings_Form();
            form.ShowDialog();
            if(connectionString != GF.GetConnection())
            {
                connectionString = GF.GetConnection();
                CheckState();
            }
        }
    }
}
