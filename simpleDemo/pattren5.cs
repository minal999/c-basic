using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class pattren5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= (x - i); j++)
                    Console.Write(" ");

                for (int k = 1; k < i * 2; k++)
                    Console.Write("*");
                Console.WriteLine();
            }
            
        }
    }
}
