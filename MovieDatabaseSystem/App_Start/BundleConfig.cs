using System.Web;
using System.Web.Optimization;

namespace MovieDatabaseSystem
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/CSS/Plugins/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/DataTableStyle").Include(
                      "~/Content/Plugins/dataTables.bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/IndexPageStyle").Include(
                "~/Content/CSS/IndexPage.css",
                "~/Content/CSS/Plugins/timePicker.css",
                "~/Content/CSS/Plugins/jquery.datepicker2.css"));

            bundles.Add(new StyleBundle("~/bundles/Select2Style").Include(
                "~/Content/CSS/select2.min.css"));



            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Plugins/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/IndexPageScripts").Include(
                      "~/Scripts/ViewScripts/Index.js",
                      "~/Scripts/ViewScripts/AddMovie.js",
                      "~/Scripts/Plugins/jquery-timepicker.js",
                      "~/Scripts/Plugins/jquery.datepicker2.js"));

            bundles.Add(new ScriptBundle("~/bundles/DataTableScript").Include(
                        "~/Scripts/Plugins/jquery.dataTables.min.js",
                        "~/Scripts/Plugins/dataTables.bootstrap.js",
                        "~/Scripts/Plugins/dataTables.responsive.min.js",
                        "~/Scripts/Plugins/datable-render-moment.js"));

            bundles.Add(new ScriptBundle("~/bundles/Select2Scripts").Include(
                "~/Scripts/select2.min.js"));
        }
    }
}
