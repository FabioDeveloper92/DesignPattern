using ChainOfResponsability.Handler;
using System;

namespace ChainOfResponsability.ConcreteHandler
{
    public class FriendMailHandler : MailHandler
    {
        public override void Check(int type)
        {
            if (type == 2)
                _mailHandler.Check(type);
            else
                Console.WriteLine("Manage by Friend Handler");
        }
    }
}
