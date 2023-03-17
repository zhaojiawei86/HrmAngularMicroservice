#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
ENV HrmRecruitDb="Data Source=10.0.0.246,1433;Initial Catalog=HrmRecruitDb;User Id=sa;Password=SGF86pop;TrustServerCertificate=True"
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Hrm.Recruitment.APILayer/Hrm.Recruitment.APILayer.csproj", "Hrm.Recruitment.APILayer/"]
COPY ["Hrm.Recruitment.ApplicationCore/Hrm.Recruitment.ApplicationCore.csproj", "Hrm.Recruitment.ApplicationCore/"]
COPY ["Hrm.Recruitment.Infrastructure/Hrm.Recruitment.Infrastructure.csproj", "Hrm.Recruitment.Infrastructure/"]
RUN dotnet restore "Hrm.Recruitment.APILayer/Hrm.Recruitment.APILayer.csproj"
COPY . .
WORKDIR "/src/Hrm.Recruitment.APILayer"
RUN dotnet build "Hrm.Recruitment.APILayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hrm.Recruitment.APILayer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hrm.Recruitment.APILayer.dll"]
