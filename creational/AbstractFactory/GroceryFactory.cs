using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class GroceryFactory: IFactory<Groceries>
    {
        private Random _random = new Random();
        private static List<string> _groceries = new List<string>() 
            {"leche", "pan", "queso", "jamon", "cereal", "huevos"};
        public Groceries BuildItem()
        {
            var name = _groceries[_random.Next(_groceries.Count)];
            var index = _random.Next(1000);
            
            return new Groceries(name, index);
        }
    }
}