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
    public partial class Settings_Form : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        string User = ((Main_Form)MainForm).user;
        string Database = ((Main_Form)MainForm).database;
        GlobalFunc GF = new GlobalFunc();
        public Settings_Form()
        {
            InitializeComponent();
            GF.EditButtons(this);
            foreach(Panel p in Controls.OfType<Panel>())
            {
                GF.EditButtons(p);
                p.Visible = false;
            }
            if (!GF.CheckAdminPerm(User, connectionString, this, MainForm))
            {
                GF.CheckPerm(User, "insert", Database, "professions", connectionString, this, MainForm, ProAdd);
                GF.CheckPerm(User, "delete", Database, "professions", connectionString, this, MainForm, ProDelete);
                GF.CheckPerm(User, "insert", Database, "locations", connectionString, this, MainForm, LocAdd);
                GF.CheckPerm(User, "delete", Database, "locations", connectionString, this, MainForm, LocDelete);
                GF.CheckPerm(User, "insert", Database, "jobs", connectionString, this, MainForm, AddJob);
                GF.CheckPerm(User, "delete", Database, "jobs", connectionString, this, MainForm, DeleteJob);
            }
        }

        private void ProAdd_Click(object sender, EventArgs e)
        {
            if (Pro.Text.Length == 0)
                return;
            string insertPro = "insert into professions values(N'" + Pro.Text.Replace("'" , "''")+"')";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(insertPro , conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                    }
                    catch(SqlException)
                    {
                        MessageBox.Show("This Profession already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch(SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
            ShowTestemonialSettings();
        }

        private void LocAdd_Click(object sender, EventArgs e)
        {
            if (Loc.Text.Length == 0)
                return;
            string insertPro = "insert into locations values(N'" + Loc.Text.Replace("'", "''") + "')";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(insertPro, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("This Location already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
            ShowTestemonialSettings();
        }

        private void ProDelete_Click(object sender, EventArgs e)
        {
            string removePro = "delete from professions where profession = N'";
            foreach (DataGridViewRow r in Professions_Grid.SelectedRows)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        try
                        {
                            using (SqlCommand comm = new SqlCommand(removePro + r.Cells["Professions"].Value.ToString().Replace("'" , "''") + "'", conn))
                            {
                                comm.ExecuteNonQuery();
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
            ShowTestemonialSettings();
        }

        private void LocDelete_Click(object sender, EventArgs e)
        {
            string removePro = "delete from locations where location = N'";
            foreach (DataGridViewRow r in Locations_Grid.SelectedRows)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        try
                        {
                            using (SqlCommand comm = new SqlCommand(removePro + r.Cells[0].Value.ToString().Replace("'", "''") + "'", conn))
                            {
                                comm.ExecuteNonQuery();
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
            ShowTestemonialSettings();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ShowTestemonialSettings()
        {
            foreach(Panel p in Controls.OfType<Panel>())
            {
                p.Visible = false;
            }
            Testemonial_Panel.Visible = true;

            string getProfessions = "select * from professions";
            string getLocations = "select * from locations";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        if (ProAdd.Enabled && ProDelete.Enabled)
                            using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(getProfessions, conn))
                            {
                                DataTable Data = new DataTable();
                                sqlAdapt.Fill(Data);
                                Professions_Grid.DataSource = Data;
                                Data.Dispose();
                            }
                        if (LocAdd.Enabled && LocDelete.Enabled)
                            using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(getLocations, conn))
                            {
                                DataTable Data = new DataTable();
                                sqlAdapt.Fill(Data);
                                Locations_Grid.DataSource = Data;
                                Data.Dispose();
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
        private void ShowHRSettings()
        {
            foreach (Panel p in Controls.OfType<Panel>())
            {
                p.Visible = false;
            }
            HR_Panel.Visible = true;

            string getJobs = "select * from jobs";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (AddJob.Enabled && DeleteJob.Enabled)
                        try
                        {
                            using (SqlDataAdapter sqlAdapt = new SqlDataAdapter(getJobs, conn))
                            {
                                DataTable Data = new DataTable();
                                sqlAdapt.Fill(Data);
                                Jobs_Grid.DataSource = Data;
                                Data.Dispose();
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
        private void TestemonialSetings_Click(object sender, EventArgs e)
        {
            ShowTestemonialSettings();
        }

        private void AddJob_Click(object sender, EventArgs e)
        {
            if (JobTB.Text.Length == 0)
                return;
            string insertJob = "insert into jobs values(N'" + JobTB.Text.Replace("'", "''") + "')";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (SqlCommand comm = new SqlCommand(insertJob, conn))
                        {
                            comm.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("This Job already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (SqlException)
            {
                GF.ConnectionLost(this, MainForm);
                return;
            }
            ShowHRSettings();
        }

        private void HRSettings_Click(object sender, EventArgs e)
        {
            ShowHRSettings();
        }

        private void DeleteJob_Click(object sender, EventArgs e)
        {
            string removeJob = "delete from jobs where jobname = N'";
            foreach (DataGridViewRow r in Jobs_Grid.SelectedRows)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        try
                        {
                            using (SqlCommand comm = new SqlCommand(removeJob + r.Cells["jobs"].Value.ToString().Replace("'", "''") + "'", conn))
                            {
                                //MessageBox.Show(removeJob + r.Cells["jobs"].Value.ToString().Replace("'", "''") + "'");
                                comm.ExecuteNonQuery();
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
            ShowHRSettings();
        }
    }
}
