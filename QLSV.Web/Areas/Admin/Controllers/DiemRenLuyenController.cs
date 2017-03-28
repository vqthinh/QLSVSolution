using System.Web.Mvc;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Admin.Controllers
{
    [CustomAuthorize]
    public class DiemRenLuyenController : Controller
    {
        // GET: Admin/DiemRenLuyen
        public ActionResult Index()
        {
            ViewBag.Menu = "Quản Lý Điểm rèn luyện";
            ViewBag.MenuIcon = "fa-star";
            return View();
        }
    }
}