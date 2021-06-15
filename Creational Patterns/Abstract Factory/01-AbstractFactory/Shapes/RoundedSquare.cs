using System;
using AbstractFactory01.Shapes.Interfaces;

namespace AbstractFactory01.Shapes
{
    public class RoundedSquare : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}