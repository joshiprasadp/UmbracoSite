using System.Web.Optimization;
using Umbraco.Core;
using UmbracoSite.App_Start;

namespace UmbracoSite.App_Code
{
    public class UmbracoEventHandlers : ApplicationEventHandler
    {
        protected override void ApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}