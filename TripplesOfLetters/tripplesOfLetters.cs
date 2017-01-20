using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class TriplesOfLatinLetters
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int firstLetter = 0; firstLetter < number; firstLetter++)
            {
                for (int secondletter = 0; secondletter < number; secondletter++)
                {
                    for (int thirdletter = 0; thirdletter < number; thirdletter++)
                    {
                        char letter1 = (char)('a' + firstLetter);
                        char letter2 = (char)('a' + secondletter);
                        char letter3 = (char)('a' + thirdletter);

                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }

            }

        }
    }
}
