namespace Command
{
    public class Calculator: IReceiver
    {
        public double Value { get; set; }

        public void Add(double value)
        {
            Value += value;
        }

        public void Subtract(double value)
        {
            Value -= value;
        }

        public void Multiply(double value)
        {
            Value *= value;
        }

        public void Divide(double value)
        {
            Value /= value;
        }
    }
}