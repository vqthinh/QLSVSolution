using System.Net.Http;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using QLSV.Abstract.Services;
using QLSV.Services.Services;

namespace QLSV.Web.Controllers
{
    public class LichSuApiController : ApiController
    {
        private readonly ILichSuService _lichSuService;

        public LichSuApiController()
        {
            _lichSuService = new LichSuService();
        }

        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions)
        {
            var obj = DataSourceLoader.Load(_lichSuService.GetAll(), loadOptions);
            return Request.CreateResponse(obj);
        }
    }
}