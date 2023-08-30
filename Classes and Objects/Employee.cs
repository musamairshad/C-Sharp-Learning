using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        public void login() 
        {
            // Add logic here......
            Console.WriteLine(FullName + " has logged in at " + DateTime.Now);
        }

        public void logout()
        {
            // Add logic here......
            Console.WriteLine(FullName + " has logged out at " + DateTime.Now);
        }
    }
}
