using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class fibonacci
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 1;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"fibonacci series of {num}");
            for(int i = 1; i <= num; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine($"{a}  ");
            }
        }
        }
}
