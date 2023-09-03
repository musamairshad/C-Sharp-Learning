using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Animal eats......");
        }
    }

    public class Cat : Animal
    {
        public override void eat() // Method overriding. 
        {
            base.eat(); // Calling the eat() method of the base class.
            Console.WriteLine("Cat eats meat...");
        }
    }
}
