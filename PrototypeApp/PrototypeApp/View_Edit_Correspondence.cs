﻿using System;
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
    public partial class View_Edit_Correspondence : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        static Form Correspondence_Form = Application.OpenForms["Correspondence_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        bool mode = false;
        public View_Edit_Correspondence(string name , string path , string ext , string subj , string srname , string sr , string date , bool edit)
        {
            InitializeComponent();
            Close.FlatAppearance.BorderColor = Color.White;
            Edit.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
            Done.FlatAppearance.BorderColor = Color.White;
            File_Name.Text = name;
            File_Path.Text = path;
            File_Extension.Text = ext;
            File_Date.Text = date;
            Subject.Text = subj;
            SRName.Text = srname;
            SR.Text = sr;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string get_desc = "select description from media where name = N'" + name + "' and path =N'" + path + "' and extension ='" + ext + "'";
            SqlCommand comm = new SqlCommand(get_desc, conn);
            if (edit)
            {
                EditMode();
            }
        }

        public bool NoChange(bool change_pk)
        {
            if (New_Name.Text == File_Name.Text && New_Path.Text == File_Path.Text && New_Extension.Text == File_Extension.Text && change_pk)
                return true;
            if (New_Name.Text == File_Name.Text && New_Path.Text == File_Path.Text && New_Extension.Text == File_Extension.Text && New_Date.Text == File_Date.Text && New_SRName.Text==SRName.Text && New_SR.Text==SR.Text && New_Subject.Text==Subject.Text)
                return true;
            return false;
        }

        public void EditMode()
        {
            mode = true;
            New_Name.Text = File_Name.Text;
            New_Path.Text = File_Path.Text;
            New_Extension.Text = File_Extension.Text;
            New_Date.Text = File_Date.Text;
            New_Subject.Text = Subject.Text;
            New_SRName.Text = SRName.Text;
            New_SR.Text = SR.Text;
            Done.Visible = true;
            Cancel.Visible = true;
            New_Name.Visible = true;
            New_Path.Visible = true;
            New_Extension.Visible = true;
            New_Date.Visible = true;
            New_Subject.Visible = true;
            New_SRName.Visible = true;
            New_SR.Visible = true;
        }

        public void ViewMode()
        {
            mode = false;
            Done.Visible = false;
            Cancel.Visible = false;
            New_Name.Visible = false;
            New_Path.Visible = false;
            New_Extension.Visible = false;
            New_Date.Visible = false;
            New_Subject.Visible = false;
            New_SRName.Visible = false;
            New_SR.Visible = false;
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
            if (!File.Exists(New_Path.Text + "\\" + New_Name.Text + New_Extension.Text))
            {
                MessageBox.Show("Error 404.\nCouldn't find the file in the new path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (GF.CheckExistance(New_Name.Text.Replace("'", "''") + "-" + New_Path.Text.Replace("'", "''") + "-" + New_Extension.Text.Replace("'", "''"), "correspondence", connectionString) && !NoChange(true))
            {
                MessageBox.Show("File already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string edit_record_set = "update Correspondence set name = N'" + New_Name.Text.Replace("'", "''") + "',path=N'" + New_Path.Text.Replace("'", "''") + "',extension='" + New_Extension.Text.Replace("'", "''") + "',date='" + New_Date.Text.Replace("/", "-") + "',srname=N'"+New_SRName.Text+"',sr='"+New_SR.Text+"',subject=N'"+New_Subject.Text+"' ";
            string edit_record_condition = "where name = N'" + File_Name.Text.Replace("'", "''") + "' and path=N'" + File_Path.Text.Replace("'", "''") + "' and extension='" + File_Extension.Text.Replace("'", "''") + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand(edit_record_set + edit_record_condition, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully edited file info!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ((Correspondence_Form)Correspondence_Form).Refresh();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if ((NoChange(false) && mode == true) || (mode == false))
            {
                this.Close();
                return;
            }
            DialogResult res = MessageBox.Show("Discard changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (NoChange(false))
            {
                ViewMode();
                return;
            }
            DialogResult res = MessageBox.Show("Discard changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.No)
                return;
            ViewMode();
        }
    }
}