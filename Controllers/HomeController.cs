using BinaryMVC.Contracts;
using BinaryMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BinaryMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly iBinaryService _binaryService;

        public HomeController(ILogger<HomeController> logger, iBinaryService binaryService)
        {
            _logger = logger;
            _binaryService = binaryService;
        }

        
        public IActionResult Index(int? decimalNumber)
        {
            if (decimalNumber.HasValue)
            {
                ViewBag.DecimalNumber = decimalNumber.Value;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        [Route("/ConvertToDecimal")]
        public async Task<IActionResult> ConvertToDecimal([FromForm] int[] dynamicFields)
        {
            var decimalNumber = await _binaryService.BinaryToDecimal(dynamicFields);
            return Json(new { decimalNumber = decimalNumber });
        }



    }
}