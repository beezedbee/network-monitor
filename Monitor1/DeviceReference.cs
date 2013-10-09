using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Monitor1
{
    class DeviceReference
    {
        private Type t;

        public DeviceReference(Type t)
        {
            this.t = t;
        }

        public new string ToString
        {
            get
            {
                return t.GetField("DEVICE_TYPE").GetValue(null).ToString();
            }
        }

        public string GetDeviceType 
        { 
            get 
            { 
                return t.ToString(); 
            } 
        }

        public Image GetImage
        {
            get
            {
                return (Image)t.GetProperty("GetImage").GetValue(null, null);
            }
        }
    }
}
