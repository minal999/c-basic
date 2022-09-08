using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class oparators
    {
        static void Main(string[] args)
        {
            //Arithmatic operators


            Console.WriteLine("Enter two numbers ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int addition = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            double division = num1 / num2;
            int mod = num1 % num2;
            Console.WriteLine($"The addition of {num1}  and {num2} is {addition}");
            Console.WriteLine($"The subtraction of {num1}  and {num2} is {subtraction}");
            Console.WriteLine($"The multiplication of {num1}  and {num2} is {multiplication}");
            Console.WriteLine($"The division of {num1}  and {num2} is {division}");
            Console.WriteLine($"The mod of {num1}  and {num2} is {mod}");

            // unary operator

            int a = 10,b=20,c,d,e=21;
            Console.WriteLine($"{a} {--a} {--a} {a++} {a++}"); // 10 9 8 8 9
            Console.WriteLine($"{--a} {--a} {a--} {++a}"); //9 8 8 8
            c = b++ + --e;  //20+20 40
            Console.WriteLine(c);
            d = b-- - e--;  //21-20  1
            Console.WriteLine(d);

        }


    }
}
