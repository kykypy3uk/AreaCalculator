namespace AreaCalculatorLib.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            AreaCalculator calculator = new AreaCalculator();
            double area = calculator.Calculate(triangle);

            Assert.IsTrue(area > 5.99 && area <= 6.0);
        }
    }
}