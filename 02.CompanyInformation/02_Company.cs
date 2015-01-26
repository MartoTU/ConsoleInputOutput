using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.
namespace CompanyInformation
{
    class Company
    {
        static void Main()
        {
            Console.WriteLine("Enter company name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter company address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter company phone number: ");
            string pn = Console.ReadLine();
            double phoneNumber = double.Parse(pn);
            Console.WriteLine("Enter Fax Number: ");
            string fn = Console.ReadLine();
            double faxNumber = double.Parse(fn);
            Console.WriteLine("Enter web site: ");
            string Site = Console.ReadLine();
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string a = Console.ReadLine();
            double age = double.Parse(a);
            Console.WriteLine("Enter your phone: ");
            string p = Console.ReadLine();
            double phone = double.Parse(p);


        }
    }
}
