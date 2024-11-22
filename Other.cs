using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._4
{
    public class Other: ITriangleArea
    {
        public double FindArea(double a, double b, double c)
        {
            double d = (a + b + c) / 2;
            return Math.Sqrt(d * (d - a) * (d - b) * (d - c));
        }
    }
}
