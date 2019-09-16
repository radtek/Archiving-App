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
    public partial class Add_Testemonial : Form
    {
        static Form MainForm = Application.OpenForms["Main_Form"];
        public string connectionString = ((Main_Form)MainForm).connectionString;
        GlobalFunc GF = new GlobalFunc();
        Dictionary<string, bool> map = new Dictionary<string, bool>();
        public Add_Testemonial()
        {
            InitializeComponent();
            Browse.FlatAppearance.BorderColor = Color.White;
            Add.FlatAppearance.BorderColor = Color.White;
            Cancel.FlatAppearance.BorderColor = Color.White;
            GF.GetLocations(AddLoc , false);
            GF.GetProfessions(AddPro, false);
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if(AddIN.Text.Length == 0 || AddLocN.Text.Length==0)
            {
                MessageBox.Show("Please, fill the whole form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OpenFileDialog Browse_File_Wind = new OpenFileDialog();
            Browse_File_Wind.Multiselect = true;
            if (Browse_File_Wind.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] loc = Browse_File_Wind.FileNames;
                foreach (string i in loc)
                {
                    string code = GF.GetCode("Testemonial" , map , connectionString);
                    map.Add(code, true);
                    string name = Path.GetFileNameWithoutExtension(i);
                    string intername = AddIN.Text;
                    string location = AddLoc.Text;
                    string locationN = AddLocN.Text;
                    string profession = AddPro.Text;
                    string date = AddDate.Text;
                    string extension = Path.GetExtension(i);
                    string path = Path.GetDirectoryName(i);
                    if(GF.CheckExistance(name+"-"+path+"-"+extension , "testemonial" , connectionString))
                    {
                        MessageBox.Show("name+extension already exists in Testemonial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    SelectedFiles.Rows.Add(code , name , intername , location , locationN , profession , date , extension , path);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string add_files = "insert into testemonial(code ,name , intername , location , locationn , profession , date , extension , path) values";
            foreach (DataGridViewRow row in SelectedFiles.Rows)
            {
                string code = row.Cells[0].Value.ToString().Replace("'", "''");
                string name = row.Cells[1].Value.ToString().Replace("'", "''");
                string intername = row.Cells[2].Value.ToString().Replace("'", "''");
                string location = row.Cells[3].Value.ToString().Replace("'", "''");
                string locationN = row.Cells[4].Value.ToString().Replace("'", "''");
                string profession = row.Cells[5].Value.ToString().Replace("'", "''");
                string date = row.Cells[6].Value.ToString().Replace("-", "/");
                string extension = row.Cells[7].Value.ToString().Replace("'", "''");
                string path = row.Cells[8].Value.ToString().Replace("'", "''");
                add_files += "('" + code + "',N'" + name + "',N'" + intername + "',N'" + location + "',N'" + locationN + "',N'" + profession + "','" + date + "','" + extension + "',N'" + path + "'),";
            }
            add_files = add_files.Remove(add_files.Length - 1);
            SqlCommand comm = new SqlCommand(add_files, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Successfully added file info!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach (DataGridViewRow row in SelectedFiles.Rows)
            {
                SelectedFiles.Rows.Remove(row);
            }
            foreach (DataGridViewRow row in SelectedFiles.Rows)
            {
                SelectedFiles.Rows.Remove(row);
            }
        }
    }
}
