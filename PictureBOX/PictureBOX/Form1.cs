﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Imgload_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"C:\Users\christopher.thomasi\Pictures\Saved Pictures\452.jpg");
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filePath);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
