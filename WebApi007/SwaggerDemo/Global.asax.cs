using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Description;
using System.Web.Http.Routing;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SwaggerDemo
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //GlobalConfiguration.Configuration.Services.Replace(typeof(IApiExplorer), new CustomApiExplorer(GlobalConfiguration.Configuration));
        }
    }

    public class CustomApiExplorer : ApiExplorer
    {
        public CustomApiExplorer(HttpConfiguration configuration) : base(configuration)
        {
        }

        public override bool ShouldExploreAction(string actionVariableValue, HttpActionDescriptor actionDescriptor, IHttpRoute route)
        {
            return base.ShouldExploreAction(actionVariableValue, actionDescriptor, route);
        }

        public override bool ShouldExploreController(string controllerVariableValue, HttpControllerDescriptor controllerDescriptor, IHttpRoute route)
        {
            return base.ShouldExploreController(controllerVariableValue, controllerDescriptor, route);
        }
    }
}
