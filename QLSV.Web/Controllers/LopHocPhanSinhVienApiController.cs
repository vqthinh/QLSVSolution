using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class LopHocPhanSinhVienApiController : ApiController
    {
        private readonly ILopHocPhanSinhVienService _lopHocPhanSinhVienService;
        private readonly ILopHocPhanService _lopHocPhanService;

        public LopHocPhanSinhVienApiController()
        {
            _lopHocPhanSinhVienService = new LopHocPhanSinhVienService();
            _lopHocPhanService = new LopHocPhanService();
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var lopHpSv = _lopHocPhanSinhVienService.GetById(key);
            JsonConvert.PopulateObject(values, lopHpSv);


            if (_lopHocPhanSinhVienService.Update(lopHpSv))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse("Không thể cập nhật");
        }

        [HttpGet]
        public HttpResponseMessage GetDanhSachSinhVien(DataSourceLoadOptions loadOptions, int id)
        {
            var obj = DataSourceLoader.Load(_lopHocPhanService.GetDanhSachSinhVien(id), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage GetLopHocPhanBySinhVienId(DataSourceLoadOptions loadOptions, int id)
        {
            var obj = DataSourceLoader.Load(_lopHocPhanSinhVienService.Where(x=>x.SinhVienId==id), loadOptions);
            return Request.CreateResponse(obj);
        }
    }
}
