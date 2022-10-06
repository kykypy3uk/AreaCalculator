using AreaCalculatorLib.Shapes;

namespace AreaCalculatorLib
{
    public class AreaCalculator
    {
        public double GetArea(IShape figure)
        {
            return figure.GetArea();
        }
    }
}