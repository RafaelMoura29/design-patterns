using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemElement[] items = new ItemElement[]{new Book(20, "1234"),
                              new Book(100, "5678"), new Fruit(10, 2, "Banana"),
                              new Fruit(5, 5, "Apple")};

            int total = CalculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        private static int CalculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.Accept(visitor);
            }
            return sum;
        }
    }
}
