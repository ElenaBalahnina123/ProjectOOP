﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var Form1 = await new Form1(null).getForm1();
            
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

    }
}
