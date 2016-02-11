using System.Web.Mvc;

namespace Application.UI.Web.Areas.Logins
{
    public class LoginsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Logins";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Logins_default",
                "Logins/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
