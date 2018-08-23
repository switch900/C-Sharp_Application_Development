using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assignment04
{
    class ConsolePrinter
    {
        /// <summary>
        /// Read value for CreditHold as bool and change it to a String where false equals Y and true equals N.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>creditHold as string</returns>
        public static string MakeCreditHoldShort(Customer customer)
        {
            string creditHold = null;
            if (customer.CreditHold==false)
            {
                creditHold = "N";
            }
            else if (customer.CreditHold == true)
            {
                creditHold = "Y";
            }
            else
            {
                creditHold = " ";
            }
            return creditHold;
        }

        /// <summary>
        /// Formats Customer information and prints to console
        /// </summary>
        /// <param name="customerIndex"></param>
        public static void PrintCustomers(CustomerCollection customerIndex)
        {
            Console.WriteLine($"{"CompanyName",-37}{"City",-17}{"Prov",-5}{"Postal",-8}{"Hold",-4}");
            
            Console.WriteLine(new string('-', 71));

            foreach (Customer customer in customerIndex)
            {
                Console.WriteLine("{0,-37}{1,-17}{2,-5}{3,-8} {4,-4}", customer.CompanyName, customer.City, customer.Province, customer.PostalCode, MakeCreditHoldShort(customer));
            }
        }

        /// <summary>
        /// Formats province information and prints to console for menu with numbers.
        /// </summary>
        /// <param name="provinceIndex"></param>
        public static void PrintProvinces(CustomerCollection provinceIndex)
        {
            Console.WriteLine("Select province filter:");
            int menuNumber = 1;
            foreach (Customer customer in provinceIndex)
            {
                Console.WriteLine("         {0}: {1}", menuNumber, customer.Province);
                menuNumber++;
            }
            Console.WriteLine("         {0}: {1}", menuNumber, "All");
        }
    }
}