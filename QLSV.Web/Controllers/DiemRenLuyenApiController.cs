using System;
using System.Linq;
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
    public class DiemRenLuyenApiController : ApiController
    {
        private readonly IDiemRenLuyenService _diemRenLuyenService;
        public DiemRenLuyenApiController()
        {
            _diemRenLuyenService = new DiemRenLuyenService();
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_diemRenLuyenService.GetAll().OrderBy(x=>x.SinhVien.Lop.Ten), loadOptions);
            return Request.CreateResponse(obj);
        }

        [HttpPut]
        public HttpResponseMessage Put(FormDataCollection form)
        {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");

            var diemRl = _diemRenLuyenService.GetById(key);
            JsonConvert.PopulateObject(values, diemRl);

            if (_diemRenLuyenService.Update(diemRl))
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse("Không thể cập nhật");
        }
    }
}
