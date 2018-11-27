FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["src/fuwo.Web.Host/fuwo.Web.Host.csproj", "src/fuwo.Web.Host/"]
COPY ["src/fuwo.Web.Core/fuwo.Web.Core.csproj", "src/fuwo.Web.Core/"]
COPY ["src/fuwo.Application/fuwo.Application.csproj", "src/fuwo.Application/"]
COPY ["src/fuwo.Core/fuwo.Core.csproj", "src/fuwo.Core/"]
COPY ["src/fuwo.EntityFrameworkCore/fuwo.EntityFrameworkCore.csproj", "src/fuwo.EntityFrameworkCore/"]
RUN dotnet restore "src/fuwo.Web.Host/fuwo.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/fuwo.Web.Host"
RUN dotnet build "fuwo.Web.Host.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "fuwo.Web.Host.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "fuwo.Web.Host.dll"]