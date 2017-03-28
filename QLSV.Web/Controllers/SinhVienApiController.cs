using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class SinhVienApiController : ApiController
    {
        private readonly ISinhVienService _sinhVienService;
        private readonly ILopService _lopService;
        public SinhVienApiController()
        {
            _sinhVienService = new SinhVienService();
            _lopService = new LopService();
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_sinhVienService.Where(x=>x.Deleted==false), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage GetLop(DataSourceLoadOptions loadOptions,int? id)
        {
            if (id == 0)
            {
                var obj = DataSourceLoader.Load(_lopService.GetAll(), loadOptions);
                return Request.CreateResponse(obj);
            }
            else
            {
                var obj = DataSourceLoader.Load(_lopService.GetByKhoaId(id.GetValueOrDefault()), loadOptions);
                return Request.CreateResponse(obj);
            }

        }

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            var values = form.Get("values");

            var sinhVien = new SinhVien();
            JsonConvert.PopulateObject(values, sinhVien);

            if (_sinhVienService.Add(sinhVien))
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Mã sinh viên đã tồn tại");
        }

        [HttpDelete]
        public void Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));

            _sinhVienService.Delete(key);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var sinhVien = _sinhVienService.GetById(key);
            JsonConvert.PopulateObject(values, sinhVien);


            if (_sinhVienService.Update(sinhVien))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse("Không thể cập nhật");
        }

        [HttpGet]
        public HttpResponseMessage GetKhoa(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_sinhVienService.GetKhoa(), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpGet]
        public HttpResponseMessage GetKhoaHoc(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_sinhVienService.GetKhoaHocs(), loadOptions);
            return Request.CreateResponse(obj);
        }
    }
}
