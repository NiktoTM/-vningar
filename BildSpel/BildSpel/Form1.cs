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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Starta_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void Starta_Click(object sender, EventArgs e)
        {
            this.Hide();

            new Selection().ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
