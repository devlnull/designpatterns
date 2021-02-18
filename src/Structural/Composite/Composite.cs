using System.Collections.Generic;
using System.Text;

namespace Structural.Composite
{
    public class Composite : Component
    {
        public List<Component> Children { get; }
        public Composite(string name) : base(name)
        {
            Children = new List<Component>();
        }

        public void Add(Component component)
        {
            Children.Add(component);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            foreach(var child in Children)
                strBuilder.AppendLine(new string('-', 2) + child.Name);
            
            return strBuilder.ToString();
        }

        public void Remove(Component component)
        {
            Children.Remove(component);
        }
    }
}
