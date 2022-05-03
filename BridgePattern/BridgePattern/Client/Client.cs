using BridgePattern.Abstraction;
using BridgePattern.ConcreteImplementor;
using BridgePattern.Implementator;
using BridgePattern.RefinedAbstraction;

namespace BridgePattern.Client
{
    public class Client
    {
        public void GetOrder()
        {
            IWaiter waiter = new PizzaWaiter();
            IFood food = waiter.GetOrder(new PizzaMargherita());
            food.WriteName();
        }
    }
}
