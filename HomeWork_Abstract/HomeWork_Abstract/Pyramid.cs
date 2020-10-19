using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract
{
    class Pyramid : Figure
    {
        double _d, _f, _h;
        public double D { get; set; }
        public double F { get; set; }
        public double H { get; set; }

        internal Pyramid(double _d, double _f, double _h)
        {
            D = _d;
            F = _f;
            H = _h;
        }

        internal override double Volume()
        {
            return D * F * H;
        }
    }
}
