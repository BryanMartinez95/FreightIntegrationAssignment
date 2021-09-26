FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["PurolatorAPI/PurolatorAPI.csproj", "PurolatorAPI/"]
RUN dotnet restore "PurolatorAPI/PurolatorAPI.csproj"
COPY . .
WORKDIR "/src/PurolatorAPI"
RUN dotnet build "PurolatorAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PurolatorAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PurolatorAPI.dll"]
