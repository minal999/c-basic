using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleDemo
{
    internal class PerimeterOfRectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of length : ");
            double Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of width : ");
            double Width = Convert.ToDouble(Console.ReadLine());
            double Perimeter = 2 * (Length + Width);
            Console.WriteLine("Perimeter of Rectangle is: " + Perimeter);
        }
        }
}
