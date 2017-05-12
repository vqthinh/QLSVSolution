using System.Web.Mvc;
using QLSV.Abstract.Services;
using QLSV.Services.Services;

namespace QLSV.Web.Areas.Admin.Controllers
{
    public class QlGiayToController : Controller
    {
        private readonly ISinhVienGiayToService _sinhVienGiayToService;

        public QlGiayToController()
        {
            _sinhVienGiayToService = new SinhVienGiayToService();
        }

        public ActionResult Index()
        {
            ViewBag.Menu = "Quản lý giấy tờ";
            ViewBag.MenuIcon = "fa-graduation-cap";
            return View();
        }

        [HttpPost]
        public ActionResult XacNhan(int giayToId)
        {
            var giayTo = _sinhVienGiayToService.GetById(giayToId);
            giayTo.TinhTrang = "Đã xác nhận";
            _sinhVienGiayToService.Update(giayTo);
            if (_sinhVienGiayToService.Update(giayTo))
            {
                return Json("Ok", JsonRequestBehavior.AllowGet);
            }
            return Json("Fail", JsonRequestBehavior.AllowGet);
        }
    }
}
