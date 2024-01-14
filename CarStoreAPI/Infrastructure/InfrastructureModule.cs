using CarStoreAPI.Repository.CarRepositoryDapper;
using CarStoreAPI.Repository.GenericRepositoryDapper;

namespace CarStoreAPI.Infrastructure;

public static class InfrastructureModule
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services
            .AddRepositories();
        
        return services;
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICarRepositoryDapper, CarRepositoryDapper>();

        return services;
    }

}
