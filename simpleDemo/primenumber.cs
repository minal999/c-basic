using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class primenumber
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i <=(num/2); i++)
            {
                if(num% i== 0)
                {
                    Console.WriteLine($"{num} is a not prime number");
                    flag = 1;
                    break;
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine($"{num} is a prime number");
            }
        }
        }
}
