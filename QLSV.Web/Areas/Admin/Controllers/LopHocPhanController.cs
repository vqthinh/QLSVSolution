using System.Web.Mvc;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Admin.Controllers
{
    [CustomAuthorize]
    public class LopHocPhanController : Controller
    {
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
            ViewBag.Menu = "Quản lý Môn học";
            ViewBag.MenuIcon = "fa-book";
            return View();
        }
    }
}