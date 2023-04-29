using VisitorPattern.ConcreteElement;

namespace VisitorPattern.Visitor
{
    public interface IVisitor
    {
        public decimal Visit(ProductSoldByQuantity product);
        public decimal Visit(ProductSoldByWeight product);
        public string GetName();
    }
}
