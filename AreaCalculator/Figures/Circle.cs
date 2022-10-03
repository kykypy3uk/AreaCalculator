using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected Circle()
        {

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
