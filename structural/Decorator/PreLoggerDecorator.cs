using System;

namespace Decorator
{
    public class PreLoggerDecorator: AbstractDecorator
    {
        public PreLoggerDecorator(IComponent component) : base(component)
        {
        }

        public override void PerformOperation()
        {
            Console.WriteLine("Operation will be performed.");
            base.PerformOperation();
        }
    }
}