using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int a, b, c, d, e, f;
            // int[] intArray; // Array Declaration...
            int[] intArray = new int[10]; // Initialize and Declare the Array
            // in the same line.
            // intArray[3] = 32;
            // intArray[2] = 28;

            // To store even numbers in an Array...
            int a = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                /*
                if(i % 2 == 0)
                {
                    intArray[i] = i;
                }
                */


                intArray[i] = a;
                a += 2;
            }

            foreach (int item in intArray) {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
