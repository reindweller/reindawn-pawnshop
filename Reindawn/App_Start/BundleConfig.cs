using System.Web.Optimization;

namespace Reindawn
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));


            bundles.Add(new ScriptBundle("~/bundles/sbadminjs").Include(
                      "~/Content/sb-admin/vendor/metisMenu/metisMenu.js",
                      "~/Content/sb-admin/vendor/raphael/raphael.js",
                      "~/Content/sb-admin/vendor/morrisjs/morris.js",
                      "~/Content/sb-admin/dist/js/sb-admin-2.js"
                      ));


            bundles.Add(new ScriptBundle("~/bundles/datatablejs").Include(
                      "~/Content/sb-admin/vendor/datatables/js/jquery.dataTables.js",
                      "~/Content/sb-admin/vendor/datatables-plugins/dataTables.bootstrap.js",
                      "~/Content/sb-admin/vendor/datatables-responsive/dataTables.responsive.js"
                      ));

           bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css",
                      "~/Content/bootstrap.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/sbadmincss").Include(
                      "~/Content/sb-admin/vendor/bootstrap/css/bootstrap.css",
                      "~/Content/sb-admin/vendor/metisMenu/metisMenu.css",
                      "~/Content/sb-admin/dist/css/sb-admin-2.css",
                      "~/Content/sb-admin/vendor/morrisjs/morris.css",
                      "~/Content/sb-admin/vendor/font-awesome/css/font-awesome.css"
                      ));


            bundles.Add(new StyleBundle("~/Content/datatablecss").Include(
                      "~/Content/sb-admin/vendor/datatables-plugins/dataTables.bootstrap.css",
                      "~/Content/sb-admin/vendor/datatables-responsive/dataTables.responsive.css"
                      ));
            

        }
    }
}
