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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddData frmAdd = new AddData();
            frmAdd.ShowDialog();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 fr2 = new Form2();
            new Form2().ShowDialog();
        }
    }
}
