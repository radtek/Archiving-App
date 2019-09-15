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
    public partial class Media_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Media_Form()
        {
            InitializeComponent();
            Add.FlatAppearance.BorderColor = Color.White;
            Delete.FlatAppearance.BorderColor = Color.White;
            Edit.FlatAppearance.BorderColor = Color.White;
            Search.FlatAppearance.BorderColor = Color.White;
            View_Info.FlatAppearance.BorderColor = Color.White;
            Clear.FlatAppearance.BorderColor = Color.White;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 0);
        }
        public void RefreshList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_media = "select name as MediaN , path as Path , [date] as Date , extension as Extension from media ";
            if (SearchN.Text.Length != 0 || SearchP.Text.Length != 0 || !DisableDate.Checked)
                get_media += "where ";
            string original_query = get_media;
            if (SearchN.Text.Length != 0)
            {
                get_media += "name like N'%" + SearchN.Text.Replace("'", "''") + "%' ";
            }
            if(SearchP.Text.Length!=0)
            {
                if (get_media != original_query) get_media += "and ";
                get_media += "path like N'%" + SearchP.Text.Replace("'", "''") + "%' ";
            }
            if(!DisableDate.Checked)
            {
                if (get_media != original_query) get_media += "and ";
                get_media += "Date = '" + SearchD.Text.Replace("/" , "-").Replace(" " , "") + "' ";
            }
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_media, conn);
            DataTable Images_Data = new DataTable();
            sqlAdapt.Fill(Images_Data);
            Media_Grid.DataSource = Images_Data;
            conn.Close();
        }
        
        private void Search_Click(object sender, EventArgs e)
        {
            RefreshList();
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
            string name = Media_Grid.CurrentRow.Cells["MediaN"].Value.ToString(), path = Media_Grid.CurrentRow.Cells["Path"].Value.ToString(), ext = Media_Grid.CurrentRow.Cells["Extension"].Value.ToString() , date = GF.RemoveTime(Media_Grid.CurrentRow.Cells["Date"].Value.ToString());
            View_Edit_Media form = new View_Edit_Media(name , path , ext , date , false);
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
                string delete_record = "delete from media where name = N'" + name + "' and path =N'" + path + "' and extension ='" + ext + "'";
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
            string name = Media_Grid.CurrentRow.Cells["MediaN"].Value.ToString(), path = Media_Grid.CurrentRow.Cells["Path"].Value.ToString(), ext = Media_Grid.CurrentRow.Cells["Extension"].Value.ToString(), date = GF.RemoveTime(Media_Grid.CurrentRow.Cells["Date"].Value.ToString());
            View_Edit_Media form = new View_Edit_Media(name, path, ext , date , true);
            form.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Media_Grid.Rows)
            {
                Media_Grid.Rows.Remove(row);
            }
            DataGridViewRow r = Media_Grid.Rows[0];
            Media_Grid.Rows.Remove(r);
        }

        private void Media_Form_Load(object sender, EventArgs e)
        {

        }

        private void Clear_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Clear, "Clear search list");
        }
    }
}
