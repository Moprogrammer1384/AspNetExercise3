using AspNetExercise3.Controllers;
using AspNetExercise3.CustomConstraint.Extensions;
using AspNetExercise3.Services.Extensions;

namespace AspNetExercise3.HostingExtension;

public static class WebHostingExtension
{
    public static WebApplication ConfigureServices
        (this WebApplicationBuilder builder)
    {
        builder.Services.AddValueCheckerService();
        builder.Services.AddPrimeChecking();

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.MapTestEndPoints();

        return app;
    }
}
