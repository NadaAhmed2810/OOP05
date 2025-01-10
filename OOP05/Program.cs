using OOP05.Abstraction;

namespace OOP05
{
    internal class Program
    {
        public static void Draw2D(IDraw2D shape)
        {

        }
        public static void PrintShapeInfo(Shape shape)
        {
            Console.WriteLine($"Perimeter:{shape.perimeter}");

            Console.WriteLine($"Area:{shape.CalcArea}");
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
        }
    }
}
