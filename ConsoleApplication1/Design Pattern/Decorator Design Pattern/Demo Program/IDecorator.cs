namespace ConsoleApplication1.Design_Pattern.Decorator_Design_Pattern.Demo_Program
{
    public abstract class IDecorator : IComponent
    {
        private IComponent _component;
        public IDecorator(IComponent component)
        {
            this._component = component;
        }

        public virtual void Build()
        {
            _component.Build();
        }
    }
}