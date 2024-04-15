using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test04.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Test04.Controllers
{
    public class HomeController : Controller
    {
        NewShopContext db = new NewShopContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //public IActionResult HangHoaTheoLoai(int? maloaihang)
        //{

        //    if (maloaihang == null)
        //    {
        //        var hanghoa = db.Providers.ToList();
        //        return PartialView("HangHoa", hanghoa);
        //    }
        //    else
        //    {
        //        var hanghoa = db.Providers.Where(p => p.Id == maloaihang).ToList();
        //        return PartialView("HangHoa", hanghoa);
        //    }
        //}

        public IActionResult Index()
        {
            //var hanghoa = db.Providers.OrderByDescending(p => p.Id == maloaihang).Take(6).ToList();
            //return PartialView("HangHoa", hanghoa);

             return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // EDIT
        public IActionResult Edit(string id, [Bind("Id", "Name", "UnitPrice", "Image")] Product sp)
        {
            sp.Id = id;
            if (id != sp.Id)
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
                    if (!ProductExits(sp.CategoryId))
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
            ViewBag.MaLoai = new SelectList(db.Categories, "Id", "Name");
            return View(sp);
           
        }
      
        // FINDING

        public IActionResult tk(string keyword)
        {
            var hanghoa = db.Categories.Where(l => l.Name.ToLower().Contains(keyword.ToLower()));

            return PartialView("HangHoa", hanghoa);
        } 
        private bool ProductExits(int msp)
        {
            return (db.Categories?.Any(e => e.Id == msp)).GetValueOrDefault();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
