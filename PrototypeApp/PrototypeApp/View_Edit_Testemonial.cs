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
    public partial class View_Edit_Testemonial : Form
    {
        static readonly Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        static Form Testemonial_Form = Application.OpenForms["Testemonial_Form"];
        readonly string Database = ((Main_Form)MainForm).database;
        readonly string User = ((Main_Form)MainForm).user;
        readonly GlobalFunc GF = new GlobalFunc();
        public View_Edit_Testemonial(string code, string locationN, string interName, string location, string profession, string date, string fileName, string path, string extension)
        {
            InitializeComponent();
            GF.EditButtons(this);
            New_Date.CustomFormat = "dd/MM/yyyy";
            File_Name.Text = fileName;
            File_Path.Text = path;
            File_Extension.Text = extension;
            Profession.Text = profession;
            Date.Text = date;
            InterName.Text = interName;
            Location.Text = location;
            LocationN.Text = locationN;
            Code.Text = code;
            ViewMode();
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
                                New_Location.Items.Add(reader["location"].ToString());
                            }
                            reader.Dispose();
                        }
                        using (SqlCommand comm = new SqlCommand(getProfessions, conn))
                        {
                            SqlDataReader reader = comm.ExecuteReader();
                            while (reader.Read())
                            {
                                New_Profession.Items.Add(reader["profession"].ToString());
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
        private void EditMode()
        {
            New_Profession.Text = Profession.Text;
            New_Date.Value = DateTime.ParseExact(Date.Text, "dd/MM/yyyy", null);
            New_InterName.Text = InterName.Text;
            New_Location.Text = Location.Text;
            New_LocationN.Text = LocationN.Text;
            Edit.Visible = false;
            Done.Visible = true;
            Cancel.Visible = true;
            New_Profession.Visible = true;
            New_Date.Visible = true;
            New_InterName.Visible = true;
            New_LocationN.Visible = true;
            New_Location.Visible = true;
        }
        private void ViewMode()
        {
            Edit.Visible = true;
            Done.Visible = false;
            Cancel.Visible = false;
            New_Profession.Visible = false;
            New_Date.Visible = false;
            New_InterName.Visible = false;
            New_LocationN.Visible = false;
            New_Location.Visible = false;
        }
        public bool NoChange(bool change_pk)
        {
            if (New_Profession.Text == Profession.Text
                && New_InterName.Text == InterName.Text
                && New_Date.Text == Date.Text
                && New_LocationN.Text == LocationN.Text
                && New_Location.Text == Location.Text)
                return true;
            return false;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string[] parts = New_Date.Text.Split('/');
            string date = parts[1] + "-" + parts[0] + "-" + parts[2];
            string edit_record_set = "update testemonial set profession=N'" + New_Profession.Text.Replace("'" , "''") + "'" +
                                     ",date='" + date + "'" +
                                     ",Location=N'" + New_Location.Text.Replace("'", "''") + "'" +
                                     ",LocationN=N'" + New_LocationN.Text.Replace("'", "''") + "'" +
                                     ",InterName=N'" + New_InterName.Text.Replace("'", "''") + "'";
            string edit_record_condition = "where name = N'" + File_Name.Text.Replace("'", "''") + "' and path=N'" + File_Path.Text.Replace("'", "''") + "' and extension='" + File_Extension.Text.Replace("'", "''") + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(edit_record_set + edit_record_condition, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully edited file info!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((Testemonials_Form)Testemonial_Form).RefreshList();
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
    }
}
