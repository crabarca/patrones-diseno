namespace Iterator
{
    public class Node<T>
    {
        public T Item { get; }

        private Node<T> _nextNode;

        public Node(T item)
        {
            Item = item;
        }

        public void Add(T item)
        {
            if (_nextNode == null)
            {
                _nextNode = new Node<T>(item);
            }
            else
            {
                _nextNode.Add(item);
            }
        }

        public Node<T> Next()
        {
            return _nextNode;
        }
    }
}