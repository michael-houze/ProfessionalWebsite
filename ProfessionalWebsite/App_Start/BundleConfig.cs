using System.Web.Optimization;

namespace ProfessionalWebsite
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                        .Include("~/Content/bootstrap.css")
                        .Include("~/Content/bootstrap-theme.css")
                        .Include("~/Content/font-awesome.css")
                        .Include("~/Content/jquery.smooth.scroll.css")
                        .Include("~/Content/site.css")
                        );

            bundles.Add(new StyleBundle("~/Bundles/font")
                        .Include("~/fonts/lato-font-faces.css")
                        .Include("~/fonts/raleway-font-faces.css")
                        );

            bundles.Add(new ScriptBundle("~/Bundles/javascript")
                        .Include("~/Scripts/jquery-2.1.3.js")        
                        .Include("~/Scripts/bootstrap.js")
                        .Include("~/Scripts/Chart.js")
                        .Include("~/Scripts/jquery.smooth.scroll-1.0.1.js")
                        );

            BundleTable.EnableOptimizations = true;
        }
    }
}