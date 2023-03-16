using CustomGeometry;

var circle = new Circle();
circle.Radius = 5;

Console.WriteLine(circle.CalculateArea());

var triangle = new Triangle();
triangle.A = 3;
triangle.B = 4;
triangle.C = 5;

var helper = new Geometry2DHelper();

Console.WriteLine(helper.CalculateArea(triangle));
Console.WriteLine($"This triangle is right - {triangle.isRight()}");
