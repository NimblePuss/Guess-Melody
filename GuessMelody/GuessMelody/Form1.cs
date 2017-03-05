﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class Form1 : Form
    {
        private fParams fp;
        
        public Form1()
        {
            InitializeComponent();
            fp = new fParams();
        }

        private void button_Game_Click(object sender, EventArgs e)
        {

        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            fp.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Victorina.ReadParams();
            Victorina.ReadMusic();
        }
    }
}
