using VisitorPattern.ConcreteElement;
using VisitorPattern.Visitor;

namespace VisitorPattern.ConcreteVisitor
{
    public class ShoppingVisitor : IVisitor
    {
        public string Name { get;set;}
        public decimal Visit(ProductSoldByQuantity product)
        {
            return product.Price * product.Quantity;
        }

        public decimal Visit(ProductSoldByWeight product)
        {
            return decimal.Round(product.Price * product.Weight, 2);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
