using System.Web;
using System.Web.Optimization;

namespace Portfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // All JS Files Bundle For Website
            bundles.Add(new ScriptBundle("~/bundles/portjs").Include(
                        "~/Scripts/jquery-3.0.0.js",
                        "~/Content/lib/jquery/jquery-migrate.min.js",
                        "~/Scripts/popper.js",
                        "~/Scripts/bootstrap.js",
                        "~/Content/lib/easing/easing.js",
                        "~/Content/lib/counterup/jquery.waypoints.min.js",
                        "~/Content/lib/counterup/jquery.counterup.js",
                        "~/Content/lib/owlcarousel/owl.carousel.js",
                        "~/Content/lib/lightbox/js/lightbox.js",
                        "~/Content/lib/typed/typed.js",
                        "~/Content/js/main.js"
                ));

            // All CSS Files Bundle For Website
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/portcss").Include(
                        "~/Content/lib/bootstrap/css/bootstrap.css",
                        "~/Content/lib/font-awesome/css/font-awesome.css",
                        "~/Content/lib/animate/animate.css",
                        "~/Content/lib/ionicons/css/ionicons.css",
                        "~/Content/lib/owlcarousel/assets/owl.carousel.css",
                        "~/Content/lib/lightbox/css/lightbox.css",
                        "~/Content/css/style.css"
                ));
        }
    }
}
