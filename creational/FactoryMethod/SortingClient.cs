using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class SortingClient
    {
        private List<IIndexedItem> _items;
        
        public SortingClient(int numberOfItems)
        {
            _items = new List<IIndexedItem>();
            for (int i = 0; i < numberOfItems; i++)
            {
                _items.Add(BuildItem());
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

        protected abstract IIndexedItem BuildItem();
    }
}