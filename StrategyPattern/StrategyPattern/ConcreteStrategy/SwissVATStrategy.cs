using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteStrategy
{
    public class SwissVATStrategy : IVATRuleStrategy
    {
        public decimal ApplyVAT(decimal price)
        {
            return price * 1.077M;
        }
    }
}
