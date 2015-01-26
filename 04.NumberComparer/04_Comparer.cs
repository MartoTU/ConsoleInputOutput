using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.
namespace NumberComparer
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter fist number: ");
            string a = Console.ReadLine();
            decimal firstNumber = decimal.Parse(a);
            Console.WriteLine("Enter second number: ");
            string b = Console.ReadLine();
            decimal secondNumber = decimal.Parse(b);
            Console.WriteLine("The grater number is: ");
            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }
    }
}
