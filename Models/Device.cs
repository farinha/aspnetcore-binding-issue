using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class DeviceList
    {
        public List<Device> Devices { get; set; }
    }

    public abstract class Device
    {
        public string Kind { get; set; }
    }

    public class Laptop : Device
    {
        public string CPUIndex { get; set; }
    }

    public class SmartPhone : Device
    {
        public string ScreenSize { get; set; }
    }
}
