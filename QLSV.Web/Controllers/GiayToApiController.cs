using System.Net.Http;
using System.Web;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class GiayToApiController : ApiController
    {
        private readonly IGiayToService _giayToService;
        private readonly ISinhVienGiayToService _sinhVienGiayToService;
        public GiayToApiController()
        {
            _giayToService = new GiayToService();
            _sinhVienGiayToService = new SinhVienGiayToService();
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_giayToService.GetAll(), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage GetSinhVienGiayTo(DataSourceLoadOptions loadOptions)
        {
            var sinhVien = new TaiKhoan();
            var requestCookie = HttpContext.Current.Request.Cookies["SinhVienInfo"];
            if (requestCookie != null)
            {
                var cookieString = HttpUtility.UrlDecode(requestCookie.Value);
                sinhVien = JsonConvert.DeserializeObject<TaiKhoan>(cookieString);
            }

            var obj = DataSourceLoader.Load(_sinhVienGiayToService.Where(x=>x.SinhVienId == sinhVien.IdNguoiDung), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage GetSinhVienGiayToAdmin(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_sinhVienGiayToService.GetAll(), loadOptions);
            return Request.CreateResponse(obj);
        }
    }
}
