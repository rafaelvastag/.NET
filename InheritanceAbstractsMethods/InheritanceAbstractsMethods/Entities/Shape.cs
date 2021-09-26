using InheritanceAbstractsMethods.Entities.Enums;

namespace InheritanceAbstractsMethods.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
