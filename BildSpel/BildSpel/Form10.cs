﻿using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Ja1_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form12().ShowDialog();
        }

        private void Nej1_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Form11().ShowDialog();
        }
    }
}
