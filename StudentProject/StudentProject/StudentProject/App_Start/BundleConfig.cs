using System.Web;
using System.Web.Optimization;

namespace StudentProject.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {

            bundles.Add(new StyleBundle("~/Content/Style").Include("~/Content/site.css"));
        }
    }
}
