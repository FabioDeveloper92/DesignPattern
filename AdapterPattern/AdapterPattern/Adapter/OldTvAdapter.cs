using AdapterPattern.Interface;
using System;

namespace AdapterPattern.Adapter
{
    public class OldTvAdapter : INewTv
    {
        private readonly IOldTv _oldTv;
        public OldTvAdapter(IOldTv oldTv)
        {
            _oldTv = oldTv;
        }

        public void UseDecoder()
        {
            Console.WriteLine("Connect to Decoder");
            _oldTv.Synchronize();
        }

        public void TurnOff()
        {
            _oldTv.TurnOff();
        }

        public void TurnOn()
        {
            _oldTv.TurnOn();
        }
    }
}
