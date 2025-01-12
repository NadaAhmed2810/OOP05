using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.FirstProject
{
    internal class Point3D
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
        #endregion



    }
}
