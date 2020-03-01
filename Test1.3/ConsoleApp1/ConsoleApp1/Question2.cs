using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Question2
    {
        public Question2()
        {

        }
        public static void Run()
        {
            Console.WriteLine("--- Start Question 2 ---");
            Composite a = new Composite(1);
            Composite b1 = new Composite(2);
            Composite b2 = new Composite(3);
            Composite b3 = new Composite(4);
            a.Add(b1);
            a.Add(b2);
            a.Add(b3);
            Leaf c1 = new Leaf(5);
            Leaf c2 = new Leaf(6);
            b1.Add(c1);
            b2.Add(c2);
            Console.WriteLine("Sum of tree a is: " + a.Sum());
            Console.WriteLine("Sum of sub tree b1 is: " + b1.Sum());
            Console.WriteLine("Sum of sub tree b2 is: " + b2.Sum());
            Console.WriteLine("Sum of sub tree b3 is: " + b3.Sum());
            Console.WriteLine("--- End Question 2 ---");
        }
        abstract class Component
        {
            protected int number;
            public Component(int number)
            {
                this.number = number;
            }
            public abstract void Add(Component c);
            public abstract void Remove(Component c);
            public abstract int Sum();
        }

        class Composite : Component

        {
            private List<Component> _children = new List<Component>();

            public Composite(int number) : base(number)
            {
            }

            public override void Add(Component component)
            {
                _children.Add(component);
            }

            public override void Remove(Component component)
            {
                _children.Remove(component);
            }

            public override int Sum()
            {
                int sum = number;
                foreach (Component component in _children)
                {
                    sum = sum + component.Sum();
                }
                return sum;
            }
        }
        class Leaf : Component
        {
            public Leaf(int number) : base(number)
            {
            }

            public override void Add(Component c)
            {
                Console.WriteLine("Cannot add to a leaf");
            }

            public override void Remove(Component c)
            {
                Console.WriteLine("Cannot remove from a leaf");
            }

            public override int Sum()
            {
                return number;
            }
        }
    }
}
