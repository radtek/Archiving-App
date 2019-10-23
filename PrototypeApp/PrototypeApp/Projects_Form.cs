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

namespace Apex
{
    public partial class Projects_Form : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        readonly string Database = ((Main_Form)MainForm).database;
        readonly string User = ((Main_Form)MainForm).user;
        readonly GlobalFunc GF = new GlobalFunc();
        public Projects_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            SearchLoc.Text = "-Disable-";
            SearchStartDate.CustomFormat = "dd/MM/yyyy";
            SearchEndDate.CustomFormat = "dd/MM/yyyy";
            if (!GF.CheckAdminPerm(User, connectionString, this, MainForm))
            {
                GF.CheckPerm(User, "insert", Database, "projects", connectionString, this, MainForm, Add);
                GF.CheckPerm(User, "delete", Database, "projects", connectionString, this, MainForm, Delete);
            }
        }
        public void RefreshList()
        {
            string get_data = "select code , partner , ProjectName , location , convert(varchar, startdate, 103)as startdate , convert(varchar, enddate, 103)as enddate , Name , Path , Extension\n" +
                              "from projects where ";
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
            if (SearchProjectN.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "ProjectName like N'%" + SearchProjectN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchPartner.Text.Length != 0)
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "Partner like N'%" + SearchPartner.Text.Replace("'", "''") + "%' ";
            }
            if (SearchLoc.Text != "-Disable-")
            {
                if (originalQ != get_data) get_data += " and ";
                get_data += "Location like N'%" + SearchLoc.Text.Replace("'", "''") + "%' ";
            }
            if (DisableStartDate.Checked == false)
            {
                if (originalQ != get_data) get_data += " and ";
                string[] parts = SearchStartDate.Text.Split('/');
                string newdate = parts[1] + "-" + parts[0] + "-" + parts[2];
                get_data += "StartDate = '" + newdate + "' ";
            }
            if (DisableEndDate.Checked == false)
            {
                if (originalQ != get_data) get_data += " and ";
                string[] parts = SearchEndDate.Text.Split('/');
                string newdate = parts[1] + "-" + parts[0] + "-" + parts[2];
                get_data += "EndDate = '" + newdate + "'";
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
                        Projects_Grid.DataSource = Data;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                GF.ConnectionLost(this, MainForm);
                return;
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            if (SearchLoc.Text == "-Disable-"  
                && SearchProjectN.Text.Length == 0
                && SearchPartner.Text.Length == 0
                && SearchN.Text.Length == 0 
                && SearchP.Text.Length == 0 
                && SearchEx.Text.Length == 0 
                && SearchCode.Text.Length == 0 
                && DisableStartDate.Checked == true
                && DisableEndDate.Checked == true)
            {
                MessageBox.Show("Please, fill the search bars", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RefreshList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            GF.DeleteRecords(Projects_Grid, "Projects", "FileName", "Path", "Extension", connectionString , this , MainForm);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GF.ClearRecords(Projects_Grid);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Project form = new Add_Project();
            form.ShowDialog();
            form.Dispose();
        }

        private void Projects_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GF.OpenRecord(Projects_Grid, e);
        }

        private void View_Info_Click(object sender, EventArgs e)
        {
            if (Projects_Grid.SelectedCells.Count == 0)
                return;
            string code = Projects_Grid.CurrentRow.Cells["Code"].Value.ToString();
            string partner = Projects_Grid.CurrentRow.Cells["Partner"].Value.ToString();
            string projectN = Projects_Grid.CurrentRow.Cells["ProjectN"].Value.ToString();
            string loc = Projects_Grid.CurrentRow.Cells["Loc"].Value.ToString();
            string startDate = Projects_Grid.CurrentRow.Cells["StartDate"].Value.ToString();
            string endDate = Projects_Grid.CurrentRow.Cells["EndDate"].Value.ToString();
            string fileName = Projects_Grid.CurrentRow.Cells["FileName"].Value.ToString();
            string path = Projects_Grid.CurrentRow.Cells["Path"].Value.ToString();
            string extension = Projects_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            View_Project form = new View_Project(code, partner, projectN, loc, startDate, endDate, fileName, path, extension);
            form.ShowDialog();
            form.Dispose();
        }
    }
}
