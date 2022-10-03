namespace AreaCalculatorLib
{
    public class AreaCalculator
    {
        public double Calculate(IFigure figure)
        {
            if (figure != null)
            {
                double S = figure.Area();

                return S;
            }
            else throw new NullReferenceException();
        }
    }
}