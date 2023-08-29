using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                n += 100;
            }
            else
            {
                n += 50;
            }
            Console.WriteLine("The number is " + n);
            //Console.ReadLine();
            Console.ReadKey(); // Similar to the Console.ReadLine();
            */

            double num1 = 5, num2 = 10;
            l1:
            Console.WriteLine("Press 1 for Addition: ");
            Console.WriteLine("Press 2 for Subtraction: ");
            Console.WriteLine("Press 3 for Multiplication: ");
            Console.WriteLine("Press 4 for Division: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"{num1} ÷ {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            Console.WriteLine("Press any key to Continue........"); 
            Console.ReadLine();
            Console.Clear();
            goto l1;
        }
    }
}
