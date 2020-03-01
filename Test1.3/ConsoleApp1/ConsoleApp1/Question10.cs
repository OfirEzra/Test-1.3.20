using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Question10
    {
        public Question10()
        {

        }
        public static void Run()
        {
            Console.WriteLine("--- Start Question 10 ---");
            Window window = new Window();
            Decorator decorator1 = new ThreeDLight();
            Decorator decorator2 = new Shading();
            Decorator decorator3 = new ColorfulFrame();
            decorator1.SetComponent(window);
            Console.WriteLine(decorator1.Operation());
            decorator2.SetComponent(decorator1);
            Console.WriteLine(decorator2.Operation());
            decorator3.SetComponent(decorator2);
            Console.WriteLine(decorator3.Operation());
            Console.WriteLine("--- End Question 10 ---");
        }
        abstract class Component

        {
            public abstract string Operation();
        }

        class Window : Component

        {
            public override string Operation()
            {
                return "Window";
            }
        }
        abstract class Decorator : Component

        {
            protected Component component;

            public void SetComponent(Component component)
            {
                this.component = component;
            }

            public override string Operation()
            {
                if (component != null)
                {
                    return component.Operation();
                }
                return "";
            }
        }
        class ThreeDLight : Decorator
        {
            public override string Operation()
            {
                return base.Operation() + ", 3D Light";
            }
        }
        class Shading : Decorator
        {
            public override string Operation()
            {
                return base.Operation() + ", Shading";
            }
        }
        class ColorfulFrame : Decorator
        {
            public override string Operation()
            {
                return base.Operation() + ", Colorful Frame";
            }
        }

        //And more types of decorators....
    }
}
