using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = new string('-', 28);

            Console.WriteLine("Contact Information");
            Console.WriteLine(line);

            //Prompt and collect data
            Console.Write("Firstname:     ");
            string firstName = Console.ReadLine();
            Console.Write("Lastname:      ");
            string lastName = Console.ReadLine();
            Console.Write("Address:       ");
            string address = Console.ReadLine();
            Console.Write("City:          ");
            string city = Console.ReadLine();
            Console.Write("Province:      ");
            string province = Console.ReadLine();
            Console.Write("Postal Code:   ");
            string postalCode = Console.ReadLine();

            //Populate the objects 
            Contact contact1 = new Contact();
                contact1.FirstName = firstName;
                contact1.LastName = lastName;
                contact1.Address = address;
                contact1.City = city;
                contact1.Province = province;
                contact1.PostalCode = postalCode;
            Contact contact2 = new Contact(firstName, lastName, address, city, province, postalCode);
            Contact contact3 = new Contact { FirstName = firstName, LastName = lastName, Address = address, City = city, Province = province, PostalCode = postalCode };

            //Add objects to Array
            Contact[] contacts = { contact1, contact2, contact3 };

            //Output content of the objects using ConsolePrinter class
            Console.WriteLine("\n");
            Console.WriteLine("Contacts");
            Console.WriteLine(line);
            ConsolePrinter.PrintPeople(contacts);

            Console.WriteLine("\n");
        }
    }
}
