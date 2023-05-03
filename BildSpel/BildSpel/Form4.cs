using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BildSpel
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Nej2_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form6().ShowDialog();
        }

        private void Ja2_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form10().ShowDialog();

        }
    }
}