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

namespace PolyDoc
{
    public partial class Testemonials_Form : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        readonly string Database = ((Main_Form)MainForm).database;
        readonly string User = ((Main_Form)MainForm).user;
        readonly GlobalFunc GF = new GlobalFunc();
        public Testemonials_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            SearchD.CustomFormat = "dd/MM/yyyy";
            SearchLocN.Enabled = false;

            if (!GF.CheckAdminPerm(User, connectionString, this, MainForm))
            {
                GF.CheckPerm(User, "insert", Database, "testemonial", connectionString, this, MainForm, Add);
                GF.CheckPerm(User, "delete", Database, "testemonial", connectionString, this, MainForm, Delete);
            }

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
                                SearchLoc.Items.Add(reader["location"].ToString());
                            }
                            reader.Dispose();
                        }
                        using (SqlCommand comm = new SqlCommand(getProfessions, conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while (reader.Read())
                            {
                                SearchPro.Items.Add(reader["profession"].ToString());
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
            SearchLoc.Items.Add("-Disable-");
            SearchPro.Items.Add("-Disable-");
            SearchLoc.Text = "-Disable-";
            SearchPro.Text = "-Disable-";

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 0);
        }

        public void RefreshList()
        {
            if (!GF.IsServerConnected(connectionString))
            {
                GF.ConnectionLost(this , MainForm);
                return;
            }
            string get_test = "select Code , InterName , Location as Loc , LocationN as LocN , Profession , Name as TestN , Path , Extension , convert(varchar , date , 103) as Date from Testemonial where ";
            string originalQ = get_test;
            if(SearchN.Text.Length!=0)
            {
                get_test += "Name like N'%" + SearchN.Text.Replace("'", "''") + "%' ";
            }
            if(SearchP.Text.Length!=0)
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "Path like N'%" + SearchP.Text.Replace("'", "''") + "%' ";
            }
            if (SearchEx.Text.Length != 0)
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "Extension like N'%" + SearchEx.Text.Replace("'", "''") + "%' ";
            }
            if (SearchIN.Text.Length != 0)
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "InterName like N'%" + SearchIN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchLoc.Text != "-Disable-")
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "Location like N'%" + SearchLoc.Text.Replace("'", "''") + "%' ";
            }
            if (SearchLoc.Text!="-Disable-" && SearchLocN.Text.Length != 0)
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "LocationN like N'%" + SearchLocN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchPro.Text != "-Disable-")
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "Profession like N'%" + SearchPro.Text.Replace("'", "''") + "%' ";
            }
            if(DisableDate.Checked==false)
            {
                if (originalQ != get_test) get_test += " and ";
                string[] parts = SearchD.Text.Split('/');
                string newdate = parts[1] + "-" + parts[0] + "-" + parts[2];
                get_test += "Date = '" + newdate + "'";
            }
            if(SearchCode.Text.Length != 0)
            {
                if (originalQ != get_test) get_test += " and ";
                get_test += "Code like '%" + SearchCode.Text.Replace("'", "''") + "%'";
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_test, conn))
                    {
                        DataTable Data = new DataTable();
                        sqlAdapt.Fill(Data);
                        Testemonial_Grid.DataSource = Data;
                    }
                }
            }
            catch(SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (Add_Testemonial form = new Add_Testemonial())
                form.ShowDialog();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchLoc.Text == "-Disable-" && SearchPro.Text == "-Disable-" && SearchIN.Text.Length == 0 && SearchN.Text.Length == 0 && SearchP.Text.Length == 0 && SearchEx.Text.Length == 0 && SearchCode.Text.Length == 0 && DisableDate.Checked == true)
            {
                MessageBox.Show("Please, fill the search bars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshList();
        }

        private void SearchLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchLoc.Text != "-Disable-")
                SearchLocN.Enabled = true;
            else SearchLocN.Enabled = false;
        }

        private void Testemonial_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GF.OpenRecord(Testemonial_Grid, e);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GF.ClearRecords(Testemonial_Grid);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            GF.DeleteRecords(Testemonial_Grid, "testemonial", "FileName", "Path", "Extension", connectionString , this , MainForm);
        }

        private void View_Info_Click(object sender, EventArgs e)
        {
            if (Testemonial_Grid.SelectedCells.Count == 0)
                return;
            string code = Testemonial_Grid.CurrentRow.Cells["Code"].Value.ToString();
            string interName = Testemonial_Grid.CurrentRow.Cells["InterName"].Value.ToString();
            string location = Testemonial_Grid.CurrentRow.Cells["Loc"].Value.ToString();
            string locationN = Testemonial_Grid.CurrentRow.Cells["LocN"].Value.ToString();
            string profession = Testemonial_Grid.CurrentRow.Cells["Profession"].Value.ToString();
            string date = Testemonial_Grid.CurrentRow.Cells["Date"].Value.ToString();
            string fileName = Testemonial_Grid.CurrentRow.Cells["FileName"].Value.ToString();
            string path = Testemonial_Grid.CurrentRow.Cells["Path"].Value.ToString();
            string extension = Testemonial_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            View_Edit_Testemonial form = new View_Edit_Testemonial(code, locationN, interName, location, profession, date, fileName, path, extension);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
