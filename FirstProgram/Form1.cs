using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FirstProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            outputLabel.BackColor = Color.Red;
            outputLabel.ForeColor = Color.White;
            outputLabel.Text = "SIGMAS TRANSFORMING";
            //this.Text = "RUN AWAY!!!!!!";
            //this.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            reactor1StateLabel.BackColor = Color.White;
            reactor2StateLabel.BackColor = Color.White;
            outputLabel.BackColor = Color.White;
            outputLabel.ForeColor = Color.Red;
            
        }

        private void label6_Click(object sender, EventArgs e)c 
        {

        }
    }

}
