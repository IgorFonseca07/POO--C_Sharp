using Exerc15.Entities.Enums;

namespace Exerc15.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
