using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLib.Figures
{
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value > 0 ? value : -value; }
        }

        public double B
        {
            get { return b; }
            set { b = value > 0 ? value : -value; }
        }

        public double C
        {
            get { return c; }
            set { c = value > 0 ? value : -value; }
        }

        protected Triangle()
        {

        }

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentOutOfRangeException("Это не треугольник");
            }
            else
            {
                    A = a;
                    B = b;
                    C = c;
            }
        }

        public double Area()
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
