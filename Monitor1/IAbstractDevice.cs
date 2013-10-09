using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Monitor1
{
    public interface IAbstractDevice
    {
        IPAddress IpAddress { get; set; }

        bool Monitored { get; set; }

        int FailureCount { get; set; }

        string HostName { get; set; }

        void CheckDeviceNow();
    }
}
