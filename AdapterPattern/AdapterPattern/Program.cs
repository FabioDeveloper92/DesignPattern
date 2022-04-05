using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Work with old TV");
            var oldTv = new OldTv();

            var adapterOldTv = new OldTvAdapter(oldTv);
            adapterOldTv.TurnOn();
            adapterOldTv.UseDecoder();
            adapterOldTv.TurnOff();
        }
    }
}
