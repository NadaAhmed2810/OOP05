using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ThirdProject
{
    internal class FlatDiscount : Discount
    {
        private double Amount;
        public double Percentage
        {
            get
            {
                return Amount;
            }
            set
            {
                Amount = value > 0 ? value : 0;
            }
        }
        public FlatDiscount(double Amount)
        {
            this.Name = "FlatDiscount";
            this.Amount = Amount;
        }
        public override double CalculateDiscount(decimal price, int quantity)
        {
            return Amount * Math.Min(quantity, 1);
        }
    }
}
