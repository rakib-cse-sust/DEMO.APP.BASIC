using System.Linq;
using System.Web.Helpers;
using System.Web.Http.Controllers;

namespace DEMO.APP.BASIC.App_Start
{
    public class ValidateAntiForgeryAngular : System.Web.Http.Filters.ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext filterContext)
        {
            var headers = filterContext.Request.Headers;
            string cookieToken = null;
            string formToken = null;
            var rvt = headers.GetValues("RequestVerificationToken").FirstOrDefault();
            if (rvt != null)
            {
                string[] tokens = rvt.Split(':');
                if (tokens.Length == 2)
                {
                    cookieToken = tokens[0].Trim();
                    formToken = tokens[1].Trim();
                }
            }
            AntiForgery.Validate(cookieToken, formToken);
        }
    }
}