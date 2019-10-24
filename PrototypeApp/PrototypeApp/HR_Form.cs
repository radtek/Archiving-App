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
    public partial class HR_Form : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        readonly string Database = ((Main_Form)MainForm).database;
        readonly string User = ((Main_Form)MainForm).user;
        readonly GlobalFunc GF = new GlobalFunc();
        public HR_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            SearchEmpJob.Text = "-Disable-";
            SearchBirthDate.CustomFormat = "dd/MM/yyyy";
            SearchEmploymentDate.CustomFormat = "dd/MM/yyyy";
            if (!GF.CheckAdminPerm(User, connectionString, this, MainForm))
            {
                GF.CheckPerm(User, "insert", Database, "HR", connectionString, this, MainForm, Add);
                GF.CheckPerm(User, "delete", Database, "HR", connectionString, this, MainForm, Delete);
            }
            string getJobs = "select * from jobs";
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using(SqlCommand comm = new SqlCommand(getJobs , conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while(reader.Read())
                            {
                                SearchEmpJob.Items.Add(reader["JobName"].ToString());
                            }
                        }
                    }
                    catch(SqlException)
                    {
                        GF.CommandFailed();
                        return;
                    }
                }
            }
            catch(SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
            SearchEmpJob.Items.Add("-Disable-");
            SearchEmpJob.Text = "-Disable-";
        }

        public void RefreshList()
        {
            string get_data = "select code , empname , empid , empjob , convert(varchar, empbirthdate, 103)as empbirthdate , convert(varchar, empemploymentdate, 103)as empemploymentdate , Name , Path , Extension\n" +
                              "from HR where ";
            string originalQ = get_data;
            if (SearchN.Text.Length != 0)
            {
                get_data += "Name like N'%" + SearchN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchP.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "Path like N'%" + SearchP.Text.Replace("'", "''") + "%' ";
            }
            if (SearchEx.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "Extension like N'%" + SearchEx.Text.Replace("'", "''") + "%' ";
            }
            if (SearchEmpName.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "EmpName like N'%" + SearchEmpName.Text.Replace("'", "''") + "%' ";
            }
            if (SearchEmpID.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "EmpID like '%" + SearchEmpID.Text.Replace("'", "''") + "%' ";
            }
            if (SearchEmpJob.Text != "-Disable-")
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "EmpJob like N'%" + SearchEmpJob.Text.Replace("'", "''") + "%' ";
            }
            if (DisableBirthDate.Checked == false)
            {
                if (originalQ != get_data) get_data += " and ";
                string[] parts = SearchBirthDate.Text.Split('/');
                string newdate = parts[1] + "-" + parts[0] + "-" + parts[2];
                get_data += "EmpBirthDate = '" + newdate + "' ";
            }
            if (DisableEmploymentDate.Checked == false)
            {
                if (originalQ != get_data) get_data += " and ";
                string[] parts = SearchEmploymentDate.Text.Split('/');
                string newdate = parts[1] + "-" + parts[0] + "-" + parts[2];
                get_data += "EmpEmploymentDate = '" + newdate + "'";
            }
            if (SearchCode.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "Code like '%" + SearchCode.Text.Replace("'", "''") + "%'";
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_data, conn))
                    {
                        DataTable Data = new DataTable();
                        sqlAdapt.Fill(Data);
                        HR_Grid.DataSource = Data;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchEmpJob.Text == "-Disable-"
                && SearchEmpName.Text.Length == 0
                && SearchEmpID.Text.Length == 0
                && SearchN.Text.Length == 0
                && SearchP.Text.Length == 0
                && SearchEx.Text.Length == 0
                && SearchCode.Text.Length == 0
                && DisableBirthDate.Checked == true
                && DisableEmploymentDate.Checked == true)
            {
                MessageBox.Show("Please, fill the search bars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshList();
        }

        private void SearchEmpID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            GF.DeleteRecords(HR_Grid, "HR", "FileName", "Path", "Extension", connectionString, this, MainForm);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GF.ClearRecords(HR_Grid);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_HR form = new Add_HR();
            form.ShowDialog();
            form.Dispose();
        }

        private void View_Info_Click(object sender, EventArgs e)
        {
            if (HR_Grid.SelectedCells.Count == 0)
                return;
            string code = HR_Grid.CurrentRow.Cells["Code"].Value.ToString();
            string empID = HR_Grid.CurrentRow.Cells["EmpID"].Value.ToString();
            string empName = HR_Grid.CurrentRow.Cells["EmpName"].Value.ToString();
            string empJob = HR_Grid.CurrentRow.Cells["EmpJob"].Value.ToString();
            string empBirthDate = HR_Grid.CurrentRow.Cells["EmpBirthDate"].Value.ToString();
            string empEmploymentDate = HR_Grid.CurrentRow.Cells["EmpEmploymentDate"].Value.ToString();
            string fileName = HR_Grid.CurrentRow.Cells["FileName"].Value.ToString();
            string path = HR_Grid.CurrentRow.Cells["Path"].Value.ToString();
            string extension = HR_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            View_Edit_HR form = new View_Edit_HR(code, empID, empName, empJob, empBirthDate, empEmploymentDate, fileName, path, extension);
            form.ShowDialog();
            form.Dispose();
        }

        private void HR_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GF.OpenRecord(HR_Grid, e);
        }
    }
}
