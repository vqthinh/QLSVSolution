using System.Web.Mvc;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Admin.Controllers
{
    [CustomAuthorize]
    public class GiaoVienController : Controller
    {
        // GET: Admin/GiaoVien
        public ActionResult Index()
        {
            ViewBag.Menu = "Quản lý Giáo viên";
            ViewBag.MenuIcon = "fa-user";
            return View();
        }
    }
}