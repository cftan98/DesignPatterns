using System;

namespace Adapter
{
    internal class Computer
    {
        private IAdapter adapter = new Adapter();

        public void ConnectToMonitor()
        {
            adapter.Handle(new Usb());
        }
    }
}
