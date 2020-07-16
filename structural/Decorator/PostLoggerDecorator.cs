using System;

namespace Decorator
{
    public class PostLoggerDecorator : AbstractDecorator
    {
        public PostLoggerDecorator(IComponent component) : base(component)
        {

        }

        public override void PerformOperation()
        {
            base.PerformOperation();
            Console.WriteLine("Operation has been performed.");
        }
    }
}