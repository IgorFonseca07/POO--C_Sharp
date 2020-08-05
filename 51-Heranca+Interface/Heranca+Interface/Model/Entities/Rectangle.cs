using Heranca_Interface.Model.Enums;
using System.Globalization;

namespace Heranca_Interface.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base (color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color: "
                + Color
                + ", width: "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height: "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
