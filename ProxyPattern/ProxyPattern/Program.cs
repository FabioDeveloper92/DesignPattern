using ProxyPattern.Proxy;

var myProxy = new InvoiceProxy("Red Company");

Console.WriteLine("Call first time");
myProxy.GetAllInvoices();

Console.WriteLine("");
Console.WriteLine("Call second time");
myProxy.GetAllInvoices();