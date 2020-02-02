using System;
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

        int inc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(txtAge.Text);
            if (age>=18)
            {
                MessageBox.Show("Valid age");
            }
            else
            {
                inc++;
                if (inc>=3)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid Age");
                }
               
            }
            for (int i = 0; i < 10; i++)
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("new btn");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CoreApp.clsConnection_DAL clsConnection_DAL = new CoreApp.clsConnection_DAL();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi);
        }
    }
}
