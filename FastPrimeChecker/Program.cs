using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
                 
            int number = int.Parse(Console.ReadLine());
            for (int devisor = 2; devisor <= number; devisor++)
            {
                bool result = true;
                for (int dividend = 2; dividend <= Math.Sqrt(devisor); dividend++)
                {
                    if (devisor % dividend == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{devisor} -> {result}");
            }
                
         }
      }
  }
