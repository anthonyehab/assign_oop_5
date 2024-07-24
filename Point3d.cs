using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop_5
{
    internal class Point3d : IComparable, ICloneable
    {
        private int x, y, z;

        public Point3d() : this(0, 0, 0) { }

        public Point3d(int x, int y, int z)
        {
           x = x;
            y = y;
           z = z;
        }

        public Point3d(int x, int y) : this(x, y, 0) { }

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int Z { get { return z; } set { z = value; } }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Point3d point = (Point3d)obj;
        
            return X ==point.X  &&Y == point.Y && Z == point.Z;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public object Clone()
        {
            return new Point3d(X, Y, Z);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Point3d other = obj as Point3d;
            if (other == null) throw new ArgumentException("Object is not a Point3D");

            if (X != other.X)
                return X.CompareTo(other.X);
            else if (Y != other.Y)
                return Y.CompareTo(other.Y);
            else
                return Z.CompareTo(other.Z);
        }
    }
}
