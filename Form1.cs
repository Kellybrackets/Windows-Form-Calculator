using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut8_question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Calctotal;
        int num1;
        int num2;
        string option;
        int result;

        private void button1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + btn0.Text;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtdisplay.Text);
            if (option.Equals("+"))
                result = num1 + num2;
            if (option.Equals("-"))
                result = num1 - num2;
            if (option.Equals("*"))
                result = num1 * num2;
            if (option.Equals("/"))
                result = num1 / num2;
            txtdisplay.Text = result + "";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            option = "=";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);

        }
    }
}
