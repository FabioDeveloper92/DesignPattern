using AbstractFactory.AbstractProduct;

namespace AbstractFactory.ConcreteProduct
{
    public class AhaBrand : IBrand
    {
        public string GetName()
        {
            return "Aha";
        }
    }
}