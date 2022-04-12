using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        string a;
        double b, c, s, n, res;

        private void button23_Click(object sender, EventArgs e)
        {
            var d = sender as Button;
            a = d.Text;
            b = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture) * (Math.PI / 180);
            switch (a)
            {
                case "sin(x)":
                    textBox1.Text = Math.Sin(b).ToString();
                    return;
                case "cos(x)":
                    textBox1.Text = Math.Cos(b).ToString();
                    return;
                case "tg(x)":
                    textBox1.Text = Math.Tan(b).ToString();
                    return;

            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            var d = sender as Button;
            a = d.Text;

            s = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains('.'))
            {
                textBox1.Text += ".";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);
            n = Math.Pow(s, 2);

            textBox1.Text = n.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = res.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var d = sender as Button;
            a = d.Text;

            b = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = sender as Button;
            if (textBox1.Text == "0")
                textBox1.Text = d.Text;

            else
                textBox1.Text += d.Text;

            c = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);

            switch (a)
            {
                case "+":
                    res = b + c;
                    return;
                case "-":
                    res = b - c;
                    return;
                case "×":
                    res = b * c;
                    return;
                case "÷":
                    res = b / c;
                    return;
                case "ⁿ√x":
                    res = Math.Pow(s, 1 / c);
                    return;
                case "xⁿ":
                    res = Math.Pow(s, c);
                    return;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
        }
    }
}
