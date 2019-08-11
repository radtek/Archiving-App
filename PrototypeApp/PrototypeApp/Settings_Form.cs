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
using System.IO;

namespace Apex
{
    public partial class Settings_Form : Form
    {
        GlobalFunc GF = new GlobalFunc();
        public Settings_Form()
        {
            InitializeComponent();
            Done.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
            ServerN.Text = GF.GetConnection(1);
            DatabaseN.Text = GF.GetConnection(2);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + ServerN.Text + ";Initial Catalog =" + DatabaseN.Text + "; Integrated Security = True";
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string loc = Directory.GetCurrentDirectory();
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(loc, "DatabaseInfo.txt")))
            {
                outputFile.WriteLine("Server=" + ServerN.Text + Environment.NewLine + "Database=" + DatabaseN.Text);
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
