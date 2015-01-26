using System;
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
namespace CirclePerimeterandArea
{
    class Program
    {
        static void Main()
        {
            double PI = 3.14;
            Console.WriteLine("Enter circle's radius: \n");
            string r = Console.ReadLine();
            double radius = double.Parse(r);
            double perimeter; 
            perimeter = 2 * PI * radius;
            double area;
            area = PI * radius * radius;
            Console.WriteLine("The perimeter of circle is: {0:F2} \n",perimeter);
            Console.WriteLine("The area of circle is: {0:F2} \n", area);
        }
    }
}
