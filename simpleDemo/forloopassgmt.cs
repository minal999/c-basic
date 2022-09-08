using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class forloopassgmt
    {
        static void Main(string[] args)
        {

            //print 1-50 numbers

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }

            //print even numbers from 1-20

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //print odd numbers from 100-50

            for (int i = 100; i >= 50; i--)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }


            //accept number from user and print arithmatic table


            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            //print numbers from 1-100 which are divisible by 5

            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
