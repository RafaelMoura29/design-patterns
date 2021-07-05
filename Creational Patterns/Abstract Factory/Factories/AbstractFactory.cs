using AbstractFactory01.Shapes.Interfaces;

namespace AbstractFactory01.Factories
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string shapeType);
    }
}