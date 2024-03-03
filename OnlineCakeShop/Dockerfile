#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.



FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["OnlineCakeShop/OnlineCakeShop.csproj", "OnlineCakeShop/"]
COPY ["OnlineCakeShop.DataAccessLayer/OnlineCakeShop.DataAccessLayer.csproj", "OnlineCakeShop.DataAccessLayer/"]
COPY ["OnlineCakeShop.Entity/OnlineCakeShop.Entity.csproj", "OnlineCakeShop.Entity/"]
RUN dotnet restore "./OnlineCakeShop/OnlineCakeShop.csproj"
COPY . .
WORKDIR "/src/OnlineCakeShop"
RUN dotnet build "./OnlineCakeShop.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Generate and trust the development certificate
RUN dotnet dev-certs https -ep %sduka%\.aspnet\https\aspnetapp.pfx 
RUN dotnet dev-certs https --trust	

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./OnlineCakeShop.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OnlineCakeShop.dll"]