using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
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
    public class DiemDanhApiController : ApiController
    {
        private readonly IDiemDanhService _diemDanhService = new DiemDanhService();

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions, int id, DateTime ngayDiemDanh)
        {
            var date = ngayDiemDanh.Date;
            var obj = DataSourceLoader
                .Load(_diemDanhService
                .Where(x=>x.NgayDiemDanh == date && x.LopHocPhanId == id), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage GetDiemDanhLop(DataSourceLoadOptions loadOptions, int id)
        {
            var oldCookie = HttpContext.Current.Request.Cookies["SinhVienInfo"];
            if (oldCookie != null)
            {
                var loginString = HttpUtility.UrlDecode(oldCookie.Value);
                var loginModel = JsonConvert.DeserializeObject<LoginModel>(loginString);
                var sinhVienId = loginModel.IdNguoiDung;
                var obj = DataSourceLoader
               .Load(_diemDanhService
               .Where(x => x.LopHocPhanId == id && x.SinhVienId == sinhVienId), loadOptions);
                return Request.CreateResponse(obj);
            }
            return null;
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var diemDanh = _diemDanhService.GetById(key);
            JsonConvert.PopulateObject(values, diemDanh);

            if (_diemDanhService.Update(diemDanh))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse("Không thể cập nhật");
        }

        [HttpGet]
        public HttpResponseMessage GetKetQuaDiemDanh(DataSourceLoadOptions loadOptions)
        {
            var oldCookie = HttpContext.Current.Request.Cookies["SinhVienInfo"];
            if (oldCookie != null)
            {
                var loginString = HttpUtility.UrlDecode(oldCookie.Value);
                var loginModel = JsonConvert.DeserializeObject<LoginModel>(loginString);
                var sinhVienId = loginModel.IdNguoiDung;
                var obj = DataSourceLoader
                .Load(_diemDanhService.GetKetQuaDiemDanhs(sinhVienId,null), loadOptions);
                return Request.CreateResponse(obj);
            }
            return null;
        }
    }
}
