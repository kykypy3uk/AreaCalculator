using AreaCalculatorLib.Shapes;

namespace AreaCalculatorLib.Figures
{
    public class Triangle : IShape
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get => a;
            set => a = value > 0 ? value : -value;
        }

        public double B
        {
            get => b;
            set => b = value > 0 ? value : -value;
        }

        public double C
        {
            get => c;
            set => c = value > 0 ? value : -value;
        }

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentOutOfRangeException("Это не треугольник");
            else
            {
                    A = a;
                    B = b;
                    C = c;
            }
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return (S);
        }

        public bool CheckRightTriangle()
        {
            if ((Math.Round(A * A + B * B, 10) == Math.Round(C * C, 10))
                || (Math.Round(A * A + C * C, 10) == Math.Round(B * B, 10))
                || (Math.Round(C * C + B * B, 10) == Math.Round(A * A, 10)))
                return true;
            else
                return false;
        }
    }
}
