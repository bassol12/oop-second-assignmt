using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.project_2
{
    internal class maths
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine($"Add: {a + b}");
        }
        public static void multpily(int a, int b)
        {
            Console.WriteLine($"myltiply: {a * b}");
        }
        public static void subtract(int a, int b)
        {
            Console.WriteLine($"subtract: {a - b}");
        }
        public static void divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"divide: {a / b}");
            }
            else
            {
                Console.WriteLine("b cannot be equal zero");
            }
        }
    }
}
