namespace Memento
{
    public class Originator
    {
        private State _currentState;

        public Originator(State currentState)
        {
            _currentState = currentState;
        }

        public string GetStateValue()
        {
            return _currentState.Value;
        }

        public void AppendData(string input)
        {
            _currentState.Value += input;
        }

        public Memento SaveState()
        {
            return new Memento(_currentState.Clone());
        }

        public void RestoreState(Memento memento)
        {
            _currentState = memento.State;
        }
    }
}