using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyDocServer
{
    public partial class ServerLogin_Form : Form
    {
        ServerGlobalFunc GF = new ServerGlobalFunc();
        public string connectionString = "";
        public string server;

        public ServerLogin_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            ServerN.Text = GF.GetServer();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void checkConn()
        {
            string serverN = null;
            this.Invoke((MethodInvoker)delegate
            {
                serverN = ServerN.Text;
            });
            connectionString = GF.GetConnection(null, null, "Windows Authentication", serverN, "master");
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
            server = serverN;
            this.Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (!GF.CheckTextBoxes(this))
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Process.Text = "Connecting to database server...";
            Bar.Style = ProgressBarStyle.Marquee;
            Bar.MarqueeAnimationSpeed = 30;
            Thread checkConnection = new Thread(() => checkConn());
            checkConnection.Start();
        }
    }
}
