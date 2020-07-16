namespace FactoryMethod
{
    public class Grocery: IIndexedItem
    {
        public string Name { get; }
        public int Index { get; }

        public Grocery(string name, int index)
        {
            Name = name;
            Index = index;
        }
        
        public string GetName()
        {
            return Name;
        }

        public int GetIndex()
        {
            return Index;
        }
    }
}