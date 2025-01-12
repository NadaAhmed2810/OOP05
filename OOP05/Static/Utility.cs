using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Static
{
    internal class Utility
    {
        //object member
        //public int X { get; set; }
        //public int Y { get; set; }
        ////Class Member Atrribute 
        //private static readonly double pi;
        //public static double PI { get { return pi; }  }
        //static Utility()
        //{
        //    //pi = 3.14;
        //}
        private const double pi = 3.14;

        //object member constructor :Non static Constructor
        //public Utility(int X, int Y)
        //{
        //    this.X = X;
        //    this.Y = Y;
        //    // pi = 3.14;//not the right 
        //}
      
        //object member method:Static Method [Class member]
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double CalcCircleArea(double Redius)
        {
            return pi* Redius*Redius;
        }
    }
}
