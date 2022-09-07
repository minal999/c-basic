using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age= 26;
            char gender = 'F';
            string name = "My name is sanjana.";
            float salary1 = 8745.75f;
            Double salary2 = 85755.55;
            Console.WriteLine(name);
            Console.WriteLine("The age of sanjana is "+age+ " Her gender of sanjana is " + gender);
            Console.WriteLine("Her salary in float is {0}", salary1);
            Console.WriteLine($"Her salary in double is {salary2}");

           
        }
    }
}
