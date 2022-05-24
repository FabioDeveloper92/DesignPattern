namespace ChainOfResponsability.Handler
{
    public abstract class MailHandler
    {
        public MailHandler _mailHandler;

        public void SetLevelAbove(MailHandler mailHandler)
        {
            _mailHandler = mailHandler;
        }

        public abstract void Check(int type);
    }
}
