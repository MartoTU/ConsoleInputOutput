using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Въведете стойност за коефициента а: ");
            string firstKoef = Console.ReadLine();
            int a = int.Parse(firstKoef);
            Console.WriteLine("Въведете стойност за коефициента b: ");
            string seconKoef = Console.ReadLine();
            int b = int.Parse(seconKoef);
            Console.WriteLine("Въведете стойност за коефициента с: ");
            string thirdKoef = Console.ReadLine();
            int c = int.Parse(thirdKoef);
            double diskriminant = (b * b) - (4 * a * c);
            Console.WriteLine("Стойността на дескриминантата е: {0}", diskriminant);
            double diskriminSqrt = Math.Sqrt(diskriminant);
            double firstX = (-b + diskriminSqrt)/(2*a);
            Console.WriteLine("Стойността на първия корен е: {0}", firstX);
            double secondX = (-b - diskriminSqrt) / (2 * a);
            Console.WriteLine("Стойността на втория корен е : {0}", secondX);
        }
    }
}
