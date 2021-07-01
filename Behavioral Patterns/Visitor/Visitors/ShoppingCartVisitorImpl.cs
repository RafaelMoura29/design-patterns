using System;

namespace Visitor
{
    public class ShoppingCartVisitorImpl : ShoppingCartVisitor
    {
        public override int Visit(Book book)
        {
            int cost = 0;

            if (book.Price > 50)
                cost = book.Price - 5;
            else
                cost = book.Price;

            Console.WriteLine("Book ISBN::" + book.IsBnNumber + " cost =" + cost);
            return cost;
        }

        public override int Visit(Fruit fruit)
        {
            int cost = fruit.PricePerKg * fruit.Weight;
            Console.WriteLine(fruit.Name + " cost = " + cost);
            return cost;
        }
    }
}