using System.Web.Mvc;

namespace QLSV.Web.Areas.Sv
{
    public class SvAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Sv";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Sv_default",
                "Sv/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}