using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Abstract
{
    class Ball : Figure
    {
        double _r;
        public double R { get; set; }

        internal Ball (double _r)
        {
            R = _r;
        }

        internal override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(R, 3);
        }
        
    }
}
