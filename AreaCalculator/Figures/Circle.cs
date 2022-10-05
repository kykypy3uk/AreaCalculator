namespace AreaCalculatorLib.Figures
{
    public class Circle : IFigure
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : -value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            double S = Math.PI * Radius * Radius;

            return (S);
        }
    }
}
