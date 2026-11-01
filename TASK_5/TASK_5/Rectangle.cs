using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Rectangle
    {
        public int Width;
        public int Height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Area()
        {
            return (Width * Height);
        }
        public int Perimeter()
        {
            return (Height + Width) * 2;
        }
    }
}
