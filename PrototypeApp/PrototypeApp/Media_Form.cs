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
    public partial class Media_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        public Media_Form()
        {
            InitializeComponent();
            Add.FlatAppearance.BorderColor = Color.White;
            Delete.FlatAppearance.BorderColor = Color.White;
            Edit.FlatAppearance.BorderColor = Color.White;
            Search.FlatAppearance.BorderColor = Color.White;
            View_Info.FlatAppearance.BorderColor = Color.White;
        }
        public void Refresh()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_media = "select name as MediaN , path as Path , extension as Extension from media ";
            if (SearchN.Text.Length != 0 || SearchP.Text.Length != 0 || SearchE.Text.Length != 0)
                get_media += "where ";
            if (SearchN.Text.Length != 0)
            {
                get_media += "name like '%" + SearchN.Text.Replace("'", "''") + "%' ";
            }
            if(SearchP.Text.Length!=0)
            {
                if (SearchN.Text.Length != 0) get_media += "and ";
                get_media += "path like '%" + SearchP.Text.Replace("'", "''") + "%' ";
            }
            if(SearchE.Text.Length!=0)
            {
                if (SearchN.Text.Length != 0 || SearchP.Text.Length != 0) get_media += "and ";
                get_media += "extension like '%" + SearchE.Text.Replace("'" , "''") + "%' "; 
            }
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_media, conn);
            DataTable Images_Data = new DataTable();
            sqlAdapt.Fill(Images_Data);
            Media_Grid.DataSource = Images_Data;
            conn.Close();
        }
        
        private void Search_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Images_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string path = Media_Grid.CurrentRow.Cells["Path"].Value.ToString() + "\\" + Media_Grid.CurrentRow.Cells["MediaN"].Value.ToString() + Media_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
            else MessageBox.Show("Error 404.\nFile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Media_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Media_Grid.CurrentRow != null)
                Media_Grid.CurrentRow.Selected = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Media AddForm = new Add_Media();
            AddForm.ShowDialog();
        }

        private void View_Info_Click(object sender, EventArgs e)
        {
            if (Media_Grid.SelectedCells.Count == 0)
                return;
            string name = Media_Grid.CurrentRow.Cells["MediaN"].Value.ToString(), path = Media_Grid.CurrentRow.Cells["Path"].Value.ToString(), ext = Media_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            View_Edit_Media form = new View_Edit_Media(name , path , ext , false);
            form.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (Media_Grid.SelectedCells.Count == 0)
                return;
            DialogResult res = MessageBox.Show("Are you sure you want to delete selected records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            foreach (DataGridViewRow r in Media_Grid.SelectedRows)
            {
                string name = r.Cells["MediaN"].Value.ToString(), path = r.Cells["Path"].Value.ToString(), ext = r.Cells["Extension"].Value.ToString();
                string delete_record = "delete from media where name = '" + name + "' and path ='" + path + "' and extension ='" + ext + "'";
                SqlCommand comm = new SqlCommand(delete_record, conn);
                comm.ExecuteNonQuery();
                Media_Grid.Rows.Remove(r);
            }
            MessageBox.Show("Successfully deleted selected records!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Media_Grid.SelectedCells.Count == 0)
                return;
            string name = Media_Grid.CurrentRow.Cells["MediaN"].Value.ToString(), path = Media_Grid.CurrentRow.Cells["Path"].Value.ToString(), ext = Media_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            View_Edit_Media form = new View_Edit_Media(name, path, ext, true);
            form.ShowDialog();
        }
    }
}
