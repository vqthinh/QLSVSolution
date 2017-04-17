using System.Web.Mvc;

namespace QLSV.Web.Controllers
{
    public class PdfController : Controller
    {
        // GET: Admin/Pdf
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GeneratePdf()
        {
            return new Rotativa.PartialViewAsPdf("_LoginInfo");
        }
    }
}