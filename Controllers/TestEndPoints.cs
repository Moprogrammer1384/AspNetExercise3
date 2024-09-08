namespace AspNetExercise3.Controllers;

public static class TestEndPoints
{
    public static IEndpointRouteBuilder MapTestEndPoints
        (this IEndpointRouteBuilder app)
    {
        app.MapGet("/", () => "Welcome to our web site !!!");

        app.MapGet("/test/{num:int:prime}", async (HttpContext context, int num) =>
        {
            await context.Response.WriteAsync(num.ToString());
        });

        return app;
    }
}
