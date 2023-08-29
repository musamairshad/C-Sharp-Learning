using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!"); // Prints the hello world on the screen.

            // Value types:
            int num1 = 5;
            int num2 = 10;
            int num3 = num1 + num2;

            Console.WriteLine(num3);

            // Reference types:
            object obj = 50.2; // Check the type on Compile time...
            dynamic dyna = 51; // Check the type on Run time...

            Console.WriteLine(obj);
            Console.WriteLine(dyna);

            // Boxing vs Unboxing:
            object obj1 = 2; // This is what we called boxing.
            int number = (int) obj1; // This is called unboxing.
            Console.ReadLine(); // Used to Hold the screen.
        }
    }
}
