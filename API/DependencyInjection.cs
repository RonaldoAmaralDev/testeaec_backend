using Microsoft.Extensions.DependencyInjection; 

namespace SDKAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services)
        {
            services.AddSingleton<IAPI, API>();

            return services;
        }
    }
}
