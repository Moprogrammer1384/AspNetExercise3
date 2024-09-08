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
        app.MapGet("/", () => "Hello World!");

        app.MapGet("/test/{num:int:prime}", async (HttpContext context, int num) =>
        {
            await context.Response.WriteAsync(num.ToString());
        });

        return app;
    }
}
