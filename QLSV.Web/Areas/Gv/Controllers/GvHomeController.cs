using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QLSV.Entities.Models;
using QLSV.Services.Services;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Gv.Controllers
{
    [GiaoVienAuthorize]
    public class GvHomeController : Controller
    {
        private readonly LopHocPhanService _lopHocPhanService = new LopHocPhanService();
        // GET: Gv/GvHome
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult _LoginInfo()
        {
            var oldCookie = HttpContext.Request.Cookies["GiaoVienInfo"];
            if (oldCookie != null)
            {
                var loginString = HttpUtility.UrlDecode(oldCookie.Value);
                var loginModel = JsonConvert.DeserializeObject<LoginModel>(loginString);
                return PartialView(loginModel);
            }
            return PartialView();
        }

        public ActionResult DanhSach(int id)
        {
            var lopHp = _lopHocPhanService.GetById(id);
            ViewBag.Menu = "Danh sách sinh viên lớp " + lopHp.Ten;
            ViewBag.MenuIcon = "fa-group";
            return View();
        }
    }
}