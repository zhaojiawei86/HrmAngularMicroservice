using Hrm.Authen.ApplicationCore.Contract.Service;
using Hrm.Authen.ApplicationCore.Contract.Repository;
using Hrm.Authen.Infrastructure.Data;
using Hrm.Authen.Infrastructure.Repository;
using Hrm.Authen.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("HrmAuthenDb");
var dockerConnStr = Environment.GetEnvironmentVariable("HrmAuthenDb");
builder.Services.AddDbContext<AuthenDbContext>(options =>
{
    //options.UseSqlServer(connectionString);
    options.UseSqlServer(dockerConnStr);
});

// Dependency injection for repositories
builder.Services.AddScoped<IAccountRepositoryAsync, AccountRepositoryAsync>();
builder.Services.AddScoped<IRoleRepositoryAsync, RoleRepositoryAsync>();
builder.Services.AddScoped<IUserRoleRepositoryAsync, UserRoleRepositoryAsync>();

//// Dependency injection for services
builder.Services.AddScoped<IAccountServiceAsync, AccountServiceAsync>();
builder.Services.AddScoped<IUserRoleServiceAsync, UserRoleServiceAsync>();
builder.Services.AddScoped<IRoleServiceAsync, RoleServiceAsync>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors();
app.Run();

