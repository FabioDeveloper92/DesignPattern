using AdapterPattern.Interface;
using System;

namespace AdapterPattern.Adaptee
{
    public class OldTv : IOldTv
    {
        public void Synchronize()
        {
            Console.WriteLine("Synchronize frequencies...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn On");
        }
    }
}
