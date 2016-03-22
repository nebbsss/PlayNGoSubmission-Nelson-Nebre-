using System.Web;
using System.Web.Optimization;

namespace PlayNGoSubmission
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Styles").Include(
                        "~/assets/css/metro.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                        "~/assets/js/jquery.min.js",
                        "~/assets/js/metro.min.js",
                        "~/assets/js/jquery.dataTables.min.js"));
        }
    }
}
