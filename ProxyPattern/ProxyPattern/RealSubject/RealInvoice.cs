using ProxyPattern.Subject;

namespace ProxyPattern.RealSubject
{
    public class RealInvoice : IInvoice
    {
        private readonly string _companyName;

        public RealInvoice(string companyName)
        {
            _companyName = companyName;
        }

        public string GetAllInvoices()
        {
            return $"I'm loaded 1GB of invoices of {_companyName}";

        }

        public string GetCompanyName()
        {
            return _companyName;
        }
    }
}
