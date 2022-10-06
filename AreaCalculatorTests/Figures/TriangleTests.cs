namespace AreaCalculatorLib.Figures.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            double area = triangle.GetArea();

            Assert.IsTrue(area > 5.99 && area <= 6.0);
        }

        [TestMethod]
        public void CheckRightTriangleTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            bool result = triangle.CheckRightTriangle();

            Assert.IsTrue(result);
        }
    }
}