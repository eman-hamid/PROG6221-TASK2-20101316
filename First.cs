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
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void First_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //displaying a new form

            Expense frm = new Expense();
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                
            }

            if (!textBox2.Text.Equals(""))
            {
                double netAmount = Double.Parse(textBox1.Text) - (Double.Parse(textBox2.Text) / 100 * Double.Parse(textBox1.Text));
                netAmountTxt.Text = netAmount.ToString();
                Globals.AvailableAmount = netAmount;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        //reset button
        private void button1_Click(object sender, EventArgs e)
        {
           //hiding and showing the form again

            First form = new First();
            this.Hide();
            form.Show();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //error handling message

            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Fill Gross");
                textBox1.Enabled = true;
                textBox1.Focus();
            } else
            {
                textBox1.Enabled = false;
            }
        }
    }
}
