using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class armstrong
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, tempvariable;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            tempvariable = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (tempvariable == sum)
                Console.WriteLine("The Given number is an Armstrong Number.");
            else
                Console.WriteLine("The given number is not an Armstrong Number.");
        }
    }
        }
