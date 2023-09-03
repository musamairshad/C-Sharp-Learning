using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();
            ScientificCalculator scientificCalculator = new ScientificCalculator();
            double result = scientificCalculator.Divide(1, 8);
            double result2 = scientificCalculator.Divide(3.1, 2.1);
            double result3 = scientificCalculator.Add(2, 4, 6);
            // double result4 = scientificCalculator.Add([1, 2, 3, 4]);
            Console.WriteLine(result3);
            Console.ReadLine();
            /*
            double result = simpleCalculator.Add(2, 3);
            double result2 = scientificCalculator.Add(10, 10);
            double result3 = scientificCalculator.Sin(30);
            Console.WriteLine(result3);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.ReadLine();
            */
        }
    }
}
