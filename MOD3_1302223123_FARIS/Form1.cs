using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD3_1302223123_FARIS
{
    public partial class Form1 : Form
    {
        string tampung1, tampung2, tampung3, tampung4, tampung5, tampung6, tampung7, tampung8, tampung9, tampung0;
        int memori1, memori2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tampung1 += "1";
            outputLabel.Text += tampung1;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            memori1 = Convert.ToInt32(outputLabel.Text);
            outputLabel.Text = "";
        }

        private void buttonSama_Click(object sender, EventArgs e)
        {
            memori2 = Convert.ToInt32(outputLabel.Text);
            outputLabel.Text = Convert.ToString(memori1 + memori2) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampung2 += "2";
            outputLabel.Text += tampung2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tampung3 += "3";
            outputLabel.Text += tampung3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tampung4 += "4";
            outputLabel.Text += tampung4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tampung5 += "5";
            outputLabel.Text += tampung5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tampung6 += "6";
            outputLabel.Text += tampung6;        
        }   

        private void button7_Click(object sender, EventArgs e)
        {
            tampung7 += "7";
            outputLabel.Text += tampung7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tampung8 += "8";
            outputLabel.Text += tampung8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tampung9 += "9";
           outputLabel.Text += tampung9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            tampung0 += "0";
            outputLabel.Text += tampung0;
        }
    }
}
