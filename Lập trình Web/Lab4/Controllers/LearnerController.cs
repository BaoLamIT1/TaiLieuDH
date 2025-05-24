using Lab4.Data;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Controllers
{
    public class LearnerController : Controller
    {

        private SchoolContext db;
        public LearnerController(SchoolContext context)
        {
            db = context;
        }
        //public IActionResult Index() -- lab4

        //Action Index Lab 5
        //public IActionResult Index(int? mid) // Chuc nang loc du lieu 
        //{
        //    if (mid == null)
        //    {
        //        var learners = db.Learners.Include(m => m.Major).ToList();
        //        return View(learners);
        //    }
        //    else
        //    {
        //        var learners = db.Learners.Where(l => l.MajorID == mid).Include(m => m.Major).ToList();
        //        return View(learners);
        //    }

        //}

        // Action Index Lab 6
        private int pageSize = 3;
        public IActionResult Index( int? mid )
        {
            var learners = (IQueryable<Learner>)db.Learners.Include(m => m.Major);
            if ( mid != null)
            {
                learners = (IQueryable<Learner>)db.Learners.Where(l => l.MajorID == mid).Include(m => m.Major);
            }
            // tinh so trang
            int pageNum = (int)Math.Ceiling(learners.Count() / (float)pageSize);
            // tra ve so trang ve view de hien thi nav-trang
            ViewBag.pageNum = pageNum;
            //lay du lieu trang dau
            var result = learners.Take(pageSize).ToList();
            return View(result);
        }

        public IActionResult LearnerFilter(int? mid , string? keyword , int? pageIndex)
        {
            //lấy toàn bộ learners trong dbset chuyển về IQueryable<Learner> để query 
            var learners = (IQueryable<Learner>)db.Learners;
            //lấy chỉ số trang , nếu chỉ số trang null thì gàn ngầm định băng 1
            int page = (int)(pageIndex == null || pageIndex <= 0 ? 1 : pageIndex);
            //nếu có mid thì lọc learner theo mid
            if ( mid != null)
            {
                // lọc
                learners = learners.Where(l=>l.MajorID == mid);
                //gửi mid vể view để ghi lại trên nav- phân trang
                ViewBag.mid = mid;
            }
            // nếu có keyword thì tìm kiếm theo tên
            if (keyword != null)
            {
                // tìm kiếm
                learners = learners.Where(l => l.FirstMidName.ToLower().Contains(keyword.ToLower()));
                // gửi keyword về view để ghi trên nav- phân trang
                ViewBag.keyword = keyword;
            }
            //tính số trang
            int pageNum = (int)Math.Ceiling(learners.Count() / (float)pageSize);
            // gửi số trang
            ViewBag.pageNum = pageNum;
            // chọn dữ liệu trong trang hiện tại
            var result = learners.Skip(pageSize * (page - 1)).Take(pageSize).Include(m => m.Major);
            return PartialView("LearnerTable", result);
        }

        //Lab 5 dùng AJAX
        public IActionResult LearnerByMajorID(int mid)
        {
            var learners= db.Learners.Where(l=>l.MajorID==mid)
                .Include(m=>m.Major).ToList();
            return PartialView("LearnerTable", learners);
        }
        //End
        public IActionResult Create()
        {
            //dùng 1 trong 2 cách để tạo SelectList gửi về View qua ViewBag để
            //hiển thị danh sách chuyên ngành (Majors)
            var majors = new List<SelectListItem>(); //cách 1
            foreach (var item in db.Majors)
            {
                majors.Add(new SelectListItem
                {
                    Text = item.MajorName,

                    Value = item.MajorID.ToString()
                });

            }
            ViewBag.MajorID = majors;
            ViewBag.MajorID = new SelectList(db.Majors, "MajorID", "MajorName"); //cách 2
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FirstMidName,LastName,MajorID,EnrollmentDate")]
        Learner learner)
        {
            if (ModelState.IsValid)
            {
                db.Learners.Add(learner);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            //lại dùng 1 trong 2 cách tạo SelectList gửi về View để hiển thị danh sách Majors
            ViewBag.MajorID = new SelectList(db.Majors, "MajorID", "MajorName");
            return View();
        }
        //edit
        public IActionResult Edit(int id)
        {
            var learners = db.Learners.Find(id);
            if (learners == null)
            {
                return NotFound();
            }

            // Tạo SelectList để hiển thị danh sách chuyên ngành (Majors)
            var majors = new SelectList(db.Majors, "MajorID", "MajorName");
            ViewBag.MajorID = majors;

            return View(learners);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("LearnerID,FirstMidName,LastName,MajorID,EnrollmentDate")] Learner learners)
        {
            if (id != learners.LearnerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                db.Update(learners);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            // Tạo SelectList để hiển thị danh sách Majors
            ViewBag.MajorID = new SelectList(db.Majors, "MajorID", "MajorName");
            return View(learners);
        }

        // Delete
        public IActionResult Delete(int id)
        {
            var learners = db.Learners.Find(id);
            if (learners == null)
            {
                return NotFound();
            }
            ViewBag.MajorID = new SelectList(db.Majors, "MajorID", "MajorName");
            return View(learners);

        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var learner = db.Learners.Find(id);
            if (learner == null)
            {
                return NotFound();
            }

            db.Learners.Remove(learner);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
