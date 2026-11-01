using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal class Point3D
    {
        int X;
        int Y;
        int Z;

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Distance(Point3D point)
        {
            return Math.Sqrt( Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2 ) + Math.Pow(Z - point.Z, 2));
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y} Z: {Z}";
        }
    }
}
