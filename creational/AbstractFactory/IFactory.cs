namespace AbstractFactory
{
    public interface IFactory<T> where T:IIndexedItem
    {
        T BuildItem();
    }
}