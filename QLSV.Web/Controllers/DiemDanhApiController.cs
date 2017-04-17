﻿using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using QLSV.Abstract.Services;
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
    }
}