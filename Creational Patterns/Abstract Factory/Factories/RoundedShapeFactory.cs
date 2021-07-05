using AbstractFactory01.Shapes;
using AbstractFactory01.Shapes.Interfaces;

namespace AbstractFactory01.Factories
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType.Equals("RECTANGLE"))
            {
                return new RoundedRectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new RoundedSquare();
            }
            return null;
        }
    }
}