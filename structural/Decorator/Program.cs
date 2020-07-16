using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent component = new Component();
            component = new PreLoggerDecorator(component);
            
            component = new PostLoggerDecorator(component);
            
            
            component.PerformOperation();
            
     
            
        }
    }
}