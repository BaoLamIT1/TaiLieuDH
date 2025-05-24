using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Test02.Models.Entities;
namespace Test02.ViewComponents
{
	public class LoaiHangViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			QLHangHoaContext db = new QLHangHoaContext();
			var loaihang = db.LoaiHangs.ToList();
			return View(loaihang);
		}
	}
}
