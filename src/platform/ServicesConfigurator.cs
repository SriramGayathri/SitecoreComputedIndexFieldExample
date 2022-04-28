using ProductSearch.Platform.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sitecore.DependencyInjection;

namespace ProductSearch.Platform
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            
            serviceCollection.Replace(ServiceDescriptor.Scoped(typeof(ProductByCategoryController),
               typeof(ProductByCategoryController)));
        }
    }
}