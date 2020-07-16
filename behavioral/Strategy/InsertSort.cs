using System;

namespace Strategy
{
    public class InsertSort<T> : SortingStrategy<T> where T : IComparable<T>
    {
        public override void Sort(T[] items, int length)
        {
            for (var i = 0; i < length - 1; i++)
            {
                for (var j = i + 1; j > 0 && items[j].CompareTo(items[j - 1]) < 0; j--)
                {
                    var temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }
}