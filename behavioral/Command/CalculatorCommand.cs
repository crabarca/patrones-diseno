namespace Command
{
    public class CalculatorCommand: ICommand
    {
        public enum Operation
        {
            Add, Subtract, Multiply, Divide
        }

        private IReceiver _receiver;
        private Operation _operation;
        private double _value;

        public CalculatorCommand(IReceiver receiver, Operation operation, double value)
        {
            _receiver = receiver;
            _operation = operation;
            _value = value;
        }

        public void Execute()
        {
            switch (_operation)
            {
                case Operation.Add:
                    _receiver.Add(_value);
                    break;
                case Operation.Subtract:
                    _receiver.Subtract(_value);
                    break;
                case Operation.Multiply:
                    _receiver.Multiply(_value);
                    break;
                case Operation.Divide:
                    _receiver.Divide(_value);
                    break;
            }
        }

        public void Undo()
        {
            switch (_operation)
            {
                case Operation.Add:
                    _receiver.Subtract(_value);
                    break;
                case Operation.Subtract:
                    _receiver.Add(_value);
                    break;
                case Operation.Multiply:
                    _receiver.Divide(_value);
                    break;
                case Operation.Divide:
                    _receiver.Multiply(_value);
                    break;
            }
        }
    }
}