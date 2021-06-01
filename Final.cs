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
    public partial class Final : Form
    {
        NormalClass NormalClass = new NormalClass();
    
        public Final()
        {
            InitializeComponent();
        }
        private void Final_Load(object sender, EventArgs e)
        {
            //HOME LOAN REPAYMENT:

            //monthly home loan

            //displaying home loan 
            double monthlyhomeloan = Globals.homelonerepayment;
            label10.Text = monthlyhomeloan.ToString();

            //error message for home loan 
            if (monthlyhomeloan > (Globals.homelonerepayment))
            {
                label16.Text ="ERROR! Home loan is unlikely!";
            }

            //displaying renting amount 
            Clipboard.SetText(Globals.renting.ToString());
            label13.Text = Clipboard.GetText();

            //displaying total expense 
            double expenses = Globals.ExpenseMade;
            label5.Text = expenses.ToString();

            //displaying deductions
            if (label13.Text.Equals(""))
            {
                double deduction = Globals.AvailableAmount - (Globals.homelonerepayment) - (Globals.ExpenseMade);
                label9.Text = deduction.ToString();
            }
            else
            {
                double renting = Globals.AvailableAmount - (Globals.renting + Globals.ExpenseMade);
                label9.Text = renting.ToString();
            }

            //VEHICLE REPAYMENT:
            double vehicle = Globals.vehicle;
            label11.Text = vehicle.ToString();

            //displaying model
            Clipboard.SetText(Globals.model.ToString());
            label15.Text = Clipboard.GetText();

            //vehicle error message
            if ((Globals.ExpenseMade + Globals.homelonerepayment) > 75 % Globals.AvailableAmount)
            {
                label17.Text ="STOP! Your expense are exceeding your income!!";
            }

            //showing the expense in the listbox in descending order 
            Expense.Items.Clear();

            for (int i = 0; i < Globals.array.Count; i++)
            {
                Expense.Items.Add(Globals.array[i].ToString());

                //arraning expense in descending order in listbox
                var sortedItems = Globals.array.OrderByDescending(t => t);
                Expense.Items.Clear();
                foreach (var item in sortedItems)
                {
                    Expense.Items.Add(item);
                }
            }
        }
        //restart button
        private void button1_Click(object sender, EventArgs e)
        {
            //hides the form 
            Final form = new Final();
            this.Hide();

            //shows the first form again
            First first = new First();
            first.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
