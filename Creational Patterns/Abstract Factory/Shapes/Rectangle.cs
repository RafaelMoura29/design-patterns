using System;
using AbstractFactory01.Shapes.Interfaces;

namespace AbstractFactory01.Shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}