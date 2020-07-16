namespace FactoryMethod
{
    public class Student: IIndexedItem
    {
        public string Name { get; }
        public int Id { get; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public string GetName()
        {
            return Name;
        }

        public int GetIndex()
        {
            return Id;
        }
    }
}