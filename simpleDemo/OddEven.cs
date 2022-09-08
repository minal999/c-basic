using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class OddEven
    {
        static void Main(string[] args)
        {
            //even or odd number
            Console.WriteLine($"enter the number ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"the given number is even number");

            }
            else
            {
                Console.WriteLine($"The given number is odd number");
            }
        }
    }
}
