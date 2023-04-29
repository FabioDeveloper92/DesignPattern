using VisitorPattern.Visitor;
using VisitorPattern.Element;

namespace VisitorPattern.ConcreteElement
{
    public class ProductSoldByQuantity : BaseProduct
    {
        public int Quantity { get; set; }

        public override decimal Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
