using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hanjinHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //call kg to lb function
            kgToLb();
            //call lb to kg function
            lbToKg();
            //call inch to cm function
            inchToCm();
            //call the cm to inch function
            cmToInch();
            //call the oz to lb function
            ozToLb();
            //call the lb to oz function
            lbToOz();
            //call the volume weight function
            volumeWeight();
        }

        private void kgToLb()
        {
            double result = double.Parse(kgtextBox.Text) / 0.45359237;
            kgToLBLabel.Text = result.ToString();
        }

        private void lbToKg()
        {
            double result = double.Parse(lbTextBox.Text) / 2.2046;
            lbTOKgLabel.Text = result.ToString();
        }

        private void inchToCm()
        {
            double result = double.Parse(inchTextBox.Text) / 0.39370;
            inchToCmLabel.Text = result.ToString();
        }

        private void cmToInch()
        {
            double result = double.Parse(cmTextBox.Text) * 0.39370;
            cmToInchLabel.Text = result.ToString();
        }

        private void ozToLb()
        {
            double result = double.Parse(ozTextBox.Text) / 16;
            ozToLbLabel.Text = result.ToString();
        }

        private void lbToOz()
        {
            double result = double.Parse(lbToOzTextBox.Text) * 16;
            lbToOzLabel.Text = result.ToString();
        }

        private void volumeWeight()
        {
            double dimresult = double.Parse(lengthTextBox.Text) * double.Parse(widthTextBox.Text) * double.Parse(heightTextBox.Text);
            var lbweight = dimresult / 166;
            volumeWeightLabel.Text = lbweight.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kgToLB_Click(object sender, EventArgs e)
        {

        }

        private void kgOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
