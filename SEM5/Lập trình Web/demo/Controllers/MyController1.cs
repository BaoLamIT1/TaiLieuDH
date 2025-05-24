using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace demo.Controllers
{
    // Cả Controller cần có MyRoute để truy cập MyAction/Add
    [Route("MyRoute")]
    public class MyController1 : Controller
    {
        //ViewBag là 1 vùng bộ nhớ chia sẻ giữa view và action 
        public IActionResult Index(int? id, String message, int page)
        {
            if (id != null)
            ViewBag.Id = id;
            ViewBag.Message = message;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = page;
            Message m = new Message(message,page);

            //ViewBag.Page = 100;
            // /Index?Message=XinChao&page=105
            return View(m);
        }
        // [Route("MyAction/Add")]  // C1 này để định dạng mẫu URL để gọi phương thức 
        //C2:  Ghép 2 attribute làm 1 thay vì khai báo 2 attribute 
        [HttpGet("MyAction/Get")]
        public IActionResult Add() 
        { return View(); }

        [HttpPost("MyAction/Add")]   // đi với C1
        /*
        public IActionResult Add(String message, int page)
        {
            ViewBag.Message = message;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = page;
            return View("MyView");
        }*/
         public IActionResult Add(Message m)
        {
           ViewBag.Message = m.msg;
            ViewBag.Date = DateTime.Now;
            ViewBag.Page = m.pgnum;
            return View("MyView");
        }

        //[HttpPost]

    }
}
