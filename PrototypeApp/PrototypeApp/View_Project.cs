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
    public partial class View_Project : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        static Form Projects_Form = Application.OpenForms["Projects_Form"];
        readonly string Database = ((Main_Form)MainForm).database;
        readonly string User = ((Main_Form)MainForm).user;
        readonly GlobalFunc GF = new GlobalFunc();
        public View_Project(string code,string partner,string projectN,string loc,string startDate,string endDate,string fileName,string path,string extension)
        {
            InitializeComponent();
            GF.EditButtons(this);
            New_StartDate.CustomFormat = "dd/MM/yyyy";
            New_EndDate.CustomFormat = "dd/MM/yyyy";
            File_Name.Text = fileName;
            File_Path.Text = path;
            File_Extension.Text = extension;
            StartDate.Text = startDate;
            EndDate.Text = endDate;
            ProjectName.Text = projectN;
            Location.Text = loc;
            Partner.Text = partner;
            Code.Text = code;

            ViewMode();
        }

        private void EditMode()
        {
            New_StartDate.Value = DateTime.ParseExact(StartDate.Text, "dd/MM/yyyy", null);
            New_EndDate.Value = DateTime.ParseExact(EndDate.Text, "dd/MM/yyyy", null);
            New_ProjectName.Text = ProjectName.Text;
            New_Location.Text = Location.Text;
            New_Partner.Text = Partner.Text;
            Edit.Visible = false;
            Done.Visible = true;
            Cancel.Visible = true;
            New_StartDate.Visible = true;
            New_EndDate.Visible = true;
            New_ProjectName.Visible = true;
            New_Partner.Visible = true;
            New_Location.Visible = true;
        }
        private void ViewMode()
        {
            Edit.Visible = true;
            Done.Visible = false;
            Cancel.Visible = false;
            New_StartDate.Visible = false;
            New_EndDate.Visible = false;
            New_ProjectName.Visible = false;
            New_Partner.Visible = false;
            New_Location.Visible = false;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ViewMode();
        }

        public bool NoChange(bool change_pk)
        {
            if (New_StartDate.Text == StartDate.Text 
                && New_ProjectName.Text == ProjectName.Text
                && New_EndDate.Text == EndDate.Text 
                && New_Partner.Text == Partner.Text 
                && New_Location.Text == Location.Text)
                return true;
            return false;
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
            string[] parts = New_StartDate.Text.Split('/');
            string startDate = parts[1] + "-" + parts[0] + "-" + parts[2];
            parts = New_EndDate.Text.Split('/');
            string endDate = parts[1] + "-" + parts[0] + "-" + parts[2];
            string edit_record_set = "update projects set startdate='" + startDate + "'" +
                                     ",enddate='" + endDate + "'" +
                                     ",location=N'" + New_Location.Text.Replace("'", "''") + "'" +
                                     ",partner=N'" + New_Partner.Text.Replace("'", "''") + "'" +
                                     ",projectName=N'" + New_ProjectName.Text.Replace("'", "''") + "'";
            string edit_record_condition = "where name = N'" + File_Name.Text.Replace("'", "''") + "' and path=N'" + File_Path.Text.Replace("'", "''") + "' and extension='" + File_Extension.Text.Replace("'", "''") + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(edit_record_set + edit_record_condition, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully edited file info!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((Projects_Form)Projects_Form).RefreshList();
            this.Close();
        }
    }
}
