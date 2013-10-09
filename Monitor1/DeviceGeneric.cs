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
    public partial class DeviceGeneric : AbstractUserControl, IAbstractDevice
    {
        public static string DEVICE_TYPE = "Generic device";
        public static Image GetImage { get { return Monitor1.Properties.Resources.generic; } }

        protected bool beingDragged = false;
        protected int mouseX = -1;
        protected int mouseY = -1;

        //protected string hostname;
        protected IPAddress ipAddr;
        protected bool isMonitored = false;

        protected Ping icmpPing = null;
        protected Int32 icmpTimeout = 500;

        protected PingReply icmpLastResult = null;

        protected int failureCount = 0;


        public DeviceGeneric()
        {
            InitializeComponent();

            this.icmpPing = new Ping();
            this.icmpPing.PingCompleted += new PingCompletedEventHandler(icmpPing_PingCompleted);
        }

        protected void SubscribeToPingCompletedEvent(PingCompletedEventHandler eventHandler)
        {
            this.icmpPing.PingCompleted += eventHandler;
        }

        public override IPAddress IpAddress
        {
            get
            {
                return this.ipAddr;
            }
            set
            {
                this.ipAddr = value;
            }
        }

        public override bool Monitored
        {
            get
            {
                return this.isMonitored;
            }
            set
            {
                this.isMonitored = value;
            }
        }

        public override int FailureCount { get { return failureCount; } set { failureCount = value; } }

        public override string HostName { get { return this.labelHostname.Text; } set { this.labelHostname.Text = value; } }

        protected void DeviceGeneric_MouseDown(object sender, MouseEventArgs e)
        {
            this.beingDragged = true;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        protected void DeviceGeneric_MouseUp(object sender, MouseEventArgs e)
        {
            this.beingDragged = false;
        }

        protected void DeviceGeneric_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.beingDragged)
            {
                this.Left += e.X - this.mouseX;
                this.Top += e.Y - this.mouseY;
            }
        }

        protected static void icmpPing_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            DeviceGeneric caller = e.UserState as DeviceGeneric;

            caller.icmpLastResult = e.Reply;

            if (e.Error == null && e.Reply.Status == IPStatus.Success)
            {
                caller.failureCount = 0;
            }
            else
            {
                caller.failureCount++;
            }

            switch (caller.failureCount)
            {
                case 0:
                    caller.BackColor = Color.LimeGreen;
                    break;

                case 1:
                    caller.BackColor = Color.DarkGreen;
                    break;

                case 2:
                    caller.BackColor = Color.Yellow;
                    break;

                case 3:
                    caller.BackColor = Color.Orange;
                    break;

                default:
                    caller.BackColor = Color.Red;
                    break;
            }
        }

        public override void CheckDeviceNow()
        {
            this.icmpPing.SendAsync(this.ipAddr, this.icmpTimeout, this);
        }

        private void refreshNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CheckDeviceNow();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
