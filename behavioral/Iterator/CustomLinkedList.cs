using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class CustomLinkedList<T> : IEnumerable<T>
    {
        public Node<T> Root { get; }

        public CustomLinkedList(Node<T> root)
        {
            Root = root;
        }

        public void Add(T item)
        {
            Root.Add(item);
        }

        public IIterator<T> GetIterator()
        {
            return new LinkedListIterator<T>(this);
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = Root;
            while (node != null)
            {
                yield return node.Item;
                node = node.Next();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}