using ChainOfResponsability.Handler;
using System;

namespace ChainOfResponsability.ConcreteHandler
{
    public class SpamMailHandler : MailHandler
    {
        public override void Check(int type)
        {
            if (type == 0)
                _mailHandler.Check(type);
            else
                Console.WriteLine("Manage by Spam Handler");
        }
    }
}
