namespace CustomGeometry
{
    public sealed class Triangle : Figure2D
    {
        private readonly double _a, _b, _c;

        /// <summary>
        ///     Сторона A
        /// </summary>
        public double A { get => _a; }

        /// <summary>
        ///     Сторона B
        /// </summary>
        public double B { get => _b; }

        /// <summary>
        ///     Сторона C
        /// </summary>
        public double C { get => _c; }

        public Triangle(double a, double b, double c)
        {
            if(a < 0 || b < 0 || c < 0) { throw new ArgumentException("One of arguments is not valid!"); }

            _a = a;
            _b = b;
            _c = c;
        }

        public override double CalculateArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRight()
        {
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
