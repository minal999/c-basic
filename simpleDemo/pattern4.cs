﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class pattern4
    {
        static void Main(string[] args)
        {
            //12345
            //1234
            //123
            //12
            //1

            for (int i = 5;i>=1;i--)
            {
                for(int j = 1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
