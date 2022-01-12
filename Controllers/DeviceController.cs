using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Controllers
{
    public class DeviceController : Controller
    {
        public ActionResult Index()
        {
            var deviceList = new DeviceList
            {
                Devices = new List<Device>
                {
                    new Laptop { Kind = "Laptop", CPUIndex = "CPU-Index" },
                    new SmartPhone { Kind = "SmartPhone", ScreenSize = "Screen Size" }
                }
            };

            return View(deviceList);
        }

        [HttpPost]
        public ActionResult Index(DeviceList deviceList)
        {
            return RedirectToAction("Index");
        }
    }
}
