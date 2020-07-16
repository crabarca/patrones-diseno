namespace AbstractFactory
{
    public class Groceries: IIndexedItem
    {
        public string Name { get; }
        public int Index { get; }

        public Groceries(string name, int index)
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