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
using System.Net;

namespace Apex
{
    public partial class Add_Project : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        Dictionary<string, bool> map = new Dictionary<string, bool>();
        public Add_Project()
        {
            InitializeComponent();
            GF.EditButtons(this);
            AddStartDate.CustomFormat = "dd/MM/yyyy";
            AddEndDate.CustomFormat = "dd/MM/yyyy";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (AddProjectN.Text.Length == 0 || AddPartner.Text.Length == 0 || AddLoc.Text.Length == 0)
            {
                MessageBox.Show("Please, fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Browse_File_Wind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] loc = Browse_File_Wind.FileNames;
                foreach (string i in loc)
                {
                    string code = GF.GetCode("Projects", map, connectionString , this , MainForm);
                    string name = Path.GetFileNameWithoutExtension(i);
                    string projectName = AddProjectN.Text;
                    string location = AddLoc.Text;
                    string partner = AddPartner.Text;
                    string startDate = AddStartDate.Text;
                    string endDate = AddEndDate.Text;
                    string extension = Path.GetExtension(i);
                    string path = Path.GetDirectoryName(i);
                    if (GF.CheckExistance(name.Replace("'", "''") + "-" + extension, "projects", connectionString))
                    {
                        MessageBox.Show(name + extension + " already exists in Projects.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    map.Add(code, true);
                    SelectedFiles.Rows.Add(code, name, projectName, location, partner, startDate, endDate, extension, path);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form TestForm = Application.OpenForms["Testemonial_Form"];
                ((Main_Form)MainForm).Disconnected();
                TestForm.Close();
                this.Close();
                return;
            }
            if (SelectedFiles.Rows.Count == 0)
            {
                MessageBox.Show("There are no selected files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string add_files = "insert into projects(code ,name , projectname , location , partner , startdate , enddate , extension , path) values";
            foreach (DataGridViewRow row in SelectedFiles.Rows)
            {
                string code = row.Cells[0].Value.ToString().Replace("'", "''");
                string name = row.Cells[1].Value.ToString().Replace("'", "''");
                string projectName = row.Cells[2].Value.ToString().Replace("'", "''");
                string location = row.Cells[3].Value.ToString().Replace("'", "''");
                string partner = row.Cells[4].Value.ToString().Replace("'", "''");
                string[] parts = row.Cells[5].Value.ToString().Split('/');
                string startDate = parts[1] + "-" + parts[0] + "-" + parts[2];
                parts = row.Cells[6].Value.ToString().Split('/');
                string endDate = parts[1] + "-" + parts[0] + "-" + parts[2];
                string extension = row.Cells[7].Value.ToString().Replace("'", "''");
                string path = GlobalFunc.FilesDirectory + @"\" + "Projects";
                using (new NetworkConnection(GlobalFunc.FilesDirectory, new NetworkCredential("Apex-AdminUser", "123")))
                {
                    File.Copy(row.Cells[8].Value.ToString() + @"\" + name + extension, GlobalFunc.FilesDirectory + @"\Projects\" + name + extension);
                }
                add_files += "('" + code + "',N'" + name + "',N'" + projectName + "',N'" + location + "',N'" + partner + "','" + startDate + "','" + endDate + "','" + extension + "',N'" + path + "'),";
            }
            add_files = add_files.Remove(add_files.Length - 1);
            SqlCommand comm = new SqlCommand(add_files, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully added file info!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GF.ClearRecords(SelectedFiles);
        }

        private void SelectedFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int pos = SelectedFiles.HitTest(e.X, e.Y).RowIndex;
                if (pos < 0)
                    return;
                if (!SelectedFiles.Rows[pos].Selected)
                {
                    SelectedFiles.ClearSelection();
                    SelectedFiles.Rows[pos].Selected = true;
                }
                RowMenu.Show(SelectedFiles, new Point(e.X, e.Y));
            }
        }

        private void RowMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete")
            {
                foreach (DataGridViewRow row in SelectedFiles.SelectedRows)
                {
                    SelectedFiles.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
