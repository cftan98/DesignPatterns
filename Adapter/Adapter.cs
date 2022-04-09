using System;

namespace Adapter
{
    internal class Adapter : IAdapter
    {
        public void Handle( Usb usb )
        {
            usb.Connect();
        }
    }
}
