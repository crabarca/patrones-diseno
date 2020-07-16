using System.IO;

namespace Decorator
{
    public abstract class AbstractDecorator : IComponent
    {
        private IComponent _component;

        protected AbstractDecorator(IComponent component)
        {
            _component = component;
        }

        public virtual void PerformOperation()
        {
            _component.PerformOperation();
        }

        public void PerformOperation2()
        {
            _component.PerformOperation2();
        }
    }
}