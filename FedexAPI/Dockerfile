FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FedexAPI/FedexAPI.csproj", "FedexAPI/"]
RUN dotnet restore "FedexAPI/FedexAPI.csproj"
COPY . .
WORKDIR "/src/FedexAPI"
RUN dotnet build "FedexAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FedexAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FedexAPI.dll"]
