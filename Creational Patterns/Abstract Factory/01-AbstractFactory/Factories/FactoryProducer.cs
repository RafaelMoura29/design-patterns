using System;

namespace AbstractFactory01.Factories
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(Boolean rounded)
        {
            if (rounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}