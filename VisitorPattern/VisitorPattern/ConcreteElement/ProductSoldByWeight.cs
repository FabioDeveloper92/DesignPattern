using VisitorPattern.Visitor;
using VisitorPattern.Element;

namespace VisitorPattern.ConcreteElement
{
    public class ProductSoldByWeight : BaseProduct
    {
        public decimal Weight { get; set; }

        public override decimal Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
