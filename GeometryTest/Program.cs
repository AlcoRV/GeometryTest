using CustomGeometry;

var circle = new Circle();
circle.Radius = 5;

Console.WriteLine(circle.CalculateArea());

var triangle = new Triangle();
triangle.A = 2;
triangle.B = 3;
triangle.C = 4;

var helper = new Geometry2DHelper();

Console.WriteLine(helper.CalculateArea(triangle));
