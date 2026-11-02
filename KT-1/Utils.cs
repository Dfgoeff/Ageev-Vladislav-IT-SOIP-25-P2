using System;
using System.Collections.Generic;
using System.Text;

namespace KT_1
{
    internal class Utils
    {
        public static void Swap<T>(ref T first,ref T second)
        {
            (first, second) = (second, first);
        }
    }
}
