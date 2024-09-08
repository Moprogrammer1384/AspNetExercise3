namespace AspNetExercise3.CustomConstraint.Extensions;

public static class IsPrimeConstraintExtension
{
    public static IServiceCollection AddPrimeChecking
        (this IServiceCollection services)
    {
        services.Configure<RouteOptions>(opts =>
        {
            opts.ConstraintMap.Add("prime", typeof(IsPrimeConstraint));
        });

        return services;
    }
}
