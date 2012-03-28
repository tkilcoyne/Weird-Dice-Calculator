using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneDie1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void twoDie1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void threeDie1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void fourDie1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void oneDie2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void threeDie2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "3";
        }

        private void fourDie2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "4";
        }

        private void fiveDie2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "5";
        }

        private void sixDie2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "6";
        }

        private void eightDie2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "8";
        }
       

        private void goButton_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Int32.Parse(textBox1.Text) + Int32.Parse(textBox2.Text) + "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
