using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assignment04
{
    class Program
    {
        /// <summary>
        /// Class imports SQL Database of customers.  First by using CustomerRepository to import a Distinct List of Provinces.  
        /// Generating a numbered menu based on how many distinct provinces are in the SQL database.  Then allowing the user
        /// to pick a number which will query the SQL database and return a list of companies based on the users selection.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                CustomerCollection province = CustomerRepository.GetProvinces();

                if (province != null && province.Count() > 0)
                {
                    ConsolePrinter.PrintProvinces(province);
                    int userChoice = Convert.ToInt32(Console.ReadLine());

                    if (userChoice <= province.Count)
                    {
                        Console.WriteLine("{0} {1}\n", "Company listing for ", province[userChoice - 1].Province);
                        string provinceChoice = province[userChoice - 1].Province;
                        CustomerRepository.GetInfoByProvince(provinceChoice);
                    }
                    else if (userChoice == province.Count + 1)
                    {
                        Console.WriteLine("Company listing for all Companies.\n");
                        printEverything();
                    }
                    else
                    {
                        Console.WriteLine("Nothing to print");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Data Access Error\n\n{0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Processing Error\n\n{0}", ex.Message);
            }

            ///<summary>
            ///Query Customer Database via CustomerRepository Class and 
            ///uses ConsolePrinterClass to print out a list of all customers
            ///</summary>
            void printEverything()
            {
                try
                {
                    CustomerCollection customer = CustomerRepository.GetCustomers();

                    if (customer != null && customer.Count() > 0)
                    {
                        ConsolePrinter.PrintCustomers(customer);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to print");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Data Access Error\n\n{0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Processing Error\n\n{0}", ex.Message);
                }
            }
        }
    }
}
