using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexServer
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string receive;
        public string text;
        public Form1()
        {
            InitializeComponent();
        }
        //SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;*/

        }

        /*private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate()
            {
                SqlConnection conn = new SqlConnection("Data Source = 192.168.1.6,49170; Initial Catalog = dbtest; User id = maged; Password = 123;");
                conn.Open();
                SqlDataAdapter sqlAdapt = new SqlDataAdapter(e.MessageString, conn);
                DataTable dt = new DataTable();
                sqlAdapt.Fill(dt);
                string reply = string.Empty;
                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        reply+=(array[i].ToString() + " | ");
                    }
                    reply+=(array[array.Length - 1].ToString());
                }
                
                txtStatus.Text += Environment.NewLine + e.MessageString;
                //txtStatus.Text = txtStatus.Text.Remove(txtStatus.Text.Length - 1);
                e.ReplyLine(string.Format("{0}", reply));
            });
        }*/

        private void run()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(txtHost.Text), int.Parse(txtPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;

            Sth1.RunWorkerAsync();
            Sth2.WorkerSupportsCancellation = true;
            run();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            run();
            /*txtStatus.Text += "Server starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            server.Start(ip,Convert.ToInt32(txtPort.Text));
            txtStatus.Text += Environment.NewLine + "Server started";*/
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
            }
        }*/

        private void Sth_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    txtStatus.Invoke((MethodInvoker)delegate ()
                    {
                        txtStatus.AppendText("You : " + receive + "\n");
                    });
                    receive = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void Sth2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                stw.WriteLine(text);
                txtStatus.Invoke((MethodInvoker)delegate ()
                {
                    txtStatus.AppendText("Me : " + text + "\n");
                });
            }
            else
            { MessageBox.Show("Send failed"); }
            Sth2.CancelAsync();
        }
    }
}
