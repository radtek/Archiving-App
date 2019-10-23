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
    public partial class Add_HR : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        Dictionary<string, bool> map = new Dictionary<string, bool>();
        public Add_HR()
        {
            InitializeComponent();
            GF.EditButtons(this);
            AddEmpBirthDate.CustomFormat = "dd/MM/yyyy";
            AddEmpEmploymentDate.CustomFormat = "dd/MM/yyyy";
            string getJobs = "select * from jobs";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(getJobs, conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while (reader.Read())
                            {
                                AddEmpJob.Items.Add(reader["JobName"].ToString());
                            }
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (AddEmpName.Text.Length == 0 || AddEmpID.Text.Length == 0 || AddEmpJob.Text.Length == 0)
            {
                MessageBox.Show("Please, fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Browse_File_Wind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] loc = Browse_File_Wind.FileNames;
                foreach (string i in loc)
                {
                    string code = GF.GetCode("HR", map, connectionString, this, MainForm);
                    string name = Path.GetFileNameWithoutExtension(i);
                    string empName = AddEmpName.Text;
                    string empJob = AddEmpJob.Text;
                    string empID = AddEmpID.Text;
                    string empBirthDate = AddEmpBirthDate.Text;
                    string empEmploymentDate = AddEmpEmploymentDate.Text;
                    string extension = Path.GetExtension(i);
                    string path = Path.GetDirectoryName(i);
                    if (GF.CheckExistance(name.Replace("'", "''") + "-" + extension, "HR", connectionString))
                    {
                        MessageBox.Show(name + extension + " already exists in HR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    map.Add(code, true);
                    SelectedFiles.Rows.Add(code, name, empName, empJob, empID, empBirthDate, empEmploymentDate, extension, path);
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
            string add_files = "insert into HR(code ,name , empname , empjob , empid , empbirthdate , empemploymentdate , extension , path) values";
            foreach (DataGridViewRow row in SelectedFiles.Rows)
            {
                string code = row.Cells[0].Value.ToString().Replace("'", "''");
                string name = row.Cells[1].Value.ToString().Replace("'", "''");
                string empName = row.Cells[2].Value.ToString().Replace("'", "''");
                string empJob = row.Cells[3].Value.ToString().Replace("'", "''");
                string empID = row.Cells[4].Value.ToString().Replace("'", "''");
                string[] parts = row.Cells[5].Value.ToString().Split('/');
                string empBirthDate = parts[1] + "-" + parts[0] + "-" + parts[2];
                parts = row.Cells[6].Value.ToString().Split('/');
                string empEmploymentDate = parts[1] + "-" + parts[0] + "-" + parts[2];
                string extension = row.Cells[7].Value.ToString().Replace("'", "''");
                string path = GlobalFunc.FilesDirectory + @"\" + "HR";
                using (new NetworkConnection(GlobalFunc.FilesDirectory, new NetworkCredential(GlobalFunc.AppUser, GlobalFunc.AppPass)))
                {
                    File.Copy(row.Cells[8].Value.ToString() + @"\" + name + extension, GlobalFunc.FilesDirectory + @"\HR\" + name + extension);
                }
                add_files += "('" + code + "',N'" + name + "',N'" + empName + "',N'" + empJob + "','" + empID + "','" + empBirthDate + "','" + empEmploymentDate + "','" + extension + "',N'" + path + "'),";
            }
            add_files = add_files.Remove(add_files.Length - 1);
            SqlCommand comm = new SqlCommand(add_files, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully added file info!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GF.ClearRecords(SelectedFiles);
        }

        private void AddEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
