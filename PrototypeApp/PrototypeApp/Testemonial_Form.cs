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
    public partial class Testemonial_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        public Testemonial_Form()
        {
            InitializeComponent();
            Add.FlatAppearance.BorderColor = Color.White;
            Delete.FlatAppearance.BorderColor = Color.White;
            Edit.FlatAppearance.BorderColor = Color.White;
            Search.FlatAppearance.BorderColor = Color.White;
            View_Info.FlatAppearance.BorderColor = Color.White;
            Clear.FlatAppearance.BorderColor = Color.White;
            SearchLoc.Text = "-Disable-";
            SearchPro.Text = "-Disable-"; 
            SearchD.CustomFormat = "dd/MM/yyyy";
            SearchLocN.Enabled = false;
            GF.GetLocations(SearchLoc, true);
            GF.GetProfessions(SearchPro, true);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 0);
        }

        public void RefreshList()
        {
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_test = "select Code , InterName , Location as Loc , LocationN as LocN , Profession , Name as TestN , Path , Extension , convert(varchar , date , 3) as Date from Testemonial where ";
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
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_test, conn);
            DataTable Data = new DataTable();
            sqlAdapt.Fill(Data);
            Testemonial_Grid.DataSource = Data;
            conn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_Testemonial form = new Add_Testemonial();
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
            if (e.RowIndex < 0)
                return;
            string path = Testemonial_Grid.CurrentRow.Cells["Path"].Value.ToString() + "\\" + Testemonial_Grid.CurrentRow.Cells["TestN"].Value.ToString() + Testemonial_Grid.CurrentRow.Cells["Extension"].Value.ToString();
            if (File.Exists(path))
                System.Diagnostics.Process.Start(path);
            else MessageBox.Show("Error 404.\nFile not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GF.ClearRecords(Testemonial_Grid);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Server connection lost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((Main_Form)MainForm).Disconnected();
                this.Close();
                return;
            }
            GF.DeleteRecords(Testemonial_Grid, "testemonial", "TestN", "Path", "Extension", connectionString);
        }
    }
}
