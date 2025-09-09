# Imagen base de .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar solución y restaurar dependencias
COPY ["CarBrands.API/CarBrands.API.csproj", "CarBrands.API/"]
COPY ["CarBrands.Application/CarBrands.Application.csproj", "CarBrands.Application/"]
COPY ["CarBrands.Infrastructure/CarBrands.Infrastructure.csproj", "CarBrands.Infrastructure/"]
COPY ["CarBrands.Domain/CarBrands.Domain.csproj", "CarBrands.Domain/"]
RUN dotnet restore "CarBrands.API/CarBrands.API.csproj"

# Copiar todo y compilar
COPY . .
WORKDIR "/src/CarBrands.API"
RUN dotnet publish "CarBrands.API.csproj" -c Release -o /app/publish

# Imagen runtime de .NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CarBrands.API.dll"]
