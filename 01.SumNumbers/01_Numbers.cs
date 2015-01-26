using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write a program that reads 3 real numbers from the console and prints their sum.
namespace SumNumbers
{
    class Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter fist number: ");
            string a = Console.ReadLine();
            double firstNumber = double.Parse(a);
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();
            double secondNumber = double.Parse(b);
            Console.WriteLine("Enter third number");
            string c= Console.ReadLine();
            double thirdNumber = double.Parse(c);
            Console.WriteLine("The sum is: {0}", firstNumber+secondNumber+thirdNumber);
                


        }
    }
}
