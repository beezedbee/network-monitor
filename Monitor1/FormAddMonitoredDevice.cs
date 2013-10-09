using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monitor1
{
    public partial class FormAddMonitoredDevice : Form
    {
        public FormAddMonitoredDevice()
        {
            InitializeComponent();

            comboBoxDeviceType.DisplayMember = "ToString";
            comboBoxDeviceType.ValueMember = "GetDeviceType";

            if (!DesignMode)
            {
                // discover all device types
                var type = typeof(DeviceGeneric);
                var executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                var deviceTypes = executingAssembly.GetTypes().Where(p => type.IsAssignableFrom(p));

                foreach (Type t in deviceTypes)
                {
                    comboBoxDeviceType.Items.Add(new DeviceReference(t));
                }
            }
        }

        public string SelectedDeviceType { get { return ((DeviceReference)comboBoxDeviceType.SelectedItem).GetDeviceType; } }

        public string SelectedDeviceName { get { return ((DeviceReference)comboBoxDeviceType.SelectedItem).ToString; } }

        public string Hostname { get { return textBoxHostname.Text; } }

        public string IPAddress { get { return textBoxIpAddress.Text; } }

        private void comboBoxDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pictureBoxDeviceType.Image = ((DeviceReference)comboBoxDeviceType.SelectedItem).GetImage;
        }
    }
}
