using ProxyPattern.RealSubject;
using ProxyPattern.Subject;

namespace ProxyPattern.Proxy
{
    public class InvoiceProxy : IInvoice
    {
        private readonly RealInvoice _realInvoice;
        private string _invoicesLoaded;

        public InvoiceProxy(string companyName)
        {
            _realInvoice = new RealInvoice(companyName);
        }

        public string GetAllInvoices()
        {
            if (string.IsNullOrEmpty(_invoicesLoaded))
            {
                Console.WriteLine($"I'm loading all invoices of {_realInvoice.GetCompanyName()}");
                _invoicesLoaded = _realInvoice.GetAllInvoices();
            }

            Console.WriteLine($"I have invoices of {_realInvoice.GetCompanyName()}");
            return _invoicesLoaded;
        }
    }
}
