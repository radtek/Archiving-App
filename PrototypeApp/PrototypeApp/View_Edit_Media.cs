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
    public partial class View_Edit_Media : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        static Form Media_Form = Application.OpenForms["Media_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        bool mode = false;
        string old_desc;
        public View_Edit_Media(string name , string path , string ext , string date , bool edit)
        {
            InitializeComponent();
            Close.FlatAppearance.BorderColor = Color.White;
            Edit.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
            Done.FlatAppearance.BorderColor = Color.White;
            File_Name.Text = name;
            File_Path.Text = path;
            File_Extension.Text = ext;
            File_Date.Text = date;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_desc = "select description from media where name = N'" + name + "' and path =N'" + path + "' and extension ='" + ext + "'";
            SqlCommand comm = new SqlCommand(get_desc, conn);
            File_Desc.Text = comm.ExecuteScalar().ToString();
            if (edit)
            {
                EditMode();
            }
        }

        public bool NoChange(bool change_pk)
        {
            if (New_Name.Text == File_Name.Text && New_Path.Text == File_Path.Text && New_Extension.Text == File_Extension.Text && change_pk)
                return true;
            if (New_Name.Text == File_Name.Text && New_Path.Text == File_Path.Text && New_Extension.Text == File_Extension.Text && New_Date.Text==File_Date.Text && old_desc == File_Desc.Text)
                return true;
            return false;
        }

        public void EditMode()
        {
            mode = true;
            New_Name.Text = File_Name.Text;
            New_Path.Text = File_Path.Text;
            New_Extension.Text = File_Extension.Text;
            New_Date.Text = File_Date.Text;
            Done.Visible = true;
            Cancel.Visible = true;
            New_Name.Visible = true;
            New_Path.Visible = true;
            New_Extension.Visible = true;
            New_Date.Visible = true;
            File_Desc.ReadOnly = false;
            old_desc = File_Desc.Text;
        }

        public void ViewMode()
        {
            mode = false;
            Done.Visible = false;
            Cancel.Visible = false;
            New_Name.Visible = false;
            New_Path.Visible = false;
            New_Extension.Visible = false;
            New_Date.Visible = false;
            File_Desc.ReadOnly = true;
            File_Desc.Text = old_desc;
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            if ((NoChange(false) && mode == true) || (mode == false))
            {
                this.Close();
                return;
            }
            DialogResult res = MessageBox.Show("Discard changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (NoChange(false))
            {
                ViewMode();
                return;
            }
            DialogResult res = MessageBox.Show("Discard changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            ViewMode();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (NoChange(false))
            {
                ViewMode();
                return;
            }
            DialogResult res = MessageBox.Show("Save changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            if (!File.Exists(New_Path.Text + "\\" + New_Name.Text + New_Extension.Text))
            {
                MessageBox.Show("Error 404.\nCouldn't find the file in the new path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GF.CheckExistance(New_Name.Text.Replace("'", "''") + "-" + New_Path.Text.Replace("'", "''") + "-" + New_Extension.Text.Replace("'", "''"), "media" , connectionString) && !NoChange(true))
            {
                MessageBox.Show("File already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string edit_record_set = "update media set name = N'" + New_Name.Text.Replace("'" , "''") + "',path=N'" + New_Path.Text.Replace("'", "''") + "',extension='" + New_Extension.Text.Replace("'", "''") + "',description=N'" + File_Desc.Text.Replace("'", "''") + "',date='" + New_Date.Text.Replace("/" , "-")+"'";
            string edit_record_condition = "where name = N'" + File_Name.Text.Replace("'", "''") + "' and path=N'" + File_Path.Text.Replace("'", "''") + "' and extension='" + File_Extension.Text.Replace("'", "''") + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand (edit_record_set+edit_record_condition , conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully edited file info!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((Media_Form)Media_Form).Refresh();
            this.Close();
        }
    }
}
