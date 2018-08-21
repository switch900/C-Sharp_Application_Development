using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    class ConsolePrinter
    {
        //iterate through Array and output results in Canada Postal Standard.
        public static void PrintPeople(Contact[] people)
        {
            foreach (Contact person in people)
            {             
                    Console.WriteLine("{0, 6} {1, 6}"
                                            , person.FirstName
                                            , person.LastName);
                    Console.WriteLine("{0,6}", person.Address);
                    Console.WriteLine("{0, 6} {1, 0}     {2,6}"
                                            , person.City
                                            , person.Province
                                            , person.PostalCode);
                Console.WriteLine("\n");
            }         
        }
    }
}

