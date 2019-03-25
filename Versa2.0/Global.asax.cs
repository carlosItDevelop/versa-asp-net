using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Versa2._0
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("pt-BR");

            EntitySpaces.Interfaces.esProviderFactory.Factory = new EntitySpaces.Loader.esDataProviderFactory();

            //ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
            //ModelBinders.Binders.Add(typeof(decimal?), new DecimalModelBinder());

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority).Contains("localhost")) return;
            var leftPartOfUrl = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority).ToLower();
            if (leftPartOfUrl.StartsWith("http") && leftPartOfUrl.Split('.').Length == 1)
            {
                var fullUrl = HttpContext.Current.Request.Url.ToString();
                HttpContext.Current.Response.Status = "301 Moved Permanently";
                HttpContext.Current.Response.StatusCode = 301;
                HttpContext.Current.Response.AddHeader("Location", fullUrl.Insert(fullUrl.IndexOf("://", StringComparison.Ordinal) + 3, "www."));
                HttpContext.Current.Response.End();
            }
        }
    }
}
