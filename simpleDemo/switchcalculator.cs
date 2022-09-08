using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class switchcalculator
    {
        static void Main(string[] args)
        {

            //ask for two numbers and perform operations
            //1.add 2.sub 3.multi 4.div 5.mod

            Console.WriteLine($"enter the first number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"enter the second number ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("select the operation ");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Mod");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    Console.WriteLine($"Addition of numbers is {num1 + num2}");
                    break;

                case 2:
                    Console.WriteLine($"subtraction of numbers is {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of numbers is {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Division of numbers is {num1 / num2}");
                    break;
                case 5:
                    Console.WriteLine($"Mod of numbers is {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Please select proper operation");
                    break;
            }
        }
    }
}
