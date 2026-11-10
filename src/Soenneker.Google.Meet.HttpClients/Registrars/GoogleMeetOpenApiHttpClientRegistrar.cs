using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Google.Meet.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Google.Meet.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class GoogleMeetOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="GoogleMeetOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGoogleMeetOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IGoogleMeetOpenApiHttpClient, GoogleMeetOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="GoogleMeetOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGoogleMeetOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IGoogleMeetOpenApiHttpClient, GoogleMeetOpenApiHttpClient>();

        return services;
    }
}
