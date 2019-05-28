namespace Structural.Decorator
{
    public class Decorator : IComponent
    {
        private IComponent _component;
        public void SetComponent(IComponent component) => this._component = component;

        public virtual void Operate()
        {
            if (_component != null)
                this._component.Operate();
        }
    }
}
