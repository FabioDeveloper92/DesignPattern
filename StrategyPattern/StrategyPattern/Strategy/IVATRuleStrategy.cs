namespace StrategyPattern.Strategy
{
    public interface IVATRuleStrategy
    {
        public decimal ApplyVAT(decimal price);
    }
}
