using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._4
{
    public class Isosceles: ITriangleArea
    {
        public double FindArea(double a, double b, double c)//какая то не оопшная реализация метода, много if
        {
            if (a*a + b*b == c * c)
            {
                return 0.5 * a * b;
            }
            if (a * a + c * c == b * b)
            {
                return 0.5 * a * c;
            }
            if (c * c + b * b == a * a)
            {
                return 0.5 * c * b;
            }
            return 0;
        }
    }
}
