using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class NormalClass : InheritanceClass
    {
        public override double calcvehicleRepayment(string model,double price, double deposit, double interestrate, double insurance)
        {
            //method for calculating vehicle payment 
            double vehicle = price - deposit;
            double vehicle2 = (vehicle * interestrate * 5) / 100 + (insurance + Globals.homelonerepayment);
            return vehicle2;
        }

         public override double calcExpenses(double groceries, double travelcost, 
             double waterandlights, double cellphone, double other)
        {
            //calculating expense made
            return groceries + travelcost + waterandlights + cellphone + other;

        }

        public override double calcHomeRepayment(double rentingamount, double grossincome, double totalValue, double totalDeposit, double interest, double months)
        {
            //calculating homeloan repayment
            Globals.AvailableAmount = grossincome;
            double simpleint = Globals.AvailableAmount - totalDeposit;
            double interests2 = (simpleint * interest * months) / 100;
            Convert.ToString(interests2);
            return interests2;

            Globals.homelonerepayment = interests2;
        }
    }
}
