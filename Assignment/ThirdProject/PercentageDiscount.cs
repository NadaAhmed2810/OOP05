using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ThirdProject
{
    internal class PercentageDiscount : Discount
    {
        private double percentage;
        public double Percentage {
            get
            {
                return percentage;
            }
            set 
            {
                percentage =value>0?value:0;
            } 
        }
        public PercentageDiscount (double percentage)
        {
            this.Name = "PercentageDiscount";
            this.percentage = percentage;
        }
        public override double CalculateDiscount(decimal price, int quantity)
        {
            return ((double)price) * quantity * Percentage / 100;
        }
    }
}
