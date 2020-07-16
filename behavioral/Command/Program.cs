using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            var calculator = new Calculator();

            var command1 = new CalculatorCommand(calculator, CalculatorCommand.Operation.Add, 10);
            var command2 = new CalculatorCommand(calculator, CalculatorCommand.Operation.Multiply, 5);
            var command3 = new CalculatorCommand(calculator, CalculatorCommand.Operation.Subtract, 5);
            var command4 = new CalculatorCommand(calculator, CalculatorCommand.Operation.Divide, 5);

            invoker.Command = command1;
            invoker.Invoke();
            
            invoker.Command = command2;
            invoker.Invoke();
            
            invoker.Command = command3;
            invoker.Invoke();
            invoker.Undo();
            
            invoker.Command = command4;
            invoker.Invoke();
            
            Console.WriteLine($"Result is : {calculator.Value}");
        }
    }
}