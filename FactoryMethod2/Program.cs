using System;
using FactoryMethod2.Factories;
using FactoryMethod2.Shapes.Interfaces;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            IShape shape1 = shapeFactory.getShape("CIRCLE");

            //call draw method of Circle
            shape1.Draw();

            //get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.getShape("RECTANGLE");

            //call draw method of Rectangle
            shape2.Draw();

            //get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.getShape("SQUARE");

            //call draw method of square
            shape3.Draw();
        }
    }
}
