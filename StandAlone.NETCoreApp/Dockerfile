FROM mcr.microsoft.com/dotnet/core/sdk:5.0 AS build-env

LABEL maintainer="Stef Heyenrath"

WORKDIR /app

# copy csproj and restore as distinct layers
COPY StandAlone.NETCoreApp.csproj ./
RUN dotnet restore

# copy everything else and build
COPY *.cs ./
RUN dotnet publish -c Release -r linux-x64 -o out

# build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal
WORKDIR /app
COPY --from=build-env /app/out ./
EXPOSE 80
ENTRYPOINT ["./wiremock-net", "--Urls", "http://*:80"]
CMD ["--WireMockLogger", "WireMockConsoleLogger"]

# Just some info:
# build with : docker build -t sheyenrath/wiremock.net .
# run with   : docker run --rm -p 9091:80 sheyenrath/wiremock.net
