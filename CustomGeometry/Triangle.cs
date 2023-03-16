using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGeometry
{
    public class Triangle : Figure2D
    {
        /// <summary>
        ///     Сторона A
        /// </summary>
        public double A { get; set; }

        /// <summary>
        ///     Сторона B
        /// </summary>
        public double B { get; set; }

        /// <summary>
        ///     Сторона C
        /// </summary>
        public double C { get; set; }

        private bool isValid()
        {
            return (A > 0 && B > 0 && C > 0); 
        }

        public override double CalculateArea()
        {
            if(!isValid())
            {
                return 0;
            }
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool isRight()
        {
            if (!isValid())
            {
                return false;
            }

            if(A * A == B * B + C * C) { 
                return true; 
            }
            if (B * B == A * A + C * C)
            {
                return true;
            }
            if (C * C == B * B + A * A)
            {
                return true;
            }
            return false;
        }
    }
}
