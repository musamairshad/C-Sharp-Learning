using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.FullName = "Usama Irshad";
            employee.Department = "Engineering"; // Properties.

            employee.login(); // Action.

            Console.ReadLine();

        }
    }
}
