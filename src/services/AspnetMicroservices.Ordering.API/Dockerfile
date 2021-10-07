#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/services/AspnetMicroservices.Ordering.API/AspnetMicroservices.Ordering.API.csproj", "src/services/AspnetMicroservices.Ordering.API/"]
COPY ["src/services/AspnetMicroservices.Ordering.Application/AspnetMicroservices.Ordering.Application.csproj", "src/services/AspnetMicroservices.Ordering.Application/"]
COPY ["src/services/AspnetMicroservices.Ordering.Domain/AspnetMicroservices.Ordering.Domain.csproj", "src/services/AspnetMicroservices.Ordering.Domain/"]
COPY ["src/services/AspnetMicroservices.Ordering.Infrastructure/AspnetMicroservices.Ordering.Infrastructure.csproj", "src/services/AspnetMicroservices.Ordering.Infrastructure/"]
RUN dotnet restore "src/services/AspnetMicroservices.Ordering.API/AspnetMicroservices.Ordering.API.csproj"
COPY . .
WORKDIR "/src/src/services/AspnetMicroservices.Ordering.API"
RUN dotnet build "AspnetMicroservices.Ordering.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspnetMicroservices.Ordering.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspnetMicroservices.Ordering.API.dll"]
