using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ThirdProject
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            this.Name = "BuyOneGetOneDiscount";
  
        }
        public override double CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return (double)(price / 2) * (quantity / 2);

            }
            return 0;
        }
    }
}
