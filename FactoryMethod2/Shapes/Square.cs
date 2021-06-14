using System;
using FactoryMethod2.Shapes.Interfaces;

namespace FactoryMethod2.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}