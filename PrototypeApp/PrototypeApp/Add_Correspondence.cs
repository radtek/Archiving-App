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

namespace PolyDoc
{
    public partial class Add_Correspondence : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc gf = new GlobalFunc();
        public Add_Correspondence()
        {
            InitializeComponent();
            Browse.FlatAppearance.BorderColor = Color.White;
            Add.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
        }

        private void Browse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Browse_File_Wind = new OpenFileDialog();
            if (Browse_File_Wind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string loc = Browse_File_Wind.FileName;
                File_Name.Text = Path.GetFileNameWithoutExtension(loc);
                File_Path.Text = Path.GetDirectoryName(loc);
                File_Extension.Text = Path.GetExtension(loc);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = File_Name.Text.Replace("'", "''"), path = File_Path.Text.Replace("'", "''"), ext = File_Extension.Text.Replace("'", "''");
            if (name.Length == 0 || path.Length == 0 || ext.Length == 0 || Subject.Text.Length==0 || SRName.Text.Length==0)
            {
                MessageBox.Show("Please, enter all file info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(File_Path.Text + "\\" + File_Name.Text + File_Extension.Text))
            {
                MessageBox.Show("Error 404.\nCouldn't find the file in the chosen path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gf.CheckExistance(File_Name.Text + "-" + File_Path.Text + "-" + File_Extension.Text, "correspondence", connectionString))
            {
                MessageBox.Show("File already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string insert_correspondence = "insert into correspondence(name , path , extension , [date] , subject , srname , sr) values (N'" + name + "',N'" + path + "','" + ext + "','" + Date.Text.Replace("/", "-") + "',N'"+Subject.Text+"',N'"+SRName.Text+"','";
            if (Sent.Checked) insert_correspondence += "Sent')";
            else insert_correspondence += "Received')";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(insert_correspondence, conn);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully added file info!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
