using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstraction
{
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        protected Shape(decimal Dim01,decimal Dim02)
        {
            this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }
        public abstract decimal perimeter { get; }
        public abstract  decimal CalcArea();


    }
    abstract class  RectBase : Shape
    {
        protected RectBase(decimal Dim01, decimal Dim02) : base(Dim01, Dim02)
        {
        }

        public override decimal CalcArea()
        {
            return (Dim01 * Dim02);
        }
    }
    class Square : RectBase
    {
        public override decimal perimeter { get { return Dim02*4;   } }
        
       public  Square(decimal D):base(D,D)
        {
          
        }
       
    }
    class Rectangle : RectBase
    {
        public Rectangle(decimal Dim01,decimal Dim02):base(Dim01,Dim02)
        {
            
        }
        public override decimal perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

    }
    class Circle : Shape,IDraw2D,IDraw3D
    {
        public Circle(decimal Dim01) : base(Dim01, Dim01)
        {

        }
        public override decimal perimeter { get { return (3.14M * 2 * Dim01); } }

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim01;
        }

        void IDraw2D.Draw()
        {
            throw new NotImplementedException();
        }

        void IDraw3D.Draw()
        {
            throw new NotImplementedException();
        }
    }
    #region Virtual property
    //class Parent
    //{
    //    private int salary;
    //    public virtual int Salary { get { return salary; } set { salary = value < 5000 ? 5000 : value; }}
    //    public virtual void print()
    //    {
    //        Console.WriteLine("I am Parent");
    //    }
    //}
    //class Child:Parent 
    //{
    //    public override int Salary { 
    //        get { return  base.Salary; } 
    //        set { base.Salary = value+2000; } 
    //    }
    //    public override void print()
    //    {
    //        Console.WriteLine("I am Child");
    //    }
    //}
    #endregion
    interface IDraw2D
    {
        void Draw();
    }
    interface IDraw3D
    {
        void Draw();
    }


}
