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
    public partial class Expense : Form
    {
        NormalClass NormalClass = new NormalClass();

        public Expense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaring values 

            double one = Double.Parse(textBox3.Text);
            double two = Double.Parse(textBox4.Text);
            double three = Double.Parse(textBox5.Text);
            double four = Double.Parse(textBox6.Text);
            double five = Double.Parse(textBox7.Text);
            NormalClass.calcExpenses(one, two, three, four, five).ToString();

            //displaying the next form 
            Second frm = new Second();
            frm.Show();

            //hiding the form 
            Expense form = new Expense();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //method for calculating expense 
            double expenses = Double.Parse(textBox3.Text) + Double.Parse(textBox4.Text)
                + Double.Parse(textBox5.Text) + Double.Parse(textBox6.Text) + Double.Parse(textBox7.Text);

            explbl.Text = expenses.ToString();

            //making it available to other classes
            Globals.ExpenseMade = expenses;

            //generic collection 

            List<double> expense = new List<double>();
            expense.Add(Convert.ToDouble(textBox3.Text));
            expense.Add(Convert.ToDouble(textBox4.Text));
            expense.Add(Convert.ToDouble(textBox5.Text));
            expense.Add(Convert.ToDouble(textBox6.Text));
            expense.Add(Convert.ToDouble(textBox7.Text));

            //making the array availbe for all classes
            Globals.array = expense;
        }
    }
}
