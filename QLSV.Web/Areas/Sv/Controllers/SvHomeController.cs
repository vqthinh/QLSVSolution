using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QLSV.Entities.Models;

namespace QLSV.Web.Areas.Sv.Controllers
{
    public class SvHomeController : Controller
    {
        // GET: Sv/SvHome
        public ActionResult Index()
        {
            ViewBag.Menu = "Danh sách lớp học phần của bạn";
            ViewBag.MenuIcon = "fa-group";
            var sinhVien = new TaiKhoan();
            var requestCookie = Request.Cookies["SinhVienInfo"];
            if (requestCookie != null)
            {
                var cookieString = HttpUtility.UrlDecode(requestCookie.Value);
                sinhVien = JsonConvert.DeserializeObject<TaiKhoan>(cookieString);
            }
            ViewBag.SinhVienId = sinhVien.IdNguoiDung;
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult _LoginInfo()
        {
            var oldCookie = HttpContext.Request.Cookies["SinhVienInfo"];
            if (oldCookie != null)
            {
                var loginString = HttpUtility.UrlDecode(oldCookie.Value);
                var loginModel = JsonConvert.DeserializeObject<LoginModel>(loginString);
                return PartialView(loginModel);
            }
            return PartialView();
        }
    }
}