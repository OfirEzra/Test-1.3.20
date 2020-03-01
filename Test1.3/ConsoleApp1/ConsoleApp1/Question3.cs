using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Question3
    {
        public Question3()
        {

        }
        public static void Run()
        {
            Console.WriteLine("--- Start Question 3 ---");
            CarControl methods = new CarControl();
            Console.WriteLine(methods.Gas());
            Console.WriteLine(methods.Location());
            IProxyMethod proxy = new CarProxy();
            Console.WriteLine(proxy.Gas());
            Console.WriteLine(proxy.Location());
            Console.WriteLine("--- End Question 3 ---");
        }
        interface IInstanceMethods
        {
            void StartRide();
            void EndRide();
            void SpeedUp();
            void Slowdown();
            void TurnLeft();
            void TurnRight();
        }
        interface IProxyMethod
        {
            string Gas();
            string Location();
        }
        class CarControl : IInstanceMethods, IProxyMethod
        {
            public CarControl()
            {

            }
            public void EndRide()
            {
                throw new NotImplementedException();
            }

            public string Gas()
            {
                return "Gas Tank is either empty or full - Original";
            }

            public string Location()
            {
                return "The car is somewhere - Original";
            }

            public void Slowdown()
            {
                throw new NotImplementedException();
            }

            public void SpeedUp()
            {
                throw new NotImplementedException();
            }

            public void StartRide()
            {
                throw new NotImplementedException();
            }

            public void TurnLeft()
            {
                throw new NotImplementedException();
            }

            public void TurnRight()
            {
                throw new NotImplementedException();
            }
        }
        class CarProxy : IProxyMethod
        {
            IProxyMethod proxy = new CarControl();
            public CarProxy()
            {

            }
            public string Gas()
            {
                return proxy.Gas() + " from proxy";
            }

            public string Location()
            {
                return proxy.Location() + " from proxy";
            }
        }
    }
}
