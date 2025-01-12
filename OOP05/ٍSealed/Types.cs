using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05._ٍSealed
{
    class Parent
    {
        public virtual int Salary { get; set; }
        public virtual void print()
        {
            Console.WriteLine("I an Base");
        }
    }
    class Child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set
            {
                base.Salary = value < 5000 ? 5000 : value;
            }
        }
        public sealed override void print()
        {
            Console.WriteLine("I an Child");

        }

    }

        //Sealed Class
        //I Can`t  inherit from it 
        sealed class GrandChild : Child
        {
                //Can`t 
                //public override int Salary
                //{
                //    get { return base.Salary; }
                //    set
                //    {
                //        base.Salary = value < 6000 ? 6000 : value;
                //    }
                //}
                public new int Salary
                {
                get { return base.Salary; }
                set
                {
                    base.Salary = value < 6000 ? 6000 : value;
                }
                }
               public new  void print()
                {
                    Console.WriteLine("I an Hamda");

                }
        }

}
    

