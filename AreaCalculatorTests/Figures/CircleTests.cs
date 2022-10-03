namespace AreaCalculatorLib.Figures.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            double radius = 3.0;
            double expectedArea = Math.PI * Math.Pow(3, 2);
            Circle circle = new Circle(radius);
            double area = circle.Area();

            Assert.AreEqual(expectedArea, area);
        }
    }
}