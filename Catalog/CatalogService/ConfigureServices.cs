using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace CatalogService
{
	public static class ConfigureServices
	{
        public static void AddCatalog(this WebApplicationBuilder builder)
        {
            ConfigureControllers(builder);
        }

        private static void ConfigureControllers(WebApplicationBuilder builder)
        {
            var assembly = typeof(ConfigureServices).Assembly;
            builder.Services.AddControllers().AddApplicationPart(assembly);
        }
    }
}

