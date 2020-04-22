using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.OperatorsOverload
{
    public partial class Form1 : Form
    {
        int seed = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void AutoGenerateBtn_Click(object sender, EventArgs e)
        {
            Fraction a = new Fraction(seed++);
            Fraction b = new Fraction(seed++);
            Fraction c = new Fraction(seed++);
            Fraction d1 = new Fraction();
            Fraction d2 = new Fraction();

            a = a.Simplify();
            b = b.Simplify();
            c = c.Simplify();

            a1.Text = a.Numerator.ToString();
            a2.Text = a.Denominator.ToString();

            b1.Text = b.Numerator.ToString();
            b2.Text = b.Denominator.ToString();

            c1.Text = c.Numerator.ToString();
            c2.Text = c.Denominator.ToString();

            d1 = (c + a) * c.Flip();
            d1 = d1.Simplify();

            d1Num.Text = d1.Numerator.ToString();
            d1Denom.Text = d1.Denominator.ToString();

            d2 = (a - a.Flip()) / a;
            d2 = d2.Simplify();

            d2Num.Text = d2.Numerator.ToString();
            d2Denom.Text = d2.Denominator.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
