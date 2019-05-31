using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public abstract class Component
    {
        protected string Name { get; set; }

        protected Component(string name)
        {
            this.Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);

        public abstract void Display(int depth);
    }
    //叶
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("Cannot remove from a Leaf");
        }

        public override void Display(int depth)
        {

            Console.WriteLine($"{new string('-', depth)}{Name}");
        }

        public override void Add(Component component)
        {
            Console.WriteLine("Cannot add from a Leaf");
        }
    }

    //枝
    public class Composite : Component
    {
        public Composite(string name) : base(name)
        {
        }
        private List<Component> components = new List<Component>();

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine($"{new string('-', depth)}{Name}");

            foreach (var component in components)
            {
                component.Display(depth + 2);
            }
        }
    }
}
