#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/apiGateways/AspnetMicroservices.Shopping.Aggregator/AspnetMicroservices.Shopping.Aggregator.csproj", "src/apiGateways/AspnetMicroservices.Shopping.Aggregator/"]
RUN dotnet restore "src/apiGateways/AspnetMicroservices.Shopping.Aggregator/AspnetMicroservices.Shopping.Aggregator.csproj"
COPY . .
WORKDIR "/src/src/apiGateways/AspnetMicroservices.Shopping.Aggregator"
RUN dotnet build "AspnetMicroservices.Shopping.Aggregator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspnetMicroservices.Shopping.Aggregator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspnetMicroservices.Shopping.Aggregator.dll"]
