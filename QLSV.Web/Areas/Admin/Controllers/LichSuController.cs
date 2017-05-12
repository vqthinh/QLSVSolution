using System.Web.Mvc;

namespace QLSV.Web.Areas.Admin.Controllers
{
    public class LichSuController : Controller
    {
        // GET: Admin/LichSu
        public ActionResult Index()
        {
            ViewBag.Menu = "Lịch sử tác động";
            ViewBag.MenuIcon = "fa-graduation-cap";
            return View();
        }
    }
}