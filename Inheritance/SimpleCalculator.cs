using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class SimpleCalculator
    {
        public double Add(int num1, int num2) 
        {
            return num1 + num2;
        }

        public double Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public double Add(List<int> listOfInts)
        {
            double sum = 0;
            foreach (var item in listOfInts)
            {
                sum += item;
            }
            return sum;
        }

        public double Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2) // Method overloading.
        {
            return num1 / num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
