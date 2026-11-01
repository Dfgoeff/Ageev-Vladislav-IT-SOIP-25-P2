using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_5
{
    internal struct Color
    {
        int R;
        int G;
        int B;
        
        public Color(int r, int g, int b)
        {
            if (!(r >= 0 && r <= 256 && g >= 0 && g <= 256 && b >= 0 && b <= 256))
            {
                throw new ArgumentException("Invalid input for creation a RGB color");
            }
            else
            {
                R = r; 
                G = g; 
                B = b;    
            }
        }

        public override string ToString()
        {
            return $"R: {R} G: {G} B: {B}";
        }
        public string ToHex()
        {
            string fisrt = R.ToString("X2");
            string second = G.ToString("X2");
            string third = B.ToString("X2");

            return "#" + fisrt + second + third;
        }
    }
    
}
