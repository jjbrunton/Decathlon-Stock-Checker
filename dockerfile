# https://hub.docker.com/_/microsoft-dotnet-core
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.csproj .
RUN dotnet restore -r linux-arm

# copy and publish app and libraries
COPY . .
WORKDIR /source
RUN dotnet publish -c release -o out -r linux-arm

# final stage/image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim-arm32v7
WORKDIR /source
COPY --from=build /source/out ./
ENTRYPOINT ["dotnet", "DecathlonStock.dll"]