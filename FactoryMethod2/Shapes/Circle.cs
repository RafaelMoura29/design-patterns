using System;
using FactoryMethod2.Shapes.Interfaces;

namespace FactoryMethod2.Shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}