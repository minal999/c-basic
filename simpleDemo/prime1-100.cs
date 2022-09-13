using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class prime1_100
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers between 1-100 are: ");
            for (int i = 1; i < 101; i++)
            {
                int flag = 0;

                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
