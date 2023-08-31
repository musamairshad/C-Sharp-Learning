using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ScientificCalculator : SimpleCalculator
    {
        public double Sin(double rad)
        {
            return Math.Sin(rad);
        }
    }
}
