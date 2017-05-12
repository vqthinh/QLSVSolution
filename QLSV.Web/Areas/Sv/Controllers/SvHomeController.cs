using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Areas.Sv.Controllers
{
    public class SvHomeController : Controller
    {
        private readonly IGiayToService _giayToService;

        public SvHomeController()
        {
            _giayToService = new GiayToService();
        }
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

        public ActionResult YeuCauGiayTo()
        {
            ViewBag.Menu = "Yêu cầu giấy tờ";
            ViewBag.MenuIcon = "fa-graduation-cap";
            return View();
        }

        public ActionResult KetQuaDiemDanh()
        {
            ViewBag.Menu = "Kết quả điểm danh";
            ViewBag.MenuIcon = "fa-graduation-cap";
            return View();
        }

        [HttpPost]
        public ActionResult YeuCauGiayTo(int giayToId, string lyDo, int soLuong)
        {
            var sinhVien = new TaiKhoan();
            var requestCookie = Request.Cookies["SinhVienInfo"];
            if (requestCookie != null)
            {
                var cookieString = HttpUtility.UrlDecode(requestCookie.Value);
                sinhVien = JsonConvert.DeserializeObject<TaiKhoan>(cookieString);
            }
            var sinhVienGiayTo = new SinhVienGiayTo
           {
               SinhVienId = sinhVien.IdNguoiDung.GetValueOrDefault(),
               GiayToId = giayToId,
               LyDo = lyDo,
               Deleted = false,
               SoLuong = soLuong,
               NgayYeuCau = DateTime.Now,
               TinhTrang = "Đang chờ xác nhận"
           };
            _giayToService.YeuCauGiayTo(sinhVienGiayTo);
            return Json("Ok", JsonRequestBehavior.AllowGet);
        }
    }
}