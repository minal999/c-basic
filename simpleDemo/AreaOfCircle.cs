using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Enter the Radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = pi * radius * radius;
            Console.WriteLine("Area of circle is: " + area);
        }
        }
}
