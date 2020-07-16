namespace Memento
{
    public class State
    {
        public string Value { get; set; }

        public State(string value)
        {
            Value = value;
        }

        public State Clone()
        {
            return new State(Value);
        }
    }
}