using System;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;

namespace UmbracoDeafault
{
    public class CustomUmbracoApplication : UmbracoApplication
    {

        protected override IBootManager GetBootManager()
        {
            return new CustomBootManager(this);
        }
    }

    public class CustomBootManager : WebBootManager
    {
        private CustomUmbracoApplication customUmbracoApplication;

        public CustomBootManager(CustomUmbracoApplication customUmbracoApplication) : base(customUmbracoApplication)
        {

        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            RouteTable.Routes.MapRoute("HomePage", "home/index", new { controller = "Home", action = "Index" });
            //RouteTable.Routes.MapRoute("ContactUs",)
            return base.Complete(afterComplete);    
        }
    }
}