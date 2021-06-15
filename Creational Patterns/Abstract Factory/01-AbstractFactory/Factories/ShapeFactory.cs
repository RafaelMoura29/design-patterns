using AbstractFactory01.Shapes;
using AbstractFactory01.Shapes.Interfaces;

namespace AbstractFactory01.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}