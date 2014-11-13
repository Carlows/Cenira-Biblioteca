using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using CeniraBiblioteca.App_Start;
using CeniraBiblioteca.Models.Identity.DAL;

namespace CeniraBiblioteca
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            /*System.Data.Entity.Database.SetInitializer(new IdentityDbInit());

            AppIdentityDbContext db = new AppIdentityDbContext();
            db.Database.Initialize(true);*/
        }
    }
}
