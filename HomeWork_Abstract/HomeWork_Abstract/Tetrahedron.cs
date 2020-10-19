using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract
{
    class Tetrahedron : Figure
    {
        double _k;
        public double K { get; set; }

        internal Tetrahedron(double _k)
        {
            K = _k;
        }

        internal override double Volume()
        {
            return Math.Pow(K, 3) * Math.Pow(2, 0.5) / 12;
        }
    }
}
