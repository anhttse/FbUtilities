using System.Web;
using System.Web.Optimization;

namespace FbUtilities
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/frameworks/jquery/jquery-3.2.1.min.js"));

            //            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //                        "~/Scripts/jquery.validate*"));

            //Scripts
            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                      "~/Assets/frameworks/popper/popper.min.js"));//popper
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/frameworks/bootstrap/bootstrap.min.js"));//bootstrap 
            bundles.Add(new ScriptBundle("~/bundles/perfect-scrollbar").Include(
                      "~/Assets/theme/js/perfect-scrollbar.jquery.min.js"));//slimscrollbar js
            bundles.Add(new ScriptBundle("~/bundles/waves").Include(
                      "~/Assets/theme/js/waves.js"));//Wave Effects
            bundles.Add(new ScriptBundle("~/bundles/sidebarmenu").Include(
                      "~/Assets/theme/js/sidebarmenu.js"));//Menu sidebar
            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                      "~/Assets/theme/js/custom.min.js"));//Custom js
            bundles.Add(new ScriptBundle("~/bundles/morrisjs").Include(
                      "~/Assets/frameworks/raphael/raphael-min.js",
                      "~/Assets/frameworks/morrisjs/morris.min.js",
                      "~/Assets/frameworks/jquery-sparkline/jquery.sparkline.min.js"
                ));//morris
            bundles.Add(new ScriptBundle("~/bundles/toast").Include(
                      "~/Assets/frameworks/toast-master/js/jquery.toast.js"
                ));//morris
            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(
                      "~/Assets/theme/js/dashboard1.js"
                ));//morris

            //css
            //bootstrap
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //morris
            bundles.Add(new StyleBundle("~/Content/theme/morris").Include(
                      "~/Assets/frameworks/morrisjs/morris.css"));
            //toast
            bundles.Add(new StyleBundle("~/Content/theme/toast").Include(
                      "~/Assets/frameworks/toast-master/css/jquery.toast.css"));
            //theme
            bundles.Add(new StyleBundle("~/Content/theme/style").Include(
                      "~/Assets/theme/css/style.min.css"));
            //dashboard
            bundles.Add(new StyleBundle("~/Content/theme/dashbard").Include(
                      "~/Assets/theme/css/pages/dashboard1.css"));
            bundles.Add(new StyleBundle("~/Content/theme/login-register").Include(
                      "~/Assets/theme/css/pages/login-register-lock.css"));//login

        }
    }
}
