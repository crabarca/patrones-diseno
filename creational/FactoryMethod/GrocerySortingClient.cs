using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public class GrocerySortingClient: SortingClient
    {
        private Random _random = new Random();
        private static List<string> _groceries = new List<string>() 
            {"leche", "pan", "queso", "jamon", "cereal", "huevos"};
        
        public GrocerySortingClient(int numberOfItems) : base(numberOfItems)
        {
        }

        protected override IIndexedItem BuildItem()
        {
            var name = _groceries[_random.Next(_groceries.Count)];
            var index = _random.Next(1000);
            
            return new Grocery(name, index);
        }
    }
}