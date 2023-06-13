namespace CustomGeometry
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
                return circle.CalculateAreaExt();
            }
            else if (figure is Triangle triangle)
            {
                return triangle.CalculateAreaExt();
            }
            return 0; //По-хорошему, надо вернуть AreaException
        }

        public static double CalculateAreaExt(this Circle circle) => Math.PI * circle.Radius * circle.Radius;

        public static double CalculateAreaExt(this Triangle triangle)
        {
            var p = (triangle.A + triangle.B + triangle.C) / 2;
            return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
        }

        public static bool IsRightExt(this Triangle triangle)
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
    }
}
