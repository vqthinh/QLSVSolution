using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Areas.Gv.Controllers
{
    public class DiemDanhController : Controller
    {
        private readonly DiemDanhService _diemDanhService;
        private readonly LopHocPhanSinhVienService _lopHocPhanSinhVienService;
        private readonly LopHocPhanService _lopHocPhanService;

        public DiemDanhController()
        {
            _diemDanhService = new DiemDanhService();
            _lopHocPhanSinhVienService = new LopHocPhanSinhVienService();
            _lopHocPhanService = new LopHocPhanService();
        }

        // GET: Gv/DiemDanh
        public ActionResult DanhSach(int id)
        {
            var giaoVien = new TaiKhoan();
            var requestCookie = Request.Cookies["GiaoVienInfo"];
            if (requestCookie != null)
            {
                var cookieString = HttpUtility.UrlDecode(requestCookie.Value);
                giaoVien = JsonConvert.DeserializeObject<TaiKhoan>(cookieString);
            }
            var lopHocPhan =
                _lopHocPhanService.Where(x => x.Id == id && x.GiaoVienId == giaoVien.IdNguoiDung).FirstOrDefault();
            if (lopHocPhan != null)
            {
                ViewBag.Menu = "Điểm danh lớp " + lopHocPhan.Ten;
                ViewBag.MenuIcon = "fa-user";
                return View();
            }
                return RedirectToAction("Index", "GvHome");
        }

        [HttpPost]
        public ActionResult TaoDanhSach(int id, DateTime ngayDiemDanh)
        {
            var date = ngayDiemDanh.Date;
            var dsDiemDanh = _diemDanhService.Where(x => x.LopHocPhanId == id && x.NgayDiemDanh == date).ToList();
            var giaoVien = new TaiKhoan();
            var requestCookie = Request.Cookies["GiaoVienInfo"];
            if (requestCookie != null)
            {
                var cookieString = HttpUtility.UrlDecode(requestCookie.Value);
                giaoVien = JsonConvert.DeserializeObject<TaiKhoan>(cookieString);
            }
            if (dsDiemDanh.Count > 0)
            {
                return Json("Exist", JsonRequestBehavior.AllowGet);
            }
            var listSv = _lopHocPhanSinhVienService.Where(x => x.LopHocPhanId == id);
            foreach (var sv in listSv)
            {
                var diemDanh = new DiemDanh
                {
                    SinhVienId = sv.SinhVienId,
                    CoMat = false,
                    Deleted = false,
                    GiaoVienId = giaoVien.IdNguoiDung.GetValueOrDefault(),
                    LopHocPhanId = id,
                    NgayDiemDanh = ngayDiemDanh,
                    Phep = false
                };
                _diemDanhService.Add(diemDanh);
            }
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
    }
}