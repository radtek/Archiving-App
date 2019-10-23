using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyDoc
{
    public partial class View_Edit_HR : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        static Form HR_Form = Application.OpenForms["HR_Form"];
        readonly string Database = ((Main_Form)MainForm).database;
        readonly string User = ((Main_Form)MainForm).user;
        readonly GlobalFunc GF = new GlobalFunc();
        public View_Edit_HR(string code, string empID, string empName, string empJob, string empBirthDate, string empEmploymentDate, string fileName, string path, string extension)
        {
            InitializeComponent();
            GF.EditButtons(this);
            New_EmpBirthDate.CustomFormat = "dd/MM/yyyy";
            New_EmpEmploymentDate.CustomFormat = "dd/MM/yyyy";
            File_Name.Text = fileName;
            File_Path.Text = path;
            File_Extension.Text = extension;
            EmpBirthDate.Text = empBirthDate;
            EmpEmploymentDate.Text = empEmploymentDate;
            EmpName.Text = empName;
            EmpJob.Text = empJob;
            EmpID.Text = empID;
            Code.Text = code;
            ViewMode();
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
                                New_EmpJob.Items.Add(reader["JobName"].ToString());
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

        private void EditMode()
        {
            New_EmpBirthDate.Value = DateTime.ParseExact(EmpBirthDate.Text, "dd/MM/yyyy", null);
            New_EmpEmploymentDate.Value = DateTime.ParseExact(EmpEmploymentDate.Text, "dd/MM/yyyy", null);
            New_EmpName.Text = EmpName.Text;
            New_EmpJob.Text = EmpJob.Text;
            New_EmpID.Text = EmpID.Text;
            Edit.Visible = false;
            Done.Visible = true;
            Cancel.Visible = true;
            New_EmpBirthDate.Visible = true;
            New_EmpEmploymentDate.Visible = true;
            New_EmpName.Visible = true;
            New_EmpID.Visible = true;
            New_EmpJob.Visible = true;
        }
        private void ViewMode()
        {
            Edit.Visible = true;
            Done.Visible = false;
            Cancel.Visible = false;
            New_EmpBirthDate.Visible = false;
            New_EmpEmploymentDate.Visible = false;
            New_EmpName.Visible = false;
            New_EmpID.Visible = false;
            New_EmpJob.Visible = false;
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
            string[] parts = New_EmpBirthDate.Text.Split('/');
            string empBirthDate = parts[1] + "-" + parts[0] + "-" + parts[2];
            parts = New_EmpEmploymentDate.Text.Split('/');
            string empEmploymentDate = parts[1] + "-" + parts[0] + "-" + parts[2];
            string edit_record_set = "update hr set empbirthdate='" + empBirthDate + "'" +
                                     ",empemploymentdate='" + empEmploymentDate + "'" +
                                     ",empjob=N'" + New_EmpJob.Text.Replace("'", "''") + "'" +
                                     ",empid='" + New_EmpID.Text.Replace("'", "''") + "'" +
                                     ",empName=N'" + New_EmpName.Text.Replace("'", "''") + "'";
            string edit_record_condition = "where name = N'" + File_Name.Text.Replace("'", "''") + "' and path=N'" + File_Path.Text.Replace("'", "''") + "' and extension='" + File_Extension.Text.Replace("'", "''") + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(edit_record_set + edit_record_condition, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully edited file info!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((HR_Form)HR_Form).RefreshList();
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ViewMode();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditMode();
        }
        public bool NoChange(bool change_pk)
        {
            if (New_EmpBirthDate.Text == EmpBirthDate.Text
                && New_EmpName.Text == EmpName.Text
                && New_EmpEmploymentDate.Text == EmpEmploymentDate.Text
                && New_EmpID.Text == EmpID.Text
                && New_EmpJob.Text == EmpJob.Text)
                return true;
            return false;
        }

        private void New_EmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
