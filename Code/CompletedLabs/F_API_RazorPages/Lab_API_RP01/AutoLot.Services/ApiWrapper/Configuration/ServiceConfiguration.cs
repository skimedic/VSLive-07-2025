// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - ServiceConfiguration.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/29
// ==================================

namespace AutoLot.Services.ApiWrapper.Configuration;
public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureApiServiceWrapper(
        this IServiceCollection services, IConfiguration config)
    {
        services.Configure<ApiServiceSettings>(config.GetSection(nameof(ApiServiceSettings)));
        services.AddHttpClient<ICarApiServiceWrapper, CarApiServiceWrapper>();
        services.AddHttpClient<IMakeApiServiceWrapper, MakeApiServiceWrapper>();
        return services;
    }
}
