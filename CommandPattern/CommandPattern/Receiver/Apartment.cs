namespace CommandPattern.Receiver
{
    public class Apartment : IApartment
    {
        public void TurnOff()
        {
            Console.WriteLine("Turn OFF the light");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn ON the light");
        }
    }
}
