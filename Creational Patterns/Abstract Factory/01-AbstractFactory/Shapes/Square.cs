using System;
using AbstractFactory01.Shapes.Interfaces;

namespace AbstractFactory01.Shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}