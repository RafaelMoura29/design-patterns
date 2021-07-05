using System;
using FactoryMethod2.Shapes.Interfaces;

namespace FactoryMethod2.Shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}