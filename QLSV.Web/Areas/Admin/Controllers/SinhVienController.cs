using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Admin.Controllers
{
    [CustomAuthorize]
    public class SinhVienController : Controller
    {
        private readonly ISinhVienService _sinhVienService;

        public SinhVienController()
        {
            _sinhVienService = new SinhVienService();
        }
        // GET: Admin/SinhVien
        public ActionResult Index()
        {
            ViewBag.Menu = "Quản lý Sinh viên";
            ViewBag.MenuIcon = "fa-graduation-cap";
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult _LoginInfo()
        {
            var oldCookie = HttpContext.Request.Cookies["UserInfo"];
            if (oldCookie != null)
            {
                var loginString = HttpUtility.UrlDecode(oldCookie.Value);
                var loginModel = JsonConvert.DeserializeObject<LoginModel>(loginString);
                return PartialView(loginModel);
            }
            return PartialView();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}