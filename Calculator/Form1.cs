using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        double val_curenta, total;
        bool Op_Ap;
        char semn_operatie;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {//clear  
            textBox1.Text = "";
            val_curenta = 0;
            total = 0;
            Op_Ap = false;
            semn_operatie = '=';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //backspace
            if(textBox1.Text != "") textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            val_curenta = 0;
            total = 0;
            Op_Ap = false;
            semn_operatie = '=';
 
        } 

        private void button13_Click(object sender, EventArgs e)
        {
            switch(semn_operatie)
            {
                case '+': total = total + double.Parse(textBox1.Text); Op_Ap = false; break;
                case '-': total = total - double.Parse(textBox1.Text); Op_Ap = false; break;
                case '*': total = total * double.Parse(textBox1.Text); Op_Ap = false; break;
                case '/': total = total / double.Parse(textBox1.Text); Op_Ap = false; break;
                case '%': total = total % double.Parse(textBox1.Text); Op_Ap = false; break;
            }
            textBox1.Text = total.ToString();
        }


        private void button10_Click(object sender, EventArgs e)
        {
            val_curenta = double.Parse(textBox1.Text);
            textBox1.Text = "";
            if (!Op_Ap) { total = val_curenta; Op_Ap = true; semn_operatie = '+'; }
            else { total += val_curenta; semn_operatie = '+'; }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            val_curenta = double.Parse(textBox1.Text);
            textBox1.Text = "";
            if (!Op_Ap) { total = val_curenta; Op_Ap = true; semn_operatie = '-'; }
            else { total -= val_curenta; semn_operatie = '-'; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            val_curenta = double.Parse(textBox1.Text);
            textBox1.Text = "";
            if (!Op_Ap) { total = val_curenta; Op_Ap = true; semn_operatie = '*'; }
            else { total *= val_curenta; semn_operatie = '*'; }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            val_curenta = double.Parse(textBox1.Text);
            textBox1.Text = "";
            if (!Op_Ap) { total = val_curenta; Op_Ap = true; semn_operatie = '/'; }
            else { total /= val_curenta; semn_operatie = '/'; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            val_curenta = double.Parse(textBox1.Text);
            textBox1.Text = "";
            if (!Op_Ap) { total = val_curenta; Op_Ap = true; semn_operatie = '%'; }
            else { total %= val_curenta; semn_operatie = '%'; }
        }

        
    }
}
