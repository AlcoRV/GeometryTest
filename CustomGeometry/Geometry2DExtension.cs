﻿namespace CustomGeometry
{
    /// <summary>
    ///     Класс для методов расширения 2D-фигур (третий вариант)
    /// </summary>
    public static class Geometry2DExtension
    {
        public static double CalculateAreaExt(this Figure2D figure)
        {
            if (figure is Circle circle)
            {
                return CalculateAreaCircle(circle);
            }
            else if (figure is Triangle triangle)
            {
                return CalculateAreaTriangle(triangle);
            }
            return 0; //По-хорошему, надо вернуть AreaException
        }

        private static double CalculateAreaCircle(Circle circle) => Math.PI * circle.Radius * circle.Radius;

        private static double CalculateAreaTriangle(Triangle triangle)
        {
            var p = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
        }
    }
}