using System.Web.Mvc;

namespace DoAnMotTuan.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller= "Buses", id = UrlParameter.Optional },
                new[] { "DoAnMotTuan.Areas.Admin.Controllers" }
            );
        }
    }
}