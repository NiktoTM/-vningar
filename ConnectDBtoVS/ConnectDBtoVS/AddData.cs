﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDBtoVS
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void AddData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = InfoDb.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "insert into InfoTable(Fname, Lname) values('"+txtFname.Text+"', '"+txtLname.Text+"')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Success");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form1().ShowDialog();
        }
    }
}
