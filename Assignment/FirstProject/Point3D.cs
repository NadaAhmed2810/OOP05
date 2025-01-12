using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.FirstProject
{
    internal class Point3D:IComparable<Point3D>,ICloneable
    {
        #region Property
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        #endregion

        #region Constructors
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(double x):this(x,x,x)
        {
           
        }

        public Point3D()
        {
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(Point3D? other)
        {
            int x = 0;
            x += this.X.CompareTo(other?.X);
            x += (this.Y.CompareTo(other?.Y));
            return x;

        }

        public object Clone()
        {
            return new Point3D()
            {
               X=X,
               Y=Y,
               Z=Z
            };
        }

        public static bool  operator == (Point3D left, Point3D right)
        {
            return (left.X==right.X)&&(left.Y==right.Y)&&(left.Z==right.Z);
        }
        public static  bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }
        #endregion



    }
}
