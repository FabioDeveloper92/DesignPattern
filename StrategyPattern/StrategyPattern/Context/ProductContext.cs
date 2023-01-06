using StrategyPattern.Strategy;

namespace StrategyPattern.Context
{
    public class ProductContext
    {
        private readonly string _productName;
        private readonly decimal _price;
        private readonly IVATRuleStrategy _iVATRuleStrategy;

        public ProductContext(string productName, decimal price, IVATRuleStrategy iVATRuleStrategy)
        {
            _productName = productName;
            _price = price;
            _iVATRuleStrategy = iVATRuleStrategy;
        }

        public decimal GetSellPrice()
        {
            return _iVATRuleStrategy.ApplyVAT(_price);
        }
    }
}
