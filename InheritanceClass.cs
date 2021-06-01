using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public abstract class InheritanceClass
    {
        //expense method
        public abstract double calcExpenses(double groceries, double travelcost, double waterandlights, double cellphone, double other);
        //homerepayment method
        public abstract double calcHomeRepayment(double rentingamount, double grossincome, double totalValue, double totalDeposit, double interest, double months);
        //vehicle method
        public abstract double calcvehicleRepayment(string model, double price, double deposit, double interestrate, double insurance);
    }
}
