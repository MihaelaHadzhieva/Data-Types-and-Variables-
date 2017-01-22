using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = Console.ReadLine();
            int number = Convert.ToInt32(Text, 16);
            Console.WriteLine(number);

        }
    }
}
