namespace Command
{
    public interface IReceiver
    {
        double Value { get; set; }

        void Add(double value);

        void Subtract(double value);

        void Multiply(double value);
        
        void Divide(double value);
    }
}