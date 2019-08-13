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
    public partial class Add_User_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Add_User_Form()
        {
            InitializeComponent();
            Close.FlatAppearance.BorderColor = Color.White;
            Create.FlatAppearance.BorderColor = Color.White;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(UserName.Text.Length==0 || DatabaseN.Text.Length == 0 || Password.Text.Length == 0 || PasswordCon.Text.Length == 0)
            {
                MessageBox.Show("Please fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(Password.Text != PasswordCon.Text)
            {
                MessageBox.Show("Password and Confirm Password fields does not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string get_users = "select count(name) from master.sys.server_principals where default_database_name = '" + GF.GetConnection("", "", 2).Replace("'" , "''")+"' and name='"+UserName.Text.Replace("'","''")+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(get_users, conn);
            string check = comm.ExecuteScalar().ToString();
            if(check!="0")
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string createQ="";
            string loc = Directory.GetCurrentDirectory() + "/Logs";
            using (StreamReader file = new StreamReader(Path.Combine(loc, "CreateUser.txt")))
            {
                createQ = file.ReadToEnd();
                file.Close();
            }
            createQ = createQ.Replace("--username--", UserName.Text);
            createQ = createQ.Replace("--password--", Password.Text);
            createQ = createQ.Replace("--database--", DatabaseN.Text);
            if(AccessToMedia.Checked && !AccessToCorrespondence.Checked)
            {
                createQ += "deny all on correspondence to [" + UserName.Text + "]";
            }
            if (!AccessToMedia.Checked && AccessToCorrespondence.Checked)
            {
                createQ += "deny all on media to [" + UserName.Text + "]";
            }
            if (!AccessToMedia.Checked && !AccessToCorrespondence.Checked)
            {
                createQ += "deny all on correspondence to [" + UserName.Text + "]";
                createQ += "\ndeny all on media to [" + UserName.Text + "]";
            }
            comm = new SqlCommand(createQ, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Account created successfully!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Add_User_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
