using System.Collections.Generic;

namespace Memento
{
    public class Caretaker
    {
        private List<Memento> _mementoes;
        private int _currentMemento;

        public Caretaker()
        {
            _mementoes = new List<Memento>();
            _currentMemento = -1;
        }

        public void AddMemento(Memento memento)
        {
            if (_mementoes.Count > _currentMemento + 1)
            {
                _mementoes.RemoveRange(_currentMemento + 1, _mementoes.Count - _currentMemento - 1);
            }
            
            _mementoes.Add(memento);
            _currentMemento = _mementoes.Count - 1;
        }

        public Memento Undo()
        {
            if (_currentMemento > 0)
            {
                _currentMemento--;
                return _mementoes[_currentMemento];
            }

            return null;
        }

        public Memento Redo()
        {
            if (_currentMemento < _mementoes.Count - 2)
            {
                _currentMemento++;
                return _mementoes[_currentMemento];
            }

            return null;
        }
    }
}