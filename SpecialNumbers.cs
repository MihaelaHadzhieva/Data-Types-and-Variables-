using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            bool spacial = false;
            for (int i = 1; i <= number; i++)
            {
                int digits = 0;
                digits = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                spacial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digits} -> {spacial}");
                sum = 0;
                i = digits;
            }

        }
    }
}
