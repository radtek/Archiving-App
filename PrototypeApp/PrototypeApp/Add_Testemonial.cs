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

namespace PolyDoc
{
    public partial class Add_Testemonial : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        Dictionary<string, bool> map = new Dictionary<string, bool>();
        public Add_Testemonial()
        {
            InitializeComponent();
            Browse.FlatAppearance.BorderColor = Color.White;
            Add.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
            AddDate.CustomFormat = "dd/MM/yyyy";
            string getProfessions = "select * from professions";
            string getLocations = "select * from locations";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(getLocations, conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while (reader.Read())
                            {
                                AddLoc.Items.Add(reader["location"].ToString());
                            }
                            reader.Dispose();
                        }
                        using (SqlCommand comm = new SqlCommand(getProfessions, conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while (reader.Read())
                            {
                                AddPro.Items.Add(reader["profession"].ToString());
                            }
                            reader.Dispose();
                        }
                    }
                    catch (SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if(AddIN.Text.Length == 0 || AddLocN.Text.Length==0 || AddLoc.Text.Length==0 || AddPro.Text.Length==0)
            {
                MessageBox.Show("Please, fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Browse_File_Wind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] loc = Browse_File_Wind.FileNames;
                foreach (string i in loc)
                {
                    string code = GF.GetCode("Testemonial" , map , connectionString , this , MainForm);
                    string name = Path.GetFileNameWithoutExtension(i);
                    string intername = AddIN.Text;
                    string location = AddLoc.Text;
                    string locationN = AddLocN.Text;
                    string profession = AddPro.Text;
                    string date = AddDate.Text;
                    string extension = Path.GetExtension(i);
                    string path = Path.GetDirectoryName(i);
                    if(GF.CheckExistance(name.Replace("'" , "''")+"-"+extension , "testemonial" , connectionString))
                    {
                        MessageBox.Show(name+extension +" already exists in Testemonial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    map.Add(code, true);
                    SelectedFiles.Rows.Add(code , name , intername , location , locationN , profession , date , extension , path);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (SelectedFiles.Rows.Count==0)
            {
                MessageBox.Show("There are no selected files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string add_files = "insert into testemonial(code ,name , intername , location , locationn , profession , date , extension , path) values";
            foreach (DataGridViewRow row in SelectedFiles.Rows)
            {
                string code = row.Cells[0].Value.ToString().Replace("'", "''");
                string name = row.Cells[1].Value.ToString().Replace("'", "''");
                string intername = row.Cells[2].Value.ToString().Replace("'", "''");
                string location = row.Cells[3].Value.ToString().Replace("'", "''");
                string locationN = row.Cells[4].Value.ToString().Replace("'", "''");
                string profession = row.Cells[5].Value.ToString().Replace("'", "''");
                string[] parts = row.Cells[6].Value.ToString().Split('/');
                string date = parts[1] + "-" + parts[0] + "-" + parts[2];
                string extension = row.Cells[7].Value.ToString().Replace("'", "''");
                string path = GlobalFunc.FilesDirectory + @"\" + "Testemonial";
                using (new NetworkConnection(GlobalFunc.FilesDirectory, new NetworkCredential(GlobalFunc.AppUser, GlobalFunc.AppPass)))
                {
                    File.Copy(row.Cells[8].Value.ToString() + @"\" + name + extension, GlobalFunc.FilesDirectory +  @"\Testemonial\" + name + extension);
                }
                add_files += "('" + code + "',N'" + name + "',N'" + intername + "',N'" + location + "',N'" + locationN + "',N'" + profession + "','" + date + "','" + extension + "',N'" + path + "'),";
            }
            add_files = add_files.Remove(add_files.Length - 1);
            SqlCommand comm = new SqlCommand(add_files, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully added file info!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GF.ClearRecords(SelectedFiles);
        }

        private void SelectedFiles_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
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
            if(e.ClickedItem.Text == "Delete")
            {
                foreach(DataGridViewRow row in SelectedFiles.SelectedRows)
                {
                    SelectedFiles.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
