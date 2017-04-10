using System;
using System.Web;
using System.Web.Mvc;

namespace QLSV.Web.Models
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(
                            AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException(nameof(filterContext));
            }
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                string loginUrl = "~/TaiKhoan/DangNhap"; // Default Login Url 
                filterContext.Result = new RedirectResult(loginUrl);
            }
            else
            {
                var responseCookie = HttpContext.Current.Request.Cookies["UserInfo"];
                if (responseCookie == null)
                {
                    string loginUrl = "~/TaiKhoan/DangNhap"; // Default Login Url 
                    filterContext.Result = new RedirectResult(loginUrl);
                }
            }
        }
    }

    public class GiaoVienAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(
                            AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException(nameof(filterContext));
            }
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                string loginUrl = "~/TaiKhoan/DangNhap"; // Default Login Url 
                filterContext.Result = new RedirectResult(loginUrl);
            }
            else
            {
                var responseCookie = HttpContext.Current.Request.Cookies["GiaoVienInfo"];
                if (responseCookie == null)
                {
                    string loginUrl = "~/TaiKhoan/DangNhap"; // Default Login Url 
                    filterContext.Result = new RedirectResult(loginUrl);
                }
            }
        }
    }
}