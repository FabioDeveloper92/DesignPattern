using BridgePattern.Abstraction;
using BridgePattern.Implementator;
using System;

namespace BridgePattern.RefinedAbstraction
{
    public class PizzaWaiter : IWaiter
    {
        public IFood GetOrder(IFood food)
        {
            return food;
        }
    }
}
