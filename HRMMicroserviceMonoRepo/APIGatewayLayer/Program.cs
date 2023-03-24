using JwtAuthenticationManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("ocelot.json", false, true).AddEnvironmentVariables();

builder.Services.AddOcelot(builder.Configuration);

builder.Services.AddCustomeJwtAuthentication();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

await app.UseOcelot();
app.UseRouting();
app.UseCors();
//app.UseAuthentication();
app.UseAuthorization();
app.Run();

