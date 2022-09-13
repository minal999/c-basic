using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class MultilicationWithoutOperator
    {
        static void Main(string[] args)
        {
            //accept two numbers and find multiplication without * operator
            int num1, num2,result = 0;
            Console.Write("Enter the first Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            num2 = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num2; i++)
            {
                result=result + num1;
            }
            Console.WriteLine($"prouct of {num1} and {num2} is {result}");
        }
    }
}
