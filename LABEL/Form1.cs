using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABEL
{
    public partial class Form1 : Form
    {
        int total_clicks = 0;
        public Form1()
        {
            InitializeComponent();
            label3.Text = "Flytta muspekaren över mig!";
            label4.Text = "Välkommen!";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.Magenta;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Magenta;
            ForeColor = Color.White;
            total_clicks++;
            label2.Text = total_clicks.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int x, y;

            Random random = new Random();
            x = random.Next(0, 800);
            y = random.Next(0, 500);

            label2.Left = x;
            label2.Top = y;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "Tack för att du besökte";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
