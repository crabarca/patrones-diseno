namespace Memento
{
    public class Memento
    {
        public State State { get; }

        public Memento(State state)
        {
            State = state;
        }
    }
}