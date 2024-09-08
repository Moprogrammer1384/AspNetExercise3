using AspNetExercise3.CustomConstraint.Contracts;
using AspNetExercise3.Servies;

namespace AspNetExercise3.Services.Extensions;

public static class ValueCheckerServiceExtension
{
    public static IServiceCollection AddValueCheckerService
        (this IServiceCollection services)
    {
        services.AddSingleton<IValueCheckerService, ValueCheckerService>();

        return services;
    }
}
