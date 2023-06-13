using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomGeometry.Tests
{
    [TestClass()]
    public class Geometry2DExtensionTests
    {
        [TestMethod]
        [DataRow(1, Math.PI)]
        [DataRow(10, Math.PI * 100)]
        [DataRow(7.34, Math.PI * 7.34 * 7.34)]
        public void CalculateAreaTestCircle_WithPositiveRadius_ReturnsCorrectResult(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            double actual = circle.CalculateAreaExt();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(0, 1)]
        [DataRow(-1, Math.PI)]
        [ExpectedException(typeof(ArgumentException), "Radius is not valid!")]
        public void CalculateAreaTestCircle_WithZeroOrNegativeRadius_ReturnsException(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            double actual = circle.CalculateAreaExt();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(1, 1, 1, 0.433013)]
        [DataRow(2, 3, 4, 2.904738)]
        [DataRow(1, 2, 3, 0)]
        public void CalculateAreaTestTriangle_WithPositiveLegs_ReturnsCorrectResult(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            double actual = triangle.CalculateAreaExt();

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
        public void CalculateAreaTestTriangle_WithNullOrNegativeLegs_ReturnsException(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            double actual = triangle.CalculateAreaExt();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod()]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 12, 13, true)]
        [DataRow(1, 1, 1, false)]
        [DataRow(7, 24, 24, false)]
        public void IsRight_ReturnsCorrectResult(double a, double b, double c, bool expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            bool actual = triangle.IsRightExt();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}