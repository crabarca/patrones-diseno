using System;

namespace Strategy
{
    public class SelectSort<T> : SortingStrategy<T> where T : IComparable<T>
    {
        public override void Sort(T[] items, int length)
        {
            for (var i = 0; i < length; i++)
            {
                var minIndex = i;


                for (var j = i; j < length; j++)
                {
                    if (items[j].CompareTo(items[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = items[i];
                items[i] = items[minIndex];
                items[minIndex] = temp;
            }
        }
    }
}