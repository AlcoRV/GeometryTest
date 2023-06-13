using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomGeometry.Tests
{
    [TestClass()]
    public sealed class Geometry2DHelperTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "figure is null!")]
        public void CreatingHelper_WithNullRef_ReturnsCorrectResult()
        {
            // Arrange
            Figure2D figure = null;

            // Act
            double actual = new Geometry2DHelper(figure).CalculateArea();

            // Assert
            Assert.AreEqual(0, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(1, Math.PI)]
        [DataRow(10, Math.PI * 100)]
        [DataRow(7.34, Math.PI * 7.34 * 7.34)]
        public void CalculateAreaCircle_WithPositiveRadius_ReturnsCorrectResult(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            double actual = new Geometry2DHelper(circle).CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(0, 1)]
        [DataRow(-1, Math.PI)]
        [ExpectedException(typeof(ArgumentException), "Radius is not valid!")]
        public void CalculateAreaCircle_WithZeroOrNegativeRadius_ReturnsException(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            double actual = new Geometry2DHelper(circle).CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(1, 1, 1, 0.433013)]
        [DataRow(2, 3, 4, 2.904738)]
        [DataRow(1, 2, 3, 0)]
        public void CalculateAreaTriangle_WithPositiveLegs_ReturnsCorrectResult(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            double actual = new Geometry2DHelper(triangle).CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(0, 1, 1, 0)]
        [DataRow(1, 0, 1, 0)]
        [DataRow(1, 1, 0, 0)]
        [DataRow(-1, 1, 1, 0)]
        [DataRow(1, -1, 1, 0)]
        [DataRow(1, 1, -1, 0)]
        [ExpectedException(typeof(ArgumentException), "One of arguments is not valid!")]
        public void CalculateAreaTriangle_WithZeroOrNegativeLegs_ReturnsException(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            double actual = new Geometry2DHelper(triangle).CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod()]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 12, 13, true)]
        [DataRow(1, 1, 1, false)]
        [DataRow(7, 24, 24, false)]
        public void IsRightTriangle_ReturnsCorrectResult(double a, double b, double c, bool expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            bool actual = new Geometry2DHelper(triangle).IsRight();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1, false)]
        [DataRow(7, false)]
        public void IsRightCircle_ReturnsCorrectResult(double radius, bool expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            bool actual = new Geometry2DHelper(circle).IsRight();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
