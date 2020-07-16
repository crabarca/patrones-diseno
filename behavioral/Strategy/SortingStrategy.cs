namespace Strategy
{
    public abstract class SortingStrategy<T>
    {
        public abstract void Sort(T[] items, int length);

    }
}