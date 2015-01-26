using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
namespace SumFiveNumbers
{
    class Program
    {
        static void Main()
        {
           Console.Write("Enter five numbers in a row with space between them: ");
           var numbers = Console.ReadLine().Split().Take(5);
           Double[] digits = numbers.Select(d => Convert.ToDouble(d)).ToArray();
           double sum = digits.Sum();

           Console.WriteLine("The sum is: " + sum);
}
}

        }
    