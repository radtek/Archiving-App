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

namespace PrototypeApp
{
    public partial class Main_Form : Form
    {
        public string connectionString;

        public Main_Form()
        {
            InitializeComponent();
            connectionString = "Data Source=" + GetLocalIPAddress() + ",49170;Initial Catalog = Prototype; Integrated Security = True";
            Media.FlatAppearance.BorderColor = Color.White;
            Correspondence.FlatAppearance.BorderColor = Color.White;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void Images_Click(object sender, EventArgs e)
        {
            Images_Form form = new Images_Form();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FtpClient client = new FtpClient("192.168.1.21");
            client.Credentials = new NetworkCredential("FTP-user", "1234");
            client.Connect();
            client.Rename("/cover4.jpg", "/test.jpg");
        }
    }
}
