using System.Collections.Generic;
using builder.Interfaces;
using System;

namespace builder
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;

            foreach (Item item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (Item item in items)
            {
                Console.Write("Item : " + item.Name());
                Console.Write(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}