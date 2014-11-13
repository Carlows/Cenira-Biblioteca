using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace CeniraBiblioteca.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/darkly-bootstrap.min.css",
                "~/Content/estilos.css",
                "~/Content/slick/slick.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
            .Include("~/Scripts/jquery-{version}.js",
            "~/Scripts/jquery.validate.js",
            "~/Scripts/jquery.validate.unobtrusive.js",
            "~/Scripts/jquery.unobtrusive-ajax.js",
            "~/Content/slick/slick.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
            .Include("~/Scripts/bootstrap.min.js"));
        }
    }
}