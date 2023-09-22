using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using triangle;

namespace triangle_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GetTriangleType_ImpossibleTriangle_ReturnsImpossible()
        {
            // Arrange
            Triangle triangle = new Triangle(1, 2, 3);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.impossible, result);
        }

        [TestMethod]
        public void GetTriangleType_RectangularTriangle_ReturnsRectangular()
        {
            // Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.rectangular, result);
        }

        [TestMethod]
        public void GetTriangleType_AcuteTriangle_ReturnsAcute()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 6, 7);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.acute, result);
        }

        [TestMethod]
        public void GetTriangleType_КectangularTriangle_ReturnsКectangular()
        {
            // Arrange
            Triangle triangle = new Triangle(8, 15, 17);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.rectangular, result);
        }

        [TestMethod]
        public void GetTriangleType_EquilateralTriangle_ReturnsAcute()
        {
            // Arrange
            Triangle triangle = new Triangle(5, 5, 5);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.acute, result);
        }

        [TestMethod]
        public void GetTriangleType_IsoscelesRightTriangle_ReturnsRectangularAndAcute()
        {
            // Arrange
            Triangle triangle = new Triangle(1, 1, Math.Sqrt(2));

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.rectangular | TriangleType.acute, result);
        }


        [TestMethod]
        public void GetTriangleType_IsoscelesObtuseTriangle_ReturnsObtuse()
        {
            // Arrange
            Triangle triangle = new Triangle(7, 7, 10);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.obtuse, result);
        }

        [TestMethod]
        public void GetTriangleType_ScaleneКectangularTriangle_ReturnsКectangular()
        {
            // Arrange
            Triangle triangle = new Triangle(6, 8, 10);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.rectangular, result);
        }

        [TestMethod]
        public void GetTriangleType_ScaleneObtuseTriangle_ReturnsObtuse()
        {
            // Arrange
            Triangle triangle = new Triangle(7, 24, 25);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.rectangular, result);
        }

        [TestMethod]
        public void GetTriangleType_ScaleneRightTriangle_ReturnsRectangular()
        {
            // Arrange
            Triangle triangle = new Triangle(9, 12, 15);

            // Act
            TriangleType result = triangle.GetTriangleType();

            // Assert
            Assert.AreEqual(TriangleType.rectangular, result);
        }
    }
}
