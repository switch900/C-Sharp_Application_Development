using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign01
{
    class Program
    {
        const int HIGHEST_NUMBER = 20;
        const int NUMBER_TO_ADD = 2;

        static void Main(string[] args)
        {
            int number = 0;
            int sumNumber = 0;
            int sumSquare = 0;
            int sumCube = 0;
            string line = new string('-', 28);

            Console.WriteLine("{0,8} {1,8} {2,8}"
                , "number"
                , "square"
                , "cube");
            Console.WriteLine(line);
            do
            {
                sumNumber = number + sumNumber;
                sumSquare = (number * number) + sumSquare;
                sumCube = (number * number * number) + sumCube;
                Console.WriteLine("{0,8} {1,8} {2,8}"
                    , number
                    , (number * number)
                    , (number * number * number));
                number = number + NUMBER_TO_ADD;
                if (number > HIGHEST_NUMBER)
                {
                    Console.WriteLine(line);
                    Console.WriteLine("{0,8} {1,8} {2,8}"
                        , sumNumber
                        , sumSquare
                        , sumCube);
                }
            }
            while (number <= HIGHEST_NUMBER);
        }
    }
}

