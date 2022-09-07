using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class ConditionalStmt
    {
        static void Main(string[] args)
        {/*
            //even or odd number
            Console.WriteLine($"enter the number ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if(a%2==0)
            {
                Console.WriteLine($"the given number is even number");

            }
            else
            {
                Console.WriteLine($"The given number is odd number");
            }
            
            //leap year or not
            Console.WriteLine($"enter the year ");
            int year = ConvertToInt32(Console.ReadLine());
            if (year%4==0)
            {
                Console.WriteLine($"given year is leap year");
            }
            else
            {
                Console.WriteLine($"given year is not a leap year");
            }*/

            //check given character is vowel or consonant

            //Console.WriteLine($"Enter the character ");
            //char c = Convert.ToChar(Console.ReadLine());
            //if(c=='a'|| c == 'e' || c == 'i' || c == 'o' || c == 'u' )
            //{
            //    Console.WriteLine($"The given character is vowel");
            //}
            //else
            //{
            //    Console.WriteLine($"The given character is consonant");
            //}



            //check the greatest of  numbers with nested if


            //ask for two numbers and perform operations
            //1.add 2.sub 3.multi 4.div

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
                    Console.WriteLine($"Addition of numbers is {num1+num2}");
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