using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract
{
    class Parallelepiped : Figure
    {
        double _a, _b, _c;
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        internal Parallelepiped(double _a, double _b, double _c)
        {
            A = _a;
            B = _b;
            C = _c;
        }
        
        internal override double Volume()
        {
            return A * B * C;
        }
    }
}
