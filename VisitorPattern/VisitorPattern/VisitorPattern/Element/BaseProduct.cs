using VisitorPattern.Visitor;

namespace VisitorPattern.Element
{
    public abstract class BaseProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public abstract decimal Accept(IVisitor visitor);
    }
}
