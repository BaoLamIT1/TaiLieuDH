using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test02.Models;
using Test02.Models.Entities;

namespace Test02.Controllers
{
	public class HomeController : Controller
	{
		QLHangHoaContext db = new QLHangHoaContext();

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
            
            var hanghoa = db.HangHoas.Where(p => p.Gia >= 100).ToList();
            return View(hanghoa);
        }
        public IActionResult HangHoaTheoLoai(int? maloaihang)
        {
           
            var hanghoa = db.HangHoas.Where(p => p.MaLoai == maloaihang).ToList();
            return PartialView("MatHang", hanghoa);
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