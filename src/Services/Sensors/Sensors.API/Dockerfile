FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

COPY ["src/Services/Sensors/Sensors.API/Sensors.API.csproj", "src/Services/Sensors/Sensors.API/"]
COPY ["src/Services/Sensors/Sensors.API/Domain/Domain.csproj", "src/Services/Sensors/Sensors.API/Domain/"]

RUN dotnet restore "src/Services/Sensors/Sensors.API/Sensors.API.csproj"
COPY . .
WORKDIR src/Services/Sensors/Sensors.API/
RUN dotnet publish "Sensors.API.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "aspnetapp.dll"]FROM 
