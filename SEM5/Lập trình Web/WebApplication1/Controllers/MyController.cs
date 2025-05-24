using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            //gửi dữ liệu về view qua viewbag
            // viewbag là 1 vùng bộ nhwos chia sẻ giữa view và action 
            // Hoạt động như là 1 collection 
            ViewBag.Message = "Xin chào";
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = 100;
            return View();
        }
    }
}
