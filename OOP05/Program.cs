using OOP05._ٍSealed;
using OOP05.Abstraction;
using OOP05.Partial;
using OOP05.Static;

namespace OOP05
{
     class Program
    {
        public static void Draw2D(IDraw2D shape)
        {

        }
        public static void PrintShapeInfo(Shape shape)
        {
            Console.WriteLine($"Perimeter:{shape.perimeter}");

            Console.WriteLine($"Area:{shape.CalcArea}");
        }
       public static void CalcPayment(PaymentProcess process)
        {
            process.ProcessPayment(100);
        }
        static void Main(string[] args)
        {
            #region Abstract Class
            ////Shape shape = new Shape();//not correct because I have Methods not fully implemented 
            ////Shape.CalcArea();
            //Rectangle rectangle = new Rectangle() {Dim01=10 ,Dim02=20 };
            //decimal Area=rectangle.CalcArea();
            //decimal peri = rectangle.perimeter;
            //Console.WriteLine(Area); 
            //Console.WriteLine(peri);

            //Square square = new Square(10);
            //decimal squareArea = rectangle.CalcArea();
            //decimal squarePeri = rectangle.perimeter;
            //Console.WriteLine(squareArea);
            //Console.WriteLine(squarePeri);
            //Circle circle = new Circle(5);
            //Console.WriteLine(circle.CalcArea());
            //Console.WriteLine(circle.perimeter);



            #endregion
            #region Static Class 
            //Utility u01=new Utility(1,2);
            //Utility u02 = new Utility(2, 5);

            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CmToInch(254));
            //the result not depend on Data of object so its must be static
            //Console.WriteLine(u01.CalcCircleArea(Redius: 10));
            //Console.WriteLine(u01.CalcCircleArea(Redius: 10));
            // Console.WriteLine(Utility.CalcCircleArea(Redius: 10));

            #endregion
            #region Sealed
            //ImuttableString imuttableString = new ImuttableString("Nada");
            //imuttableString=new ImuttableString("Nour");
            //Console.WriteLine(imuttableString.Value);
            #endregion
            #region Partial [Class,instruct,interface  ,Method ,property]
            //Employee employee = new Employee() {Id=10,Name="Nada",Address="nl",Age=20 };
            #endregion

        }
    }
}
