using Azure.Storage.Blobs;
using Hrm.Recruitment.ApplicationCore.Contract.Repository;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.Infrastructure.Data;
using Hrm.Recruitment.Infrastructure.Repository;
using Hrm.Recruitment.Infrastructure.Service;
using JwtAuthenticationManager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCustomeJwtAuthentication();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(x => new BlobServiceClient(builder.Configuration.GetValue<string>("ResumeContainer")));
builder.Services.AddScoped<IBlobServiceAsync, BlobServiceAsync>();


var connectionString = builder.Configuration.GetConnectionString("HrmRecruitDb");
var dockerConnStr = Environment.GetEnvironmentVariable("HrmRecruitDb");
builder.Services.AddDbContext<RecruitDbContext>(options =>
{
    //options.UseSqlServer(connectionString);
    options.UseSqlServer(dockerConnStr);
});

// Dependency injection for repositories
builder.Services.AddScoped<ICandidateRepositoryAsync, CandidateRepositoryAsync>();
builder.Services.AddScoped<IJobCategoryRepositoryAsync, JobCategoryRepositoryAsync>();
builder.Services.AddScoped<IJobRequirementRepositoryAsync, JobRequirementRepositoryAsync>();
builder.Services.AddScoped<ISubmissionRepositoryAsync, SubmissionRepositoryAsync>();
builder.Services.AddScoped<ISubmissionStatusRepositoryAsync, SubmissionStatusRepositoryAsync>();

// Dependency injection for services
builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();
builder.Services.AddScoped<IJobCategoryServiceAsync, JobCategoryServiceAsync>();
builder.Services.AddScoped<IJobRequirementServiceAsync, JobRequirementServiceAsync>();
builder.Services.AddScoped<ISubmissionServiceAsync, SubmissionServiceAsync>();
builder.Services.AddScoped<ISubmissionStatusServiceAsync, SubmissionStatusServiceAsync>();


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
app.UseRouting();
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();

