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
            SearchLocN.Enabled = false;
            GF.GetLocations(SearchLoc, true);
            GF.GetProfessions(SearchPro, true);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 0);
        }

        public void RefreshList()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_test = "select Code , InterName , Location as Loc , LocationN as LocN , Profession , Name as TestN , Path , Extension , Date from Testemonial where ";
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
                get_test += "Date = '" + SearchD.Text.Replace("/" , "-") + "'";
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
            if (SearchLoc.Text == "-Disable-" && SearchPro.Text == "-Disable-" && SearchIN.Text.Length == 0 && SearchN.Text.Length == 0 && SearchP.Text.Length == 0 && SearchEx.Text.Length == 0 && DisableDate.Checked == true)
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

        private void DisableDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            foreach (DataGridViewRow row in Testemonial_Grid.Rows)
            {
                Testemonial_Grid.Rows.Remove(row);
            }
            DataGridViewRow r = Testemonial_Grid.Rows[0];
            Testemonial_Grid.Rows.Remove(r);
        }
    }
}
