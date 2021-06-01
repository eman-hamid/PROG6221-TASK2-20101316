using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Vehicle : Form
    {
        NormalClass Normal = new NormalClass();
        public Vehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //assigning values
            string one = textBox1.Text;
            double two = double.Parse(textBox2.Text);
            double three = double.Parse(textBox3.Text);
            double four = double.Parse(textBox4.Text);
            double five = double.Parse(textBox5.Text);
            Normal.calcvehicleRepayment(one, two, three, four, five).ToString();

            //can be accessed by all classes
            Globals.vehicle = Normal.calcvehicleRepayment(one, two, three, four, five);

            //allowing vehicle model to be used in all classes 
            Globals.model = one;

            //showing the final form
            Final final = new Final();
            final.Show();

            //hiding the form 
            Vehicle vehicle = new Vehicle();
            vehicle.Hide();

            //error handling: 

            if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Purchase price is required!!");
            }

            if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Cannot leave field empty!!");
            }
        }

        public void Validator()
        {
            textBox2.Enabled = false;
            label7.Text = "Please enter only alphabetical letters";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Text = "";
            string name = textBox1.Text;
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                textBox2.Enabled = true;
            else
                Validator();
        }

        // Adapted from https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwjc6t-RhvbwAhWEzKQKHT01ArYQFjAAegQIBRAD&url=https%3A%2F%2Fstackoverflow.com%2Fquestions%2F55694881%2Fhow-to-validate-textbox-value-while-user-enters-and-display-error-message&usg=AOvVaw26yHUNTBHMniLGYW4ZVo3G
        // Zain Arshad 
        // 2019 April 15 
    }
}
