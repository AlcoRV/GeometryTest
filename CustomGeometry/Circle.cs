namespace CustomGeometry
{
    public sealed class Circle : Figure2D
    {
        private readonly double _radius;

        public double Radius
        {
            get => _radius; 
        }

        public Circle(double radius)
        {
            if(radius < 0) { throw new ArgumentException("Radius is not valid!"); }

            _radius = radius;
        }

        public override double CalculateArea() => Math.PI * Radius * Radius;
    }
}
