using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}
