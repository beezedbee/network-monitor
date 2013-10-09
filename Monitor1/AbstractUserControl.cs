using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Monitor1
{
    public abstract class AbstractUserControl : UserControl, IAbstractDevice
    {
        public abstract IPAddress IpAddress { get; set; }

        public abstract bool Monitored { get; set; }

        public abstract int FailureCount { get; set; }

        public abstract string HostName { get; set; }

        public abstract void CheckDeviceNow();
    }
}
