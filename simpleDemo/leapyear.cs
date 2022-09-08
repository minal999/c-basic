using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class leapyear
    {
        static void Main(string[] args)
        {

            //leap year or not
            Console.WriteLine($"enter the year ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine($"given year is leap year");
            }
            else
            {
                Console.WriteLine($"given year is not a leap year");
            }
        }
    }
    }
