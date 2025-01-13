using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ThirdProject
{
    internal class RegularUser : User
    {
        public RegularUser(string? name) : base(name)
        {
        }

        public override Discount? GetDiscount()
        {
           return new PercentageDiscount(5);
        }
    }
}
