using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Loto.App_Start
{
    public class RegisterBundle
    {
        public static void RegisterAllBundles(BundleCollection bundles)
        {
            //Creating bundle for your css files
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css",
            "~/Content/bootstrap.css.map",
            "~/Content/animate.css",
            "~/Content/font-awesome.css",
            "~/Content/hover.css",
            "~/Content/bootstrap-theme.css",
            "~/Content/bootstrap-theme.css.map",
            "~/Content/awesome-bootstrap-checkbox.css"));

            //Creating bundle for your js files
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            "~/Scripts/jquery-1.9.1.min.js",
            "~/Scripts/jquery.validate.min.js",
            "~/Scripts/jquery.validate.unobtrusive.min.js",
            "~/Scripts/bootstrap.js",
            "~/Scripts/bootstrap-table.js"));
        }
    }
}