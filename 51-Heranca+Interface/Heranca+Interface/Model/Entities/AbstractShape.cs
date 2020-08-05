using Heranca_Interface.Model.Enums;

namespace Heranca_Interface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
