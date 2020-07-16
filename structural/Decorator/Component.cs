using System;

namespace Decorator
{
    public class Component : IComponent
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation performed");
        }

        public void PerformOperation2()
        {
            Console.WriteLine("Operation 2 performed");
        }
    }
}