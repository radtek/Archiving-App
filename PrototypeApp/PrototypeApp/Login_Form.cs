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
            Authentication.Text = GF.GetAuthentication();
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
            string username=null, pass = null, authentication = null, serverN = null, databaseN = null;
            this.Invoke((MethodInvoker)delegate
            {
                username = UserName.Text;
                pass = Password.Text;
                authentication = Authentication.Text;
                serverN = ServerN.Text;
                databaseN = DatabaseN.Text;
            });
            connectionString = GF.GetConnection(username, pass , authentication , serverN, databaseN);
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
            GF.UpdateLogs(serverN, databaseN , authentication);
            connectionString = GF.GetConnection(username, pass , authentication);
            user = username;
            server = serverN;
            database = databaseN;
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            }); 
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(!GF.CheckTextBoxes(this))
            {
                MessageBox.Show("Please fill the whole form." , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            string x = "";
            //try
            //{

                //using (new NetworkConnection(@"\\192.168.1.5\CECF", new NetworkCredential("TestemonialREAD", "123")))
                //{
                  //  File.Delete(@"\\192.168.1.5\cecf\Testemonial\codes.txt");
                //}
            //}
            //catch(Exception)
            //{
              //  MessageBox.Show("Could not open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Authentication.Text == "Windows Authentication")
            {
                UserName.Enabled = false;
                Password.Enabled = false;
            }
            else if(Authentication.Text == "SQL Server Authentication")
            {
                UserName.Enabled = true;
                Password.Enabled = true;
            }
        }
    }
}
