using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using Umbraco.Core;
using UmbracoDeafault.App_Start;

namespace UmbracoDeafault.App_Code
{
    public class UmbracoEventHandlers : ApplicationEventHandler
    {
        protected override void ApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //base.ApplicationInitialized(umbracoApplication, applicationContext);
        }
    }
}