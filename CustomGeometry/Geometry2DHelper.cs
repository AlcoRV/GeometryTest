using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGeometry
{
    /// <summary>
    ///     Вспомогательный класс для геометрических расчётов (Второй вариант решения)
    /// </summary>
    public class Geometry2DHelper
    {
        public double CalculateArea(Figure2D figure)
        {
            if(figure is Circle circle)
            {
                return CalculateAreaCircle(circle);
            }
            else if(figure is Triangle triangle)
            {
                return CalculateAreaTriangle(triangle);
            }
            return 0; //По-хорошему, надо вернуть AreaException
        }

        private double CalculateAreaCircle(Circle circle)
        {
            if (circle.Radius <= 0)
            {
                return 0;
            }
            return Math.PI * circle.Radius * circle.Radius;
        }

        private double CalculateAreaTriangle(Triangle triangle)
        {
            if (triangle.A <= 0 || triangle.B <= 0 || triangle.C <= 0)
            {
                return 0;
            }
            var p = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
        }
    }
}
