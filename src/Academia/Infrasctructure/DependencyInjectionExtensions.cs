namespace Academia.Infrasctructure;

public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AcademiaContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("AcademiaDb"),
                b => b.MigrationsAssembly(typeof(AcademiaContext).Assembly.FullName)));

        return services;
    }
}