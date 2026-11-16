using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CASE1();
            CASE2();
        }
        unsafe static void CASE1()
        {
            Console.WriteLine("Case 1");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            fixed(int* ptr = array)
            {
                Console.WriteLine($"Массив до: {string.Join(" ", array)}");

                for (int i = 0; i < array.Length; i++)
                {
                    *(ptr + i) += 10;
                }

                Console.WriteLine($"Массив после: {string.Join(" ",array)}");

            }
        }

        unsafe static void CASE2()
        {
            int x = 50;
            int* ptr = &x;
            Console.WriteLine($"Значение х до: {x}");
            int** doublePtr = &ptr;
            **doublePtr = 999;
            Console.WriteLine($"Значение х после: {x}");
            Console.WriteLine($"Адресс х: {(ulong)ptr:x}");
            Console.WriteLine($"Адресс ptr: {(ulong)doublePtr:x}");
        }
    }
}
