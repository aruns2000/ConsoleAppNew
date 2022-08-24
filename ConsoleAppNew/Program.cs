using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class SwappingTwoNumbers
    {
        public static void Main()
        {

            Console.WriteLine("Enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before Swapping {a},{b}");
            swap(ref a, ref b);
            Console.WriteLine($"After Swapping {a},{b}");
        }
        public static int swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return temp;
        }
    }
}
