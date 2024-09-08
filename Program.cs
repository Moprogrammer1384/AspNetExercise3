using AspNetExercise3.CustomConstraint;
using AspNetExercise3.HostingExtension;

var builder = WebApplication.CreateBuilder(args);

var app = builder
    .ConfigureServices()
    .ConfigurePipeline();

app.Run();
