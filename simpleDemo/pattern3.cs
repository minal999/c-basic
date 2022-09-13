using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class pattern3
    {
        static void Main(string[] args)
        {
            //A
            //AB
            //ABC
            //ABCD
            //ABCDE

            for (char i = 'A'; i <= 'E'; i++)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }

        }
    }
}
