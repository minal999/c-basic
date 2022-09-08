using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class Vowel
    {
        static void Main(string[] args)
        {


            //check given character is vowel or consonant

            Console.WriteLine($"Enter the character ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine($"The given character is vowel");
            }
            else
            {
                Console.WriteLine($"The given character is consonant");
            }

        }
    }
    }
