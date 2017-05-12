using System.Web.Mvc;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;
using Rotativa.Options;

namespace QLSV.Web.Controllers
{
    public class PdfController : Controller
    {
        private readonly ISinhVienGiayToService _sinhVienGiayToService;
        private readonly ISinhVienService _sinhVienService;

        public PdfController()
        {
            _sinhVienGiayToService = new SinhVienGiayToService();  
            _sinhVienService = new SinhVienService();
        }
        // GET: Admin/Pdf
        public ActionResult Index(int sinhVienId)
        {
            var model = _sinhVienService.GetById(sinhVienId);
            return View(model);
        }

        public ActionResult GeneratePdf(int giayToId)
        {
            var giayTo = _sinhVienGiayToService.GetById(giayToId);
            return new Rotativa.ActionAsPdf(giayTo.GiayTo.LinkAction, new { sinhVienId = giayTo.SinhVienId})
            {
                MinimumFontSize = 24,
                PageSize = Size.A4
            };
        }
    }
}