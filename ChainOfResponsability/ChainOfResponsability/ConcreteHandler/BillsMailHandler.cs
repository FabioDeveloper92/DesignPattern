using ChainOfResponsability.Handler;
using System;

namespace ChainOfResponsability.ConcreteHandler
{
    public class BillsMailHandler : MailHandler
    {
        public override void Check(int type)
        {
            if (type == 2)
                _mailHandler.Check(type);
            else
                Console.WriteLine("Manage by Bills Handler");
        }
    }
}
