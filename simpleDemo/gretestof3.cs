using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class gretestof3
    {
        static void Main(string[] args)
        {
            //check the greatest of  numbers with nested if
            int n1 = 20, n2 = 78, n3 = 145;

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine($"{n1} is greast number");
                }
                else
                {
                    Console.WriteLine($"{n3} is greast numer");
                }
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine($"{n2} is greast numer");
                }
                else
                {
                    Console.WriteLine($"{n3} is greast numer");
                }
            }


        }
    }
}