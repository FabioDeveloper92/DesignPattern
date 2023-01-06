using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class ItalyVATStrategy : IVATRuleStrategy
    {
        public decimal ApplyVAT(decimal price)
        {
            return price * 1.22M;
        }
    }
}
