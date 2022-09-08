using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            //accept number from user and print factorial

            int fact = 1;
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        }
    }
}
