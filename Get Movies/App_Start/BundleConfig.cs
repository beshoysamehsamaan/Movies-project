using System.Web;
using System.Web.Optimization;

public class BundleConfig
{
    public static void RegisterBundles(BundleCollection bundles)
    {
        StyleBundle cssFiles = new StyleBundle("~/bundles/css");
        cssFiles.Include(
            "~/Assets/css/animate.css",
            "~/Assets/css/animsition.css",
            "~/Assets/css/bootstrap.css",
            "~/Assets/css/bootstrap-grid.css",
            "~/Assets/css/bootstrap-reboot.css",
            "~/Assets/css/daterangepicker.css",
            "~/Assets/css/hamburgers.css",
            "~/Assets/css/main.css",
            "~/Assets/css/perfect-scrollbar.css",
            "~/Assets/css/select2.css",
            "~/Assets/css/util.css"
        );
        bundles.Add(cssFiles);


        ScriptBundle jsFiles = new ScriptBundle("~/bundles/js");
        jsFiles.Include(
            "~/Assets/js/animsition.js",
            "~/Assets/js/bootstrap.js",
            "~/Assets/js/countdowntime.js",
            "~/Assets/js/daterangepicker.js",
            "~/Assets/js/jquery-3.2.1.min.js",
            "~/Assets/js/main.js",
            "~/Assets/js/map-custom.js",
            "~/Assets/js/moment.js",
            "~/Assets/js/perfect-scrollbar.min.js",
            "~/Assets/js/popper.js",
            "~/Assets/js/select2.js",
            "~/Assets/js/tooltip.js"
        );
        bundles.Add(jsFiles);

        BundleTable.EnableOptimizations = true;
    }
}