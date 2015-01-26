using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
namespace SumofnNumbers
{
    class NNumbers
    {
        static void Main()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("number{0}=", i);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
