#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/AspZeroDemo.AbpZeroDemo.Migrator/AspZeroDemo.AbpZeroDemo.Migrator.csproj", "src/AspZeroDemo.AbpZeroDemo.Migrator/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.EntityFrameworkCore/AspZeroDemo.AbpZeroDemo.EntityFrameworkCore.csproj", "src/AspZeroDemo.AbpZeroDemo.EntityFrameworkCore/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Core/AspZeroDemo.AbpZeroDemo.Core.csproj", "src/AspZeroDemo.AbpZeroDemo.Core/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Core.Shared/AspZeroDemo.AbpZeroDemo.Core.Shared.csproj", "src/AspZeroDemo.AbpZeroDemo.Core.Shared/"]
RUN dotnet restore "src/AspZeroDemo.AbpZeroDemo.Migrator/AspZeroDemo.AbpZeroDemo.Migrator.csproj"
COPY . .
WORKDIR "/src/src/AspZeroDemo.AbpZeroDemo.Migrator"
RUN dotnet build "AspZeroDemo.AbpZeroDemo.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspZeroDemo.AbpZeroDemo.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspZeroDemo.AbpZeroDemo.Migrator.dll"]
