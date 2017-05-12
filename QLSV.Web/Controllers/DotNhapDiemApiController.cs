using System.Net.Http;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using QLSV.Abstract.Services;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class DotNhapDiemApiController : ApiController
    {
        private readonly IDotNhapDiemService _dotNhapDiemService;
        public DotNhapDiemApiController()
        {
            _dotNhapDiemService = new DotNhapDiemService();
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_dotNhapDiemService.GetAll(), loadOptions);
            return Request.CreateResponse(obj);
        }
    }
}
