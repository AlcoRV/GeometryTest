using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGeometry.Tests
{
    [TestClass()]
    public sealed class TriangleTests
    {
        [TestMethod]
        [DataRow(1, 1, 1, 0.433013)]
        [DataRow(2, 3, 4, 2.904738)]
        [DataRow(1, 2, 3, 0)]
        public void CalculateAreaExtTriangle_WithPositiveLegs_ReturnsCorrectResult(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            double actual = triangle.CalculateArea();

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
        public void CalculateAreaExtTriangle_WithNullOrNegativeLegs_ReturnsException(double a, double b, double c, double expected)
        {
            // Arrange
            var triangle = new Triangle(a, b, c);

            // Act
            double actual = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CalculateAreaExtTriangle_WithNullRef_ReturnsCorrectResult()
        {
            // Arrange
            Triangle triangle = null;

            // Act
            double actual = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(0, actual, 0.0001);
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
            bool actual = triangle.IsRight();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
