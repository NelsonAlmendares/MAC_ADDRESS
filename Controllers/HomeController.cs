using MAC_ADDRESS.Models;
using MAC_ADDRESS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Management;

namespace MAC_ADDRESS.Controllers
{
    public class HomeController : Controller
    {
        private readonly MacAddressService _macAddressService;

        public HomeController(MacAddressService macAddressService)
        {
            _macAddressService = macAddressService;
        }

        public IActionResult Index()
        {
            var macAddress = _macAddressService.GetMacAddress();
            ViewBag.MacAddress = macAddress;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
