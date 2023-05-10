using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form1().ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = InfoDb.accdb";
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from InfoTable where Fname = '"+txtFnameDel+"'";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Success");
        }
    }
}
