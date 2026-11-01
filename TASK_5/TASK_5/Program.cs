using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            third();
        }

        static void first()
        {
            Point firstPoint = new Point(10, 42);
            Point secondPoint = new Point(22, 19);
            Rectangle rectangle = new Rectangle(10,15);
            Book bleach = new Book("Bleach","Tayto Kubo",2001);
            Console.WriteLine($"FIRST TASK\n\nPOINTS\n cords 1: {firstPoint.ToString()}\n cords 2: {secondPoint.ToString()}\n distance: {firstPoint.Distance(secondPoint)}\n");
            Console.WriteLine($"RECTANGLE\n Area:{rectangle.Area()}\n Perimeter{rectangle.Perimeter()}\n");
            Console.WriteLine($"BOOK\n result: {bleach.ToString()}");

        }

        static void second()
        {
            ComplexNumber firstNum = new ComplexNumber(4.0, 0.001);
            ComplexNumber secondNum = new ComplexNumber(2.0, 3.0);
            Color color = new Color(1, 32, 57);
            SimpleDate birthday = new SimpleDate(15, 2009, 8);

            Console.WriteLine("SECOND TASK\n\n");
            Console.WriteLine($"COMLPEX NUMBER\n number:\n first:{firstNum.ToString()}\n second:{secondNum.ToString()}\n Sum: {firstNum.Sum(secondNum)}\n Subtract: {firstNum.Subtract(secondNum)}\n Multiply: {firstNum.Multiply(secondNum)}\n");
            Console.WriteLine($"COLOR\n RGB: {color}\n HEX: {color.ToHex()}\n");
            Console.WriteLine($"SIMPLE DATE\n date:{birthday}\n is leap: {birthday.IsLeapYear()}");
        }
        static void third()
        {
            Vector2D victor = new Vector2D(15,20);
            Vector2D vector = new Vector2D(21, 54);

            Money m1 = new Money(19, 49);
            Money m2 = new Money(49, 99);

            Point A = new Point(10, 20);
            Point B = new Point(16, 20);
            Point C = new Point(13, 24);

            Triangle ABC = new Triangle(A, B, C);

            Point3D p1 = new Point3D(10, 32, 15);
            Point3D p2 = new Point3D(4, 17, 41);
            Console.WriteLine("THIRD TRASK\n\n");
            Console.WriteLine($"VECTOR 2D\n first:{victor}\n second{vector}\n lenght(1): {victor.Length()}\n normalized(1): {victor.Normalize()}\n Dot(1): {victor.Dot(vector)}\n");
            Console.WriteLine($"MONEY\n first: {m1} \n second: {m2}\n sum: {m1.Sum(m2)}\n subtract: {m1.Subtract(m2)}\n m1<m2: {m1 < m2}\n m1>m2: {m1 > m2}\n");
            Console.WriteLine($"TRIANGLE\n length: {ABC.Length("all")}\n perimeter: {ABC.Perimeter()}\n Area: {ABC.Area()}");
            Console.WriteLine($"POINT 3D\n first: {p1}\n second: {p2} \n distance: {p1.Distance(p2)}");
        }
    }
}
