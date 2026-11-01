using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Vector2D
    {
        double X;
        double Y;

        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }
        public Vector2D(double x, double y)
        {
            X = x; 
            Y = y;
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public Vector2D Normalize()
        {
            if (X == 0 && Y == 0)
            {
                throw new ArgumentException("Cannot normalize this Vector");
            }

            return new Vector2D(X / this.Length(), Y / this.Length() );
        }
        public double Dot(Vector2D v)
        {
            return ((X * v.X) + (Y * v.Y));
        }
    }
}
