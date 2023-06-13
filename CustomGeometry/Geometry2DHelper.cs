namespace CustomGeometry
{
    /// <summary>
    ///     Вспомогательный класс для геометрических расчётов (Второй вариант решения)
    /// </summary>
    public sealed class Geometry2DHelper
    {
        private readonly Figure2D _figure;

        public Geometry2DHelper(Figure2D figure)
        {
            _figure = figure ?? throw new ArgumentNullException("figure is null!");
        }

        public double CalculateArea()
        {
            if(_figure is Circle circle)
            {
                return CalculateAreaCircle(circle);
            }
            else if(_figure is Triangle triangle)
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

        /// <summary>
        ///     Является ли прямоугольным (для треугольников)
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            if (_figure is Triangle triangle)
            {
                if (triangle.A * triangle.A == triangle.B * triangle.B + triangle.C * triangle.C)
                {
                    return true;
                }
                if (triangle.B * triangle.B == triangle.A * triangle.A + triangle.C * triangle.C)
                {
                    return true;
                }
                if (triangle.C * triangle.C == triangle.B * triangle.B + triangle.A * triangle.A)
                {
                    return true;
                }
                return false;
            }
            return false; //Здесь можно вывести исключение
        }
    }
}
