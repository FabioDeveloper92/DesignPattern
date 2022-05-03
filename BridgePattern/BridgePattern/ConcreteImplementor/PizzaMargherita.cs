using BridgePattern.Implementator;
using System;

namespace BridgePattern.ConcreteImplementor
{
    public class PizzaMargherita : IFood
    {
        public IFood GetFood()
        {
            return this;
        }
        public void WriteName()
        {
            Console.WriteLine("Pizza Margherita");
        }
    }
}
