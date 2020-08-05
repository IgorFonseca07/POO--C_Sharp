using Heranca_Interface.Model.Enums;
using System;
using System.Globalization;

namespace Heranca_Interface.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.00);
        }

        public override string ToString()
        {
            return "Circle color: "
                + Color
                + ", radius: "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
