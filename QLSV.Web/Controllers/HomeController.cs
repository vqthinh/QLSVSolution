using System.Web.Mvc;
using QLSV.Abstract.Services;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISinhVienService _sinhVienService;
        public HomeController()
        {
            _sinhVienService = new SinhVienService();
        }

        public ActionResult Index()
        {
            var list = _sinhVienService.GetAll();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}