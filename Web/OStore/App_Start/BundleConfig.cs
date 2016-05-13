using System.Web;
using System.Web.Optimization;

namespace OStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/FooTable").Include(
                      "~/Scripts/Footable/footable.js?v=2-0-1",
                      "~/Scripts/Footable/footable.paginate.js?v=2-0-1",
                      "~/Scripts/Footable/footable.sort.js?v=2-0-1",
                      "~/Scripts/Footable/footable.filter.js?v=2-0-1"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/dropzonescripts").Include(
         "~/Scripts/dropzone/dropzone.js"));

            bundles.Add(new StyleBundle("~/Content/dropzonescss").Include(
                     "~/Content/dropzone/dropzone.css"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/bower_components/bootstrap/dist/js/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
            "~/Scripts/knockout-3.4.0.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/bower_components/metisMenu/dist/metisMenu.min.css",
                      "~/Content/timeline.css",
                      "~/Content/sb-admin-2.css"));

            bundles.Add(new StyleBundle("~/Content/FooTable").Include(
                    "~/Content/Footable/Footable/bootstrap.css",
                    "~/Content/Footable/footable.core.css?v=2-0-1"));
        }
    }
}
