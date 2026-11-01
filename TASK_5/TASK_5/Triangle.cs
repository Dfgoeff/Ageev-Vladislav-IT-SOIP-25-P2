using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Triangle
    {
        Point A;
        Point B;
        Point C;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string Length(string side = "all")
        {
            Vector2D AB = new Vector2D(B.X - A.X,B.Y - A.Y);
            Vector2D BC = new Vector2D(C.X - B.X,C.Y - B.Y);
            Vector2D AC = new Vector2D(A.X - C.X,A.Y - C.Y);

            double ab = AB.Length();
            double bc = BC.Length();
            double ac = AC.Length();

            switch(side)
            {
                case "all":
                    return $"AB: {ab:F2} BC: {bc:F2} CA: {ac:F2}";
                case "AB":
                    return $"{ab:F2}";
                case "BC":
                    return $"{bc:F2}";
                case "AC":
                    return $"{ac:F2}";
                default:
                    throw new ArgumentException("Invalid input for finding length of trianlge side");
            }
        }
        public double Perimeter()
        {
            return ( double.Parse(Length("AB")) + double.Parse(Length("BC")) + double.Parse(Length("AC")) ) ;
        }
        public double Area()
        {
            double p = this.Perimeter() / 2;
            return Math.Sqrt(p * (p - double.Parse(Length("AB"))) * (p - double.Parse(Length("BC"))) * (p - double.Parse(Length("AC"))) );
        }
    }
}
