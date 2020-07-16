using System;

namespace Strategy
{
    public class CustomList<T> where T : IComparable<T>
    {
        private T[] _items;
        private int _count;

        public CustomList(int capacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            _items[_count] = item;
            _count++;
        }

        public void Sort(SortingStrategy<T> strategy)
        {
            strategy.Sort(_items, _count);
        }

        public void Print()
        {
            for(var i = 0; i < _count; i++)
            {
                Console.Write(_items[i] + " ");
            }
        }
    }
}