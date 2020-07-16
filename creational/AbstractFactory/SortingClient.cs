using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class SortingClient<T> where T:IIndexedItem
    {
        private List<IIndexedItem> _items;

        public SortingClient(IFactory<T> factory, int numberOfItems)
        {
            _items = new List<IIndexedItem>();
            for (int i = 0; i < numberOfItems; i++)
            {
                _items.Add(factory.BuildItem());
            }
        }

        public void Sort()
        {
            _items.Sort((item1, item2) => 
                item1.GetIndex() - item2.GetIndex());

            foreach (var indexedItem in _items)
            {
                Console.WriteLine($"{indexedItem.GetName()} - {indexedItem.GetIndex()}");
            }
        }
    }
}