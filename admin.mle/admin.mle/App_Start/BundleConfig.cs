using System.Web;
using System.Web.Optimization;

namespace admin.mle
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/main").Include(
                      "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugin").Include(
                      "~/Scripts/plugins/moment.min.js",
                      "~/Scripts/plugins/bootstrap-notify.min.js",
                      "~/Scripts/plugins/chart.js",
                      "~/Scripts/plugins/dataTables.bootstrap.min.js",
                      "~/Scripts/plugins/fullcalendar.min.js",
                      "~/Scripts/plugins/jquery.dataTables.min.js",
                      "~/Scripts/plugins/jquery.vmap.min.js",
                      "~/Scripts/plugins/jquery.vmap.sampledata.js",
                      "~/Scripts/plugins/jquery.vmap.world.js",
                      "~/Scripts/plugins/jquery-ui.custom.min.js",
                      "~/Scripts/plugins/pace.min.js",
                      "~/Scripts/plugins/select2.min.js",
                      "~/Scripts/plugins/sweetalert.min.js",
                      "~/Scripts/plugins/bootstrap-datepicker.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/main.css",
                      "~/Content/site.css"));
        }
    }
}
