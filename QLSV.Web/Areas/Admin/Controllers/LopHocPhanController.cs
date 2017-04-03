using System.Web.Mvc;
using QLSV.Services.Services;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Admin.Controllers
{
    [CustomAuthorize]
    public class LopHocPhanController : Controller
    {
        private readonly LopHocPhanService _lopHocPhanService = new LopHocPhanService();
        // GET: Admin/LopHocPhan
        public ActionResult Index()
        {
            ViewBag.Menu = "Quản lý Lớp học phần";
            ViewBag.MenuIcon = "fa-group";
            return View();
        }

        public ActionResult MonHoc()
        {
            ViewBag.Menu = "Quản lý Môn học";
            ViewBag.MenuIcon = "fa-book";
            return View();
        }

        public ActionResult DanhSach(int id)
        {
            ViewBag.Menu = "Danh sách sinh viên lớp học phần";
            ViewBag.MenuIcon = "fa-group";
            return View();
        }

        [HttpPost]
        public ActionResult AddSinhVien(int id, int[] keys)
        {
            if (_lopHocPhanService.AddSinhVienToLopHp(id, keys))
            {
                return Json("Ok", JsonRequestBehavior.AllowGet);
            }
            return Json("Fail", JsonRequestBehavior.AllowGet);
        }
    }
}