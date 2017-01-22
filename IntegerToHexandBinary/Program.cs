using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexandBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hexadecimalbase = 16;
            int binarybase = 2;
            var hexadecimal = Convert.ToString(number,hexadecimalbase);
            var binary = Convert.ToString(number, binarybase);
            hexadecimal = hexadecimal.ToUpper();
            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);
        }
    }
}
