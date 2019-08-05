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
    public partial class Add_Media : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc gf = new GlobalFunc();
        string imagesf = "Image (*.bmp;*.jpg;*.gif,*.png,*.tiff)|*.bmp;*.jpg;*.gif;*.png;*.tiff|Image (*.bmp)|*.bmp|Image(*.jpg)|*.jpg|Image(*.gif)|*.gif|Image(*.png)|*.png|Image(*.tiff)|*.tiff";
        string videof = "Video(*.mp4;*.wmv;*.mov)|*.mp4;*.wmv;*.mov|Video (*.mp4)|*.mp4|Video(*.wmv)|*.wmv|Video(*.mov)|*.mov";
        public Add_Media()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Browse_File_Wind = new OpenFileDialog();
            Browse_File_Wind.Filter = imagesf + "|" + videof;
            if (Browse_File_Wind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(!gf.CheckExtension(Path.GetExtension(Browse_File_Wind.FileName) , Browse_File_Wind.Filter))
                {
                    MessageBox.Show("Chosen file isn't an Image nor a Video, or file format isn't supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string loc = Browse_File_Wind.FileName;
                File_Name.Text = Path.GetFileNameWithoutExtension(loc);
                File_Path.Text = Path.GetDirectoryName(loc);
                File_Extension.Text = Path.GetExtension(loc);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = File_Name.Text.Replace("'", "''"), path = File_Path.Text.Replace("'", "''"), ext = File_Extension.Text.Replace("'", "''"), desc = File_Desc.Text.Replace("'", "''");
            if (!gf.CheckExtension(File_Extension.Text, imagesf+videof))
            {
                MessageBox.Show("Chosen file isn't an Image nor a Video, or file format isn't supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(File_Path.Text + "\\" + File_Name.Text + File_Extension.Text))
            {
                DialogResult res = MessageBox.Show("File doesn't exist. Continue anyway?", "Warning", MessageBoxButtons.YesNo , MessageBoxIcon.Information);
                if (res == DialogResult.No)
                    return;
            }
            string insert_media = "insert into media(name , path , extension , description) values (N'" + name + "',N'" + path + "',N'" + ext + "',N'" + desc + "')";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand (insert_media, conn);
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
