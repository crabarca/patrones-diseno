namespace Iterator
{
    public class LinkedListIterator<T> : IIterator<T>
    {
        private CustomLinkedList<T> _customLinkedList;

        private Node<T> _currentItem;

        public LinkedListIterator(CustomLinkedList<T> customLinkedList)
        {
            _customLinkedList = customLinkedList;
        }

        public T First()
        {
            _currentItem = _customLinkedList.Root;
            return _currentItem.Item;
        }

        public T Next()
        {
            _currentItem = _currentItem.Next();
            return _currentItem.Item;
        }

        public bool IsDone()
        {
            return _currentItem.Next() == null;
        }

        public T CurrentItem()
        {
            return _currentItem.Item;
        }
    }
}