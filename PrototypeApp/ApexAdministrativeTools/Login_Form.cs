using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apex
{
    public partial class Login_Form : Form
    {
        GlobalFunc GF = new GlobalFunc();
        public string connectionString = "";
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
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
