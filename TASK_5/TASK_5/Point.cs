using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2));
        }
    }
}
