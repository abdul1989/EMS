﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAge.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter age.");
            }
            else if (Convert.ToInt32(txtAge.Text)>18)
            {
                MessageBox.Show("valid age.");
            }
            else if (Convert.ToInt32(txtAge.Text) ==18)
            {
                MessageBox.Show("valid age.");
            }
            else
            {
                MessageBox.Show("Invalid Age");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }
    }
}
