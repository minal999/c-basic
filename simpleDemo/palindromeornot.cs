using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class palindromeornot
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, tempvariable;
            Console.Write("Enter the Number: ");
            num = int.Parse(Console.ReadLine());
            tempvariable = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (tempvariable == sum)
                Console.WriteLine("The given Number is Palindrome.");
            else
                Console.WriteLine("The given Number is not Palindrome");
        }
    }
}