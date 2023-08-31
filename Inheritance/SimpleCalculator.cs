using System;
using System.Collections.Generic;
using System.Linq;
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

        public double Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2) 
        {
            return num1 / num2;
        }
    }
}
