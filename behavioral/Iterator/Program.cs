using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new Node<string>("A");
            var linkedList = new CustomLinkedList<string>(node1);
            
            linkedList.Add("B");
            linkedList.Add("C");
            linkedList.Add("D");
            linkedList.Add("E");
            linkedList.Add("F");

            var iterator = linkedList.GetIterator();
            string item = iterator.First();
            Console.WriteLine(item);
            while (!iterator.IsDone())
            {
                item = iterator.Next();
                Console.WriteLine(item);
            }

            Console.WriteLine("---");
            
            foreach (var item2 in linkedList)
            {
                Console.WriteLine(item2);
            }

        }
    }
}