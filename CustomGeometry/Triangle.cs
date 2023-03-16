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

        public override double CalculateArea()
        {
            if(A <= 0 || B <= 0 || C <= 0)
            {
                return 0;
            }
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
