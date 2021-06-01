using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Second : Form
    {
        NormalClass normal = new NormalClass();
        public Second()
        {
            InitializeComponent();
        }

        //hiding groupboxes when form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //assigning values
                double one = double.Parse(textBox1.Text);
                Globals.renting = one;
            }

            //displaying a new form 
            Vehicle frm = new Vehicle();
            frm.Show();

            //hiding the form 
            Second form = new Second();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                //adding values
                double price = double.Parse(textBox2.Text);
                double deposit = double.Parse(textBox4.Text);
                double interest = double.Parse(textBox6.Text);
                double months = double.Parse(textBox8.Text);
                normal.calcHomeRepayment(0, Globals.AvailableAmount, price, deposit, interest, months).ToString();

                //allowing other classes to access 
                Globals.homelonerepayment = normal.calcHomeRepayment(0, Globals.AvailableAmount, price, deposit, interest, months);
            }

            //displaying a new form 
            Vehicle frm = new Vehicle();
            frm.Show();

            //hiding the form 
            Second form = new Second();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //hiding and showing UIs

            if (radioButton1.Checked)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }
    }
}
