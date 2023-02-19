using Microsoft.Extensions.DependencyInjection;
using Shop.Core.Abstractions;
using Shop.Core.AppSettings;

namespace Shop.Core;

public static class ServicesCollectionExtensions
{
    public static void ConfigureAppSettings(this IServiceCollection services)
    {
        services.AddOptionsWithValidation<ConnectionOptions>(ConnectionOptions.ConfigSectionPath);
    }

    public static IServiceCollection AddOptionsWithValidation<TOptions>(this IServiceCollection services, string configSectionPath)
        where TOptions : BaseOptions
    {
        return services
            .AddOptions<TOptions>()
            .BindConfiguration(configSectionPath, options => options.BindNonPublicProperties = true)
            .ValidateDataAnnotations()
            .ValidateOnStart()
            .Services;
    }
}