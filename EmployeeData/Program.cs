using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long ID = long.Parse(Console.ReadLine());
            int employeeNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fist Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {ID}");
            Console.WriteLine($"Unique Employee number: {employeeNum}");




        }
    }
}
