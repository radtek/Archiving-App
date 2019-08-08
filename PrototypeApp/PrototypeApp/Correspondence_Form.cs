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

namespace PrototypeApp
{
    public partial class Correspondence_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        public Correspondence_Form()
        {
            InitializeComponent();
            Add.FlatAppearance.BorderColor = Color.White;
            Delete.FlatAppearance.BorderColor = Color.White;
            Edit.FlatAppearance.BorderColor = Color.White;
            Search.FlatAppearance.BorderColor = Color.White;
            View_Info.FlatAppearance.BorderColor = Color.White;
        }

        public void Refresh()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_Correspondence = "select SR as SR , SRName as SRName , Subject as Subj , Date as Date , path as Path from correspondence ";
            if (SearchN.Text.Length != 0 || SearchP.Text.Length != 0 || SearchS.Text.Length != 0 || (OnlyS.Checked && !OnlyR.Checked) || (!OnlyS.Checked && OnlyR.Checked) || !DisableDate.Checked)
                get_Correspondence += "where ";
            string original_query = get_Correspondence;
            if (SearchN.Text.Length != 0)
            {
                get_Correspondence += "srname like '%" + SearchN.Text.Replace("'", "''") + "%' ";
            }
            if (SearchP.Text.Length != 0)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "path like '%" + SearchP.Text.Replace("'", "''") + "%' ";
            }
            if (SearchS.Text.Length != 0)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "subject like '%" + SearchS.Text.Replace("'", "''") + "%' ";
            }
            if(OnlyS.Checked && !OnlyR.Checked)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "sr = 's' ";
            }
            if (OnlyR.Checked && !OnlyS.Checked)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "sr = 'r' ";
            }
            if(!DisableDate.Checked)
            {
                if (get_Correspondence != original_query) get_Correspondence += "and ";
                get_Correspondence += "date = '" + SearchD.Text.Replace("/" , "-") + "' ";
            }
            SqlDataAdapter sqlAdapt = new SqlDataAdapter(get_Correspondence, conn);
            DataTable Mails_Data = new DataTable();
            sqlAdapt.Fill(Mails_Data);
            Correspondence_Grid.DataSource = Mails_Data;
            conn.Close();
        }

        private void Correspondence_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
