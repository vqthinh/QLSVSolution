using System;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;
using QLSV.Web.Models;

namespace QLSV.Web.Areas.Gv.Controllers
{
    [GiaoVienAuthorize]
    public class GvHomeController : Controller
    {
        private readonly ILopHocPhanService _lopHocPhanService = new LopHocPhanService();
        private readonly ILopHocPhanSinhVienService _lopHocPhanSinhVienService = new LopHocPhanSinhVienService();
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
            ViewBag.LopHocPhanId = id;
            return View();
        }

        [HttpPost]
        public ActionResult XetDiemChuyenCan(int id)
        {
            try
            {
                _lopHocPhanSinhVienService.XetDiemChuyenCan(id);
                return Json("Ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json("Fail", JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult XepLoai(int id)
        {
            try
            {
                _lopHocPhanSinhVienService.XepLoai(id);
                return Json("Ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                return Json("Fail", JsonRequestBehavior.AllowGet);
            }
        }
    }
}