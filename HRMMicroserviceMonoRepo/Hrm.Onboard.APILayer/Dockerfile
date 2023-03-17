#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
ENV HrmOnboardDb="Data Source=10.0.0.246,1433;Initial Catalog=HrmOnboardDb;User Id=sa;Password=SGF86pop;TrustServerCertificate=True"
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Hrm.Onboard.APILayer/Hrm.Onboard.APILayer.csproj", "Hrm.Onboard.APILayer/"]
COPY ["Hrm.Onboard.ApplicationCore/Hrm.Onboard.ApplicationCore.csproj", "Hrm.Onboard.ApplicationCore/"]
COPY ["Hrm.Onboard.Infrastructure/Hrm.Onboard.Infrastructure.csproj", "Hrm.Onboard.Infrastructure/"]
RUN dotnet restore "Hrm.Onboard.APILayer/Hrm.Onboard.APILayer.csproj"
COPY . .
WORKDIR "/src/Hrm.Onboard.APILayer"
RUN dotnet build "Hrm.Onboard.APILayer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hrm.Onboard.APILayer.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hrm.Onboard.APILayer.dll"]
