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

namespace Apex
{
    public partial class Login_Form : Form
    {
        GlobalFunc GF = new GlobalFunc();
        public string connectionString="";
        public string user;
        public string server;
        public string database;

        public Login_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            ServerN.Text = GF.GetServer();
            DatabaseN.Text = GF.GetDatabase();
            //
            UserName.Text = "maged";
            Password.Text = "123";
            //
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void checkConn()
        {
            connectionString = GF.GetConnection(UserName.Text, Password.Text, ServerN.Text, DatabaseN.Text);
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Invoke((MethodInvoker)delegate
                {
                    Process.Text = "";
                    Bar.Style = ProgressBarStyle.Continuous;
                    Bar.MarqueeAnimationSpeed = 0;
                });
                return;
            }
            GF.UpdateLogs(ServerN.Text, DatabaseN.Text);
            connectionString = GF.GetConnection(UserName.Text, Password.Text);
            user = UserName.Text;
            server = ServerN.Text;
            database = DatabaseN.Text;
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            }); 
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Process.Text = "Connecting to database server...";
            Bar.Style = ProgressBarStyle.Marquee;
            Bar.MarqueeAnimationSpeed = 30;
            Thread checkConnection = new Thread(() => checkConn());
            checkConnection.Start();
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void CreateDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetupServer_Form form = new SetupServer_Form();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

                using (new NetworkConnection(@"\\192.168.1.5\CECF", new NetworkCredential("TestemonialFULL", "123")))
                {
                    //File.Delete(@"\\192.168.1.5\CECF\21192544_157393734843533_8844334447167507216_n.jpg");
                }
            //}
            //catch(Exception)
            //{
              //  MessageBox.Show("Could not open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
