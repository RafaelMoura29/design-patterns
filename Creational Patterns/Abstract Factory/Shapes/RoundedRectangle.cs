using System;

namespace AbstractFactory01.Shapes.Interfaces
{
    public class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}