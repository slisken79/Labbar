using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    struct Point
    {
        internal int X;
        internal int Y;

        public static implicit operator Point3D(Point point)
        {
            return new Point3D() { X = point.X, Y = point.Y, Z = 0 };
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point() { X = p1.X + p2.X , Y = p1.Y + p2.Y };
        }
        public static Point operator +(Point p1, Point3D p2)
        {
            return new Point() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }
    }
}
