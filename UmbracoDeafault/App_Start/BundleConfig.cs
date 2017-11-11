using System.Web.Optimization;

namespace UmbracoDeafault.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = false;
            BundleTable.Bundles.UseCdn = true;

            var webfontPath = "https://ajax.googleapis.com/ajax/libs/webfont/1.4.7/webfont.js";
            bundles.Add(new ScriptBundle("~/bundles/webfont",
                webfontPath)
                .Include("~/scripts/webfont.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/siteScripts")
                .Include("~/scripts/PK_Extras.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/scripts/jquery-{version}.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/scripts/modernizr-{version}.js")
                );
            bundles.Add(new StyleBundle("~/bundles/style")
                .Include("~/css/main.css")
                );
        }

    }
}