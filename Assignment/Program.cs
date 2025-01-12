using Assignment.FirstProject;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            #region Q2:
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());
            #endregion
            #region Q3: Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            double x=0, y=0, z=0;
            bool f = false;

            Console.WriteLine($"Enter coordinates for (X, Y, Z):");
            do
            {
                Console.Write("X: ");
                f = double.TryParse(Console.ReadLine(), out x);
            } while (!f);
            f = false;
            do
            {
                Console.Write("Y: ");
                f = double.TryParse(Console.ReadLine(), out y);
            } while (!f);

            f = false;
            do
            {
                Console.Write("Z: ");
                f = double.TryParse(Console.ReadLine(), out z);
            } while (!f);
            Point3D point3D= new Point3D(x, y, z);
            Console.WriteLine(point3D.ToString());
            #endregion

            #endregion
        }
    }
}
