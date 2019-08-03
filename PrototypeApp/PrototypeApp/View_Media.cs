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

namespace PrototypeApp
{
    public partial class View_Media : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        public View_Media(string name , string path , string ext)
        {
            InitializeComponent();

            File_Name.Text = name;
            File_Path.Text = path;
            File_Extension.Text = ext;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_desc = "select description from media where name = '" + name + "' and path ='" + path + "' and extension ='" + ext + "'";
            SqlCommand comm = new SqlCommand(get_desc, conn);
            File_Desc.Text = comm.ExecuteScalar().ToString();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
