using FullStackExperience.Services;
using Sitecore.DependencyInjection;
using FullStackExperience.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace FullStackExperience.DependencyInjection
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection services)
        {
            services.AddTransient(typeof(BannerController));

            services.AddHttpClient<FlowExecutionService>();
        }
    }
}
