using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFAOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        double total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string productName = txtproductName.Text;
            double productPrice = double.Parse(txtproductPrice.Text);
            double changedPrice=0;
            if (radioButton1.Checked)
            {
                changedPrice = productPrice * 0.97;   
            }
            else if (radioButton2.Checked)
            {
                changedPrice = productPrice * 0.95;
            }
            else if (radioButton3.Checked)
            {
                changedPrice = productPrice;
            }

            total += changedPrice;
            listBox1.Items.Add(productName+" "+ changedPrice + " TL");

          
            textBox3.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = 0;
            textBox3.Text = total.ToString();

            listBox1.Items.Clear();
            txtproductName.Clear();
            txtproductPrice.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
