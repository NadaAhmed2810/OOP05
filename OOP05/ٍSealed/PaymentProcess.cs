using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05._ٍSealed
{
    internal sealed class PaymentProcess
    {
        public void ProcessPayment(decimal amount) 
        {
            Console.WriteLine($"Amount:{amount}");
        }
    }
    //can`t inherit 
    //class MyPaymentProcess : PaymentProcess
    //{
    //    public new void  ProcessPayment(decimal amount) 
    //    {
    //        Console.WriteLine($"Amount:{amount+20}");
    //    }
    //}
}
