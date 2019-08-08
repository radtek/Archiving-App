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
        AnimationFunc Anim = new AnimationFunc();
        public Main_Form()
        {
            InitializeComponent();
            connectionString = "Data Source=" + "192.168.1.5" + ",49170;Initial Catalog = Prototype; Integrated Security = True";
            //MessageBox.Show(connectionString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Media.FlatAppearance.BorderColor = Color.White;
            Correspondence.FlatAppearance.BorderColor = Color.White;
            Anim.AddAnimation(Media , "Media" , 75 , 403);
            Anim.AddAnimation(Correspondence , "Correspondence", 75, 403);
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

        private void Media_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Media_Click(object sender, EventArgs e)
        {
            Media_Form form = new Media_Form();
            form.ShowDialog();
        }

        private void Correspondence_Click(object sender, EventArgs e)
        {
            Correspondence_Form form = new Correspondence_Form();
            form.ShowDialog();
        }
    }
}
