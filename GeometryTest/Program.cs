using CustomGeometry;

var circle1 = new Circle(5);
var circle2 = new Circle(7);

Console.WriteLine(circle1.CalculateArea());
Console.WriteLine(circle2.CalculateAreaExt());

var triangle = new Triangle(3, 4, 5);

var helper = new Geometry2DHelper(triangle);

Console.WriteLine(helper.CalculateArea());
Console.WriteLine($"This triangle is right - {triangle.IsRight()}");
