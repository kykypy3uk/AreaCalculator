namespace AreaCalculatorLib.Figures
{
    public class Circle : IShape
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set => radius = value > 0 ? value : -value;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            double S = Math.PI * Radius * Radius;

            return (S);
        }
    }
}
