using Course.Entities.Enums;

namespace Course.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        //método abstrato, não tem corpo, não tem implementação. 
        public abstract double Area();
    }
}
