using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.IO;

namespace Monitor1
{
    public partial class Form1 : Form
    {
        private FormAddMonitoredDevice frmAddDevice;
        private XDocument xdoc;
        private XmlSchemaSet schemaSet;

        public Form1()
        {
            InitializeComponent();

            frmAddDevice = new FormAddMonitoredDevice();

            schemaSet = new XmlSchemaSet();
            StringReader reader = new StringReader(Monitor1.Properties.Resources.ConfigurationSchema);
            XmlSchema schema = XmlSchema.Read(reader, null);
            schemaSet.Add(schema);
        }

        private void refreshNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelMonitorView.Controls)
            {
                Type t = c.GetType();

                if (t == typeof(DeviceGeneric) || t.BaseType ==  typeof(DeviceGeneric))
                {
                    IAbstractDevice device = c as IAbstractDevice;

                    device.CheckDeviceNow();
                }
            }
        }

        private void addMonitoredDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = frmAddDevice.ShowDialog();

            if (res == System.Windows.Forms.DialogResult.OK)
            {
               switch (frmAddDevice.SelectedDeviceType)
                {

                    case "Monitor1.DeviceGeneric":
                        DeviceGeneric d1 = new DeviceGeneric();
                        d1.HostName = frmAddDevice.Hostname;
                        try
                        {
                            d1.IpAddress = System.Net.IPAddress.Parse(frmAddDevice.IPAddress);
                        }
                        catch (FormatException ex)
                        {
                            d1.IpAddress = System.Net.IPAddress.Parse("0.0.0.0");
                        }

                        panelMonitorView.Controls.Add(d1);
                        break;

                    case "Monitor1.DeviceRouter":
                        DeviceRouter d2 = new DeviceRouter();
                        d2.HostName = frmAddDevice.Hostname;
                        try
                        {
                            d2.IpAddress = System.Net.IPAddress.Parse(frmAddDevice.IPAddress);
                        }
                        catch (FormatException ex)
                        {
                            d2.IpAddress = System.Net.IPAddress.Parse("0.0.0.0");
                        }

                        panelMonitorView.Controls.Add(d2);
                        break;

                    case "Monitor1.DeviceSwitch":
                        DeviceSwitch d3 = new DeviceSwitch();
                        d3.HostName = frmAddDevice.Hostname;
                        try
                        {
                            d3.IpAddress = System.Net.IPAddress.Parse(frmAddDevice.IPAddress);
                        }
                        catch (FormatException ex)
                        {
                            d3.IpAddress = System.Net.IPAddress.Parse("0.0.0.0");
                        }

                        panelMonitorView.Controls.Add(d3);
                        break;

                    default:
                        break;

                }

                panelMonitorView.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit
        }

        private void loadDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void debugLoadSampleConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {

            xdoc = XDocument.Parse(Monitor1.Properties.Resources.SampleConfiguration);

            bool documentPassedValidation = true;
            xdoc.Validate(schemaSet, (o, ex) =>
                {
                    documentPassedValidation = true;
                });

            if (documentPassedValidation)
            {
                var allSites = from site in xdoc.Root.Elements("site")
                               select site;
 
                var allDevices = from device in allSites.Elements("device")
                                    select new
                                    {
                                        id = (int)device.Element("id"),
                                        name = (string)device.Element("name"),
                                        type = (string)device.Element("type"),
                                        ipaddress = (string)device.Element("ipaddress"),
                                        x = (int)device.Element("x"),
                                        y = (int)device.Element("y")
                                    };
                foreach (var _device in allDevices)
                {
                    Type t = Type.GetType(_device.type);
                    AbstractUserControl c = (AbstractUserControl)Activator.CreateInstance(t);

                    c.HostName = _device.name;
                    try
                    {
                        c.IpAddress = System.Net.IPAddress.Parse(_device.ipaddress);
                    }
                    catch (FormatException ex)
                    {
                        c.IpAddress = System.Net.IPAddress.Parse("0.0.0.0");
                    }

                    c.Left = _device.x;
                    c.Top = _device.y;
                    panelMonitorView.Controls.Add(c);
                }

                panelMonitorView.Show();
            }
        }
    }
}
