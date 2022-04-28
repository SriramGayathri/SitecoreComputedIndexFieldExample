namespace ProductSearch.Platform.Pipelines
{
    using System.Web.Mvc;
    using System.Web.Routing;
    using Sitecore.Pipelines;

    public class RegisterWebApiRoutes
    {
        public virtual void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("ProductSearch.Api", "api/sitecore/productbycategory/{action}", new
            {
                controller = "ProductByCategory"
            });
        }
    }
}