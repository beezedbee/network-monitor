using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace Monitor1
{
    public partial class DeviceSwitch : DeviceGeneric, IAbstractDevice
    {
        public new static string DEVICE_TYPE = "Switch";
        public static Image GetImage { get { return Monitor1.Properties.Resources._switch; } }

        public DeviceSwitch()
        {
            InitializeComponent();

            this.MouseDown += base.DeviceGeneric_MouseDown;
            this.MouseUp += base.DeviceGeneric_MouseUp;
            this.MouseMove += base.DeviceGeneric_MouseMove;

            base.SubscribeToPingCompletedEvent(icmpPing_PingCompleted);
        }

        public override void CheckDeviceNow()
        {
            base.CheckDeviceNow();
        }

        protected new static void icmpPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                // todo: further switch-specific checks
            }
        }
    }
}
