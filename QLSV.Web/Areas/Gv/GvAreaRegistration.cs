using System.Web.Mvc;

namespace QLSV.Web.Areas.Gv
{
    public class GvAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Gv";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Gv_default",
                "Gv/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}