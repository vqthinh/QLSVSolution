using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
using QLSV.Entities.Models;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class GiaoVienApiController : ApiController
    {
        private readonly IGiaoVienService _giaoVIenService;
        public GiaoVienApiController()
        {
            _giaoVIenService = new GiaoVienService();
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_giaoVIenService.Where(x => x.Deleted == false), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpPost]
        public HttpResponseMessage Post(FormDataCollection form)
        {
            var values = form.Get("values");

            var giaoVien = new GiaoVien();
            JsonConvert.PopulateObject(values, giaoVien);

            if (_giaoVIenService.Add(giaoVien))
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Mã giáo viên đã tồn tại");
        }

        [HttpDelete]
        public void Delete(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));

            _giaoVIenService.Delete(key);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var giaoVien = _giaoVIenService.GetById(key);
            JsonConvert.PopulateObject(values, giaoVien);


            if (_giaoVIenService.Update(giaoVien))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse("Không thể cập nhật");
        }
    }
}
