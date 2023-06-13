using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomGeometry.Tests
{
    [TestClass()]
    public sealed class CircleTests
    {
        [TestMethod]
        [DataRow(1, Math.PI)]
        [DataRow(10, Math.PI * 100)]
        [DataRow(7.34, Math.PI * 7.34 * 7.34)]
        public void CalculateAreaExtCircle_WithPositiveRadius_ReturnsCorrectResult(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            double actual = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(0, 1)]
        [DataRow(-1, Math.PI)]
        [ExpectedException(typeof(ArgumentException), "Radius is not valid!")]
        public void CalculateAreaExtCircle_WithZeroOrNegativeRadius_ReturnsException(double radius, double expected)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            double actual = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateAreaExtCircle_WithNullRef_ReturnsCorrectResult()
        {
            // Arrange
            Circle circle = null;

            // Act
            double actual = circle.CalculateArea();

            // Assert
            Assert.AreEqual(0, actual, 0.0001);
        }
    }
}