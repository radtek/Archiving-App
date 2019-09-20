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
    public partial class Settings_Form : Form
    {
        string locPath = "Data/Locations.txt", proPath = "Data/Professions.txt";
        public Settings_Form()
        {
            InitializeComponent();
            ProAdd.FlatAppearance.BorderColor = Color.White;
            ProDelete.FlatAppearance.BorderColor = Color.White;
            LocAdd.FlatAppearance.BorderColor = Color.White;
            LocDelete.FlatAppearance.BorderColor = Color.White;
            Save.FlatAppearance.BorderColor = Color.White;
            Close.FlatAppearance.BorderColor = Color.White;
            FillGrids();
        }

        public void FillGrids()
        {
            using (StreamReader file = new StreamReader(proPath))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Professions_Grid.Rows.Add(ln);
                }
            }
            using (StreamReader file = new StreamReader(locPath))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Locations_Grid.Rows.Add(ln);
                }
            }
        }

        private void ProAdd_Click(object sender, EventArgs e)
        {
            if (Pro.Text.Length == 0)
                return;
            Professions_Grid.Rows.Add(Pro.Text);
        }

        private void LocAdd_Click(object sender, EventArgs e)
        {
            if (Loc.Text.Length == 0)
                return;
            Professions_Grid.Rows.Add(Loc.Text);
        }

        private void ProDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in Professions_Grid.SelectedRows)
            {
                Professions_Grid.Rows.Remove(r);
            }
        }

        private void LocDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in Locations_Grid.SelectedRows)
            {
                Locations_Grid.Rows.Remove(r);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText(proPath, String.Empty);
            using (StreamWriter file = new StreamWriter(proPath))
            {
                foreach (DataGridViewRow r in Professions_Grid.Rows)
                {
                    file.WriteLine(r.Cells[0].Value.ToString());
                }
            }
            File.WriteAllText(locPath, String.Empty);
            using (StreamWriter file = new StreamWriter(locPath))
            {
                foreach (DataGridViewRow r in Locations_Grid.Rows)
                {
                    file.WriteLine(r.Cells[0].Value.ToString());
                }
            }
            this.Close();
        }
    }
}
