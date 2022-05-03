using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client.Client();
            client.GetOrder();
        }
    }
}
