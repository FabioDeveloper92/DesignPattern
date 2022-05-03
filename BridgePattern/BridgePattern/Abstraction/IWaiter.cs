using BridgePattern.Implementator;

namespace BridgePattern.Abstraction
{
    public interface IWaiter
    {
        public IFood GetOrder(IFood food);
    }
}
