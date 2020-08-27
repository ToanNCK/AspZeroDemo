#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/AspZeroDemo.AbpZeroDemo.Web.Mvc/AspZeroDemo.AbpZeroDemo.Web.Mvc.csproj", "src/AspZeroDemo.AbpZeroDemo.Web.Mvc/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Web.Core/AspZeroDemo.AbpZeroDemo.Web.Core.csproj", "src/AspZeroDemo.AbpZeroDemo.Web.Core/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Application/AspZeroDemo.AbpZeroDemo.Application.csproj", "src/AspZeroDemo.AbpZeroDemo.Application/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Application.Shared/AspZeroDemo.AbpZeroDemo.Application.Shared.csproj", "src/AspZeroDemo.AbpZeroDemo.Application.Shared/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Core.Shared/AspZeroDemo.AbpZeroDemo.Core.Shared.csproj", "src/AspZeroDemo.AbpZeroDemo.Core.Shared/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.Core/AspZeroDemo.AbpZeroDemo.Core.csproj", "src/AspZeroDemo.AbpZeroDemo.Core/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.EntityFrameworkCore/AspZeroDemo.AbpZeroDemo.EntityFrameworkCore.csproj", "src/AspZeroDemo.AbpZeroDemo.EntityFrameworkCore/"]
COPY ["src/AspZeroDemo.AbpZeroDemo.GraphQL/AspZeroDemo.AbpZeroDemo.GraphQL.csproj", "src/AspZeroDemo.AbpZeroDemo.GraphQL/"]
RUN dotnet restore "src/AspZeroDemo.AbpZeroDemo.Web.Mvc/AspZeroDemo.AbpZeroDemo.Web.Mvc.csproj"
COPY . .
WORKDIR "/src/src/AspZeroDemo.AbpZeroDemo.Web.Mvc"
RUN dotnet build "AspZeroDemo.AbpZeroDemo.Web.Mvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AspZeroDemo.AbpZeroDemo.Web.Mvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AspZeroDemo.AbpZeroDemo.Web.Mvc.dll"]
