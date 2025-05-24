using Microsoft.AspNetCore.Mvc;
using Test03.Models;

namespace Test03.ViewComponents
{
    public class LoaiHangViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            QlhangHoaContext db = new QlhangHoaContext();
            var loaihang = db.LoaiHangs.ToList();
            return View( loaihang);
        }
    }
}
