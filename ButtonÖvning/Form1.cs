﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonÖvning
{
    public partial class Form1 : Form
    {
        int total_clicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Counter_MouseClick(object sender, MouseEventArgs e)
        {
            total_clicks++;
            Counter.Text = total_clicks.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "Texten har ändrats";
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Orange;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Location = new Point(5, 5);
        }
    }
}
