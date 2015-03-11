using System.Web.Optimization;

namespace ProfessionalWebsite
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                        .Include("~/Content/bootstrap.css")
                        .Include("~/Content/font-awesome.css")
                        .Include("~/Content/site.css")
                        .Include("~/Content/site.skillbar.css")
                        .Include("~/Content/site.topbar.css")
                        .Include("~/Content/site.wraps.css")
                        );

            bundles.Add(new StyleBundle("~/Bundles/font")
                        .Include("~/fonts/lato-font-faces.css")
                        .Include("~/fonts/raleway-font-faces.css")
                        );

            bundles.Add(new ScriptBundle("~/Bundles/postload_js")
                        .Include("~/Scripts/jquery-2.1.3.js")
                        .Include("~/Scripts/site.skillbar.js")
                        .Include("~/Scripts/bootstrap.js")
                        .Include("~/Scripts/jquery.smooth.scroll-1.0.1.js")
                        );

            BundleTable.EnableOptimizations = true;
        }
    }
}