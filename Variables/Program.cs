using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        readonly double radius = 0;
        public Program(int r)
        {
            radius = r;
        }

        static void Main(string[] args)
        {
            /*
            int a = 2;
            float b = 3.142f;
            double c = 4500000;
            char d = 'U';
            byte e = 1;

            int number1, number2, number3;
            Console.WriteLine("Enter First Number: ");
            number1 = Convert.ToInt32(Console.ReadLine()); // Whatever user will type will convert
            // into int and then store it in a variable named as number1.
            Console.WriteLine("Enter Second Number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = number1 + number2;
            // Console.WriteLine("Sum is: " + number3);
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number3);
            Console.ReadLine();
            */

            const double pi = 3.142;
            var programObject = new Program(6);
            // double area = pi * programObject.radius * programObject.radius;
            double area = pi * Math.Pow(programObject.radius, 2);
            Console.WriteLine("Area of the circle is: " + area);
            Console.ReadLine();
        }
    }
}
