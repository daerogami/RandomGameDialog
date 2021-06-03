using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RandomGameDialog.Web.Services;

namespace RandomGameDialog.Web
{
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(
             this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IOblivionDialogueDataStore>(new OblivionDialogueDataStore());

            return services;
        }
    }
}
