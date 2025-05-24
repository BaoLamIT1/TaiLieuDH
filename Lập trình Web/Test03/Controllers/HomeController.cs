using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Test03.Models;

namespace Test03.Controllers
{
	public class HomeController : Controller
	{
		QlhangHoaContext db = new QlhangHoaContext();

		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}
		public IActionResult HangHoaTheoLoai(int? maloaihang)
		{

            if (maloaihang == null)
            {
                var hanghoa = db.HangHoas.ToList();
                return PartialView("HangHoa", hanghoa);
            }
            else
            {
                var hanghoa = db.HangHoas.Where(p => p.MaLoai == maloaihang).ToList();
                return PartialView("HangHoa", hanghoa);
            }
        }
        // Loc SP co GIA > = 100 
		public IActionResult Index()
		{
             //var hanghoa = db.HangHoas.OrderBy(p => p.Gia).Take(4).ToList();  LOAD top 4 san pham co gia thap nhat tang dan
             //var hanghoa = db.HangHoas.OrderByDescending(p =>p.Gia).Take(3).ToList(); LOAD top 3 có giá cao nhất giảm dần
             // var products = db.Products.Where(p => p.Available == true && p => p.Gia >= 100 ).ToList();  LOAD sp  có available = true và UnitPrice <=1000
            var hanghoa = db.HangHoas.Where(p => p.Gia >= 100).ToList();
			return View(hanghoa);
		}

		public IActionResult Privacy()
		{
			return View();
		}
		// CREATE 
		public IActionResult Create()
		{

			ViewBag.MaLoai = new SelectList(db.LoaiHangs, "MaLoai", "TenLoai");
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("MaLoai", "TenHang", "Gia", "Anh")] HangHoa hanghoa)
		{

			if (ModelState.IsValid)
			{
				db.Add(hanghoa);
				await db.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			ViewBag.MaLoai = new SelectList(db.LoaiHangs, "MaLoai", "TenLoai");
			return View();
		}

        // DELETE
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || db.HangHoas == null)
            {
                return NotFound();
            }
            var product = await db.HangHoas.Include(l => l.MaLoaiNavigation).FirstOrDefaultAsync();
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (db.HangHoas == null)
            {
                return Problem("Entity set 'Learners' is null");
            }
            var product = db.HangHoas.Find(id);
            if (product != null)
            {
                db.HangHoas.Remove(product);
            }
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        // EDIT
        public IActionResult Edit(int id, [Bind("MaLoai", "TenHang", "Gia", "Anh")] HangHoa sp)
        {
            sp.MaHang = id;
            if (id != sp.MaHang)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(sp);
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExits(sp.MaHang))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.MaLoai = new SelectList(db.LoaiHangs, "MaLoai", "TenLoai");
            return View(sp);

        }
		// FINDING

		public IActionResult tk(string keyword)
		{
			var hanghoa = db.HangHoas.Where(l => l.TenHang.ToLower().Contains(keyword.ToLower()));

			return PartialView("HangHoa", hanghoa);
		}



        private bool ProductExits(int msp)
        {
            return (db.HangHoas?.Any(e => e.MaHang == msp)).GetValueOrDefault();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
