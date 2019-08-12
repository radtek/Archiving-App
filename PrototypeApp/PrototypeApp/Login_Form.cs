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
using FluentFTP;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Apex
{
    public partial class Login_Form : Form
    {
        GlobalFunc GF = new GlobalFunc();
        public string connectionString;
        public string user;
        public Login_Form()
        {
            InitializeComponent();
            Login.FlatAppearance.BorderColor = Color.White;
            Close.FlatAppearance.BorderColor = Color.White;
            ServerN.Text = GF.GetConnection("" , "" , 1);
            DatabaseN.Text = GF.GetConnection("" , "" , 2);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Process.Text = "Connecting to database server...";
            Bar.Style = ProgressBarStyle.Marquee;
            Bar.MarqueeAnimationSpeed = 30;
            connectionString = "Data Source=" + ServerN.Text + ";Initial Catalog =" + DatabaseN.Text + ";User id=" + UserName.Text + ";Password=" + Password.Text + ";";
            if (!GF.IsServerConnected(connectionString))
            {
                MessageBox.Show("Could not connect to server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Text = "";
                Bar.Style = ProgressBarStyle.Continuous;
                Bar.MarqueeAnimationSpeed = 0;
                return;
            }
            string loc = Directory.GetCurrentDirectory()+"/Logs";
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(loc, "DatabaseInfo.txt")))
            {
                outputFile.WriteLine("Server=" + ServerN.Text + Environment.NewLine + "Database=" + DatabaseN.Text);
            }
            connectionString = GF.GetConnection(UserName.Text, Password.Text);
            user = UserName.Text;
            this.Close();
        }

        private void Login_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
