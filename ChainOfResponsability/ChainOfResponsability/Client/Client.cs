using ChainOfResponsability.ConcreteHandler;

namespace ChainOfResponsability.Client
{
    public static class Client
    {
        public static void Execute(int type)
        {
            // Mail Handler
            var friendMailHandler = new FriendMailHandler();
            var billsMailHandler = new BillsMailHandler();
            var spamMailHandler = new SpamMailHandler();

            // Create the hierarchy 
            billsMailHandler.SetLevelAbove(friendMailHandler);
            spamMailHandler.SetLevelAbove(billsMailHandler);

            spamMailHandler.Check(type);
        }
    }
}
