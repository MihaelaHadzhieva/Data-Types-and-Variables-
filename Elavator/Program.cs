using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacityPeople = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)numberPeople / capacityPeople);
            Console.WriteLine(courses);
        }
    }
}
