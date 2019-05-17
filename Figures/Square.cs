using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Figure
    {
        public int Side { get; set; }

        public override double CalculateArea()
        {
            return System.Math.Pow(Side, 2);
        }
    }
}
