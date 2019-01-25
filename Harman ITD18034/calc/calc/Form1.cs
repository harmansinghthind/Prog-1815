using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {


        double value = 0;
        string operation = "" ;
        bool oppress = false;



        public Form1()
        {
            InitializeComponent();
        }
        // button c
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // calculation
        private void button10_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (oppress))
                richTextBox1.Clear();

            oppress = false;

            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }
        // button ce
        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
        // calcul
        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            oppress = true;
            equation.Text = value + " " + operation;

        }
        // =
        private void button13_Click(object sender, EventArgs e)
        {
           
            equation.Text = "";
            switch (operation)
            {

                case "+":
                    richTextBox1.Text=(value+ double.Parse(richTextBox1.Text)).ToString();
                    break;


                case "-":
                    richTextBox1.Text = (value - double.Parse(richTextBox1.Text)).ToString();
                    break;


                case "*":
                    richTextBox1.Text = (value * double.Parse(richTextBox1.Text)).ToString();
                    break;


                case "/":
                    richTextBox1.Text = (value / double.Parse(richTextBox1.Text)).ToString();
                    break;


                default:
                    break;

            }//switchends

            



        }
    }
}
