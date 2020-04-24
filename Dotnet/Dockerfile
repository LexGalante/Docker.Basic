FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /build

COPY *.sln .
COPY ["src/*.csproj", "./src/"]
RUN dotnet restore

COPY src/. ./src/
WORKDIR /build/src
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "Example.dll"]