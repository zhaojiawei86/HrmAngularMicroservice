using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.Infrastructure.Data;
using Hrm.Onboard.Infrastructure.Repsoitory;
using Hrm.Onboard.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("HrmOnboardDb");
var dockerConnStr = Environment.GetEnvironmentVariable("HrmOnboardDb");
builder.Services.AddDbContext<OnboardDbContext>(options =>
{
    //options.UseSqlServer(connectionString);
    options.UseSqlServer(dockerConnStr);
});

// Dependency injection for repositories
builder.Services.AddScoped<IEmployeeRepositoryAsync, EmployeeRepositoryAsync>();
builder.Services.AddScoped<IEmployeeCategoryRepositoryAsync, EmployeeCategoryRepositoryAsync>();
builder.Services.AddScoped<IEmployeeRoleRepositoryAsync, EmployeeRoleRepositoryAsync>();
builder.Services.AddScoped<IEmployeeStatusRepositoryAsync, EmployeeStatusRepositoryAsync>();

// Dependency injection for services
builder.Services.AddScoped<IEmployeeServiceAsync, EmployeeServiceAsync>();
builder.Services.AddScoped<IEmployeeCategoryServiceAsync, EmployeeCategoryServiceAsync>();
builder.Services.AddScoped<IEmployeeRoleServiceAsync, EmployeeRoleServiceAsync>();
builder.Services.AddScoped<IEmployeeStatusServiceAsync, EmployeeStatusServiceAsync>();

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

