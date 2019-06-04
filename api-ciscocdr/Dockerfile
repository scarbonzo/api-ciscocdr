FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["api-ciscocdr/api-ciscocdr.csproj", "api-ciscocdr/"]
RUN dotnet restore "api-ciscocdr/api-ciscocdr.csproj"
COPY . .
WORKDIR "/src/api-ciscocdr"
RUN dotnet build "api-ciscocdr.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "api-ciscocdr.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "api-ciscocdr.dll"]