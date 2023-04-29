using VisitorPattern.Element;
using VisitorPattern.Visitor;

namespace VisitorPattern.ObjectStructure
{
    public class Cart
    {
        private string _customerName { get; set; }
        private List<BaseProduct> _products { get; set; }

        public Cart(string customerName)
        {
            _products = new List<BaseProduct>();
            _customerName = customerName;
        }

        public void AddProduct(BaseProduct product)
        {
            _products.Add(product);
        }
        public void RemoveProduct(BaseProduct product)
        {
            _products = _products.Where(p => p.Name.Equals(product)).ToList();
        }

        public void PrintTotalPrice(IVisitor visitor)
        {
            var total = 0M;

            foreach (var product in _products)
                total += product.Accept(visitor);

            Console.WriteLine($"{visitor.GetName()} say: your total {_customerName} is {total} $.");
        }
    }
}
