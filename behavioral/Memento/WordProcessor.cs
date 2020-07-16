using System;

namespace Memento
{
    public class WordProcessor
    {
        private Caretaker _caretaker;
        private Originator _originator;

        public WordProcessor()
        {
            _caretaker = new Caretaker();
            var initialState = new State("");
            _originator = new Originator(initialState);
            _caretaker.AddMemento(_originator.SaveState());
        }

        public void OnInput(string input)
        {
            _originator.AppendData(input);
            var memento = _originator.SaveState();
            _caretaker.AddMemento(memento);
            
            Console.WriteLine($"Current state: {GetStateValue()}");
        }

        public void Undo()
        {
            var memento = _caretaker.Undo();
            if (memento != null)
            {
                _originator.RestoreState(memento);
            }
            
            Console.WriteLine($"Current state: {GetStateValue()}");
        }

        public void Redo()
        {
            var memento = _caretaker.Redo();
            if (memento != null)
            {
                _originator.RestoreState(memento);
            }
            
            Console.WriteLine($"Current state: {GetStateValue()}");
        }

        public string GetStateValue()
        {
            return _originator.GetStateValue();
        }
    }
}