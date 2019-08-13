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
    public partial class Correspondence_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Correspondence_Form()
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

        public void Refresh()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_Correspondence = "select SR as SR , Name as FileN , SRName as SRName , Subject as Subj , Date as Date , path as Path , extension as Extension from correspondence ";
            if (SFileN.Text.Length != 0 || SearchN.Text.Length != 0 || SearchP.Text.Length != 0 || SearchS.Text.Length != 0 || (OnlyS.Checked && !OnlyR.Checked) || (!OnlyS.Checked && OnlyR.Checked) || !DisableDate.Checked)
                get_Correspondence += "where ";
            string original_query = get_Correspondence;
            if (SFileN.Text.Length != 0)
            {
                get_Correspondence += "Name like N'%" + SFileN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchN.Text.Length != 0)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "srname like N'%" + SearchN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchP.Text.Length != 0)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "path like N'%" + SearchP.Text.Replace("'", "''") + "%' ";
            }
            if (SearchS.Text.Length != 0)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "subject like N'%" + SearchS.Text.Replace("'", "''") + "%' ";
            }
            if (OnlyS.Checked && !OnlyR.Checked)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "sr = 'Sent' ";
            }
            if (OnlyR.Checked && !OnlyS.Checked)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "sr = 'Received' ";
            }
            if (!DisableDate.Checked)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "date = '" + SearchD.Text.Replace("/", "-") + "' ";
            }
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_Correspondence, conn);
            DataTable Mails_Data = new DataTable();
            sqlAdapt.Fill(Mails_Data);
            Correspondence_Grid.DataSource = Mails_Data;
            conn.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Correspondence form = new Add_Correspondence();
            form.ShowDialog();
        }

        private void Correspondence_Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string path = Correspondence_Grid.CurrentRow.Cells["Path"].Value.ToString() + "\\" + Correspondence_Grid.CurrentRow.Cells["FileN"].Value.ToString() + Correspondence_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
            else MessageBox.Show("Error 404.\nFile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Correspondence_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            string path = Correspondence_Grid.CurrentRow.Cells["Path"].Value.ToString() + "\\" + Correspondence_Grid.CurrentRow.Cells["FileN"].Value.ToString() + Correspondence_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
            else MessageBox.Show("Error 404.\nFile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (Correspondence_Grid.SelectedCells.Count == 0)
                return;
            DialogResult res = MessageBox.Show("Are you sure you want to delete selected records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            foreach (DataGridViewRow r in Correspondence_Grid.SelectedRows)
            {
                string name = r.Cells["FileN"].Value.ToString(), path = r.Cells["Path"].Value.ToString(), ext = r.Cells["Extension"].Value.ToString();
                string delete_record = "delete from correspondence where name = N'" + name + "' and path =N'" + path + "' and extension ='" + ext + "'";
                SqlCommand comm = new SqlCommand(delete_record, conn);
                comm.ExecuteNonQuery();
                Correspondence_Grid.Rows.Remove(r);
            }
            MessageBox.Show("Successfully deleted selected records!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Correspondence_Grid.SelectedCells.Count == 0)
                return;
            string name = Correspondence_Grid.CurrentRow.Cells["FileN"].Value.ToString(), path = Correspondence_Grid.CurrentRow.Cells["Path"].Value.ToString(), ext = Correspondence_Grid.CurrentRow.Cells["Extension"].Value.ToString(), date = GF.RemoveTime(Correspondence_Grid.CurrentRow.Cells["Date"].Value.ToString());
            string subj = Correspondence_Grid.CurrentRow.Cells["Subj"].Value.ToString(), srname = Correspondence_Grid.CurrentRow.Cells["SRName"].Value.ToString(), sr = Correspondence_Grid.CurrentRow.Cells["SR"].Value.ToString();
            View_Edit_Correspondence form = new View_Edit_Correspondence(name, path, ext, subj, srname, sr, date, true);
            form.ShowDialog();
        }

        private void View_Info_Click(object sender, EventArgs e)
        {
            if (Correspondence_Grid.SelectedCells.Count == 0)
                return;
            string name = Correspondence_Grid.CurrentRow.Cells["FileN"].Value.ToString(), path = Correspondence_Grid.CurrentRow.Cells["Path"].Value.ToString(), ext = Correspondence_Grid.CurrentRow.Cells["Extension"].Value.ToString(), date = GF.RemoveTime(Correspondence_Grid.CurrentRow.Cells["Date"].Value.ToString());
            string subj = Correspondence_Grid.CurrentRow.Cells["Subj"].Value.ToString(), srname = Correspondence_Grid.CurrentRow.Cells["SRName"].Value.ToString(), sr = Correspondence_Grid.CurrentRow.Cells["SR"].Value.ToString();
            View_Edit_Correspondence form = new View_Edit_Correspondence(name, path, ext , subj , srname , sr, date, false);
            form.ShowDialog();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Correspondence_Grid.Rows)
            {
                Correspondence_Grid.Rows.Remove(row);
            }
            DataGridViewRow r = Correspondence_Grid.Rows[0];
            Correspondence_Grid.Rows.Remove(r);
        }

        private void Clear_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.Clear, "Clear search list");
        }
    }
}
