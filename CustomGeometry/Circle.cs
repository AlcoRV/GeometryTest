using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGeometry
{
    public class Circle : Figure2D
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            if (Radius <= 0)
            {
                return 0;
            }
            return Math.PI * Radius * Radius;
        }
    }
}
