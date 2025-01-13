using Assignment.FirstProject;
using Assignment.SecondProject;
using Assignment.ThirdProject;

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
            //double x=0, y=0, z=0;
            //bool f = false;

            //Console.WriteLine($"Enter coordinates for (X, Y, Z):");
            //do
            //{
            //    Console.Write("X: ");
            //    f = double.TryParse(Console.ReadLine(), out x);
            //} while (!f);
            //f = false;
            //do
            //{
            //    Console.Write("Y: ");
            //    f = double.TryParse(Console.ReadLine(), out y);
            //} while (!f);

            //f = false;
            //do
            //{
            //    Console.Write("Z: ");
            //    f = double.TryParse(Console.ReadLine(), out z);
            //} while (!f);
            //Point3D point3D= new Point3D(x, y, z);
            //Console.WriteLine(point3D.ToString());
            #endregion
            #region Q4:(P1==P2)
            //not work i need to override on == in class Point 3D
            //Point3D P1=new Point3D(1,1,1);
            //Point3D P2=new Point3D(2,1,1);
            //if (P1 == P2)
            //{
            //    Console.WriteLine("Points are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Points not are Equal");
            //}
            #endregion
            #region Q5:Define an array of points and sort this array based on X & Y coordinates.
            //Point3D[] Points =
            //{
            //    new Point3D(1,2,3),
            //    new Point3D(1,1,6),
            //    new Point3D(3,5,3),
            //    new Point3D(-1,0,0)
            //};
            //Array.Sort(Points);
            //foreach (Point3D p in Points)
            //{
            //    Console.WriteLine(p.ToString());
            //}

            #endregion
            #region Q6:Implement ICloneable interface to be able to clone the object.
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(1, 1, 6);
            ////remember Clone return object
            //P1=(Point3D)P2.Clone();
            //Console.WriteLine(P1.ToString());


            #endregion

            #endregion
            #region Second Project
            //int add=Maths.Add(1, 2);
            //Console.WriteLine($"Add:{add}");
            //int sub=Maths.Subtract(1, 2);
            //Console.WriteLine($"Sub:{sub}");
            //int Mul=Maths.Multiple(1, 2);
            //Console.WriteLine($"Mul:{Mul}");
            //int Div=Maths.divide(2,1);
            //Console.WriteLine($"Div:{Div}");
            #endregion
            #region Third Project
            //Console.WriteLine("Enter your user type (Regular, Premium, Guest):");
            //string userType = Console.ReadLine();

            //User user;

            //switch (userType.ToLower())
            //{
            //    case "regular":
            //        Console.WriteLine("Enter your name:");
            //        string regularName = Console.ReadLine();
            //        user = new RegularUser(regularName);
            //        break;

            //    case "premium":
            //        Console.WriteLine("Enter your name:");
            //        string premiumName = Console.ReadLine();
            //        user = new PremiumUser(premiumName);
            //        break;

            //    case "guest":
            //        Console.WriteLine("Enter your name:");
            //        string guestName = Console.ReadLine();
            //        user = new GuestUser(guestName);
            //        break;

            //    default:
            //        Console.WriteLine("Invalid user type. Defaulting to Guest.");
            //        user = new GuestUser("Guest");
            //        break;
            //}
            //bool f = false;
            //decimal price;
            //do
            //{
            //    Console.WriteLine("Enter product price:");
            //    f = decimal.TryParse(Console.ReadLine(), out price);
            //} while (!f);
            //f = false;
            //int quantity;
            //do
            //{
            //    Console.WriteLine("Enter product quantity:");
            //    f = int.TryParse(Console.ReadLine(), out quantity);
            //} while (!f);

            //Discount? discount = user.GetDiscount();

            //double discountAmount = discount?.CalculateDiscount(price, quantity) ?? 0;
            //decimal finalPrice = (price * quantity) - (decimal)discountAmount;

            //Console.WriteLine($"User: {user.Name}");
            //Console.WriteLine($"Discount Type: {discount?.Name ?? "No Discount"}");
            //Console.WriteLine($"Total Discount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}");

            #endregion
        }
    }
}

