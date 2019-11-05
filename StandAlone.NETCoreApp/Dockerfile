FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env

LABEL maintainer="Stef Heyenrath"

WORKDIR /app

# copy csproj and restore as distinct layers
COPY StandAlone.NETCoreApp.csproj ./
RUN dotnet restore

# copy everything else and build
COPY *.cs ./
RUN dotnet publish -c Release -r linux-x64 -o out

# build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY --from=build-env /app/out ./
EXPOSE 80
ENTRYPOINT ["./wiremock-net", "--Urls", "http://*:80"]
CMD ["--WireMockLogger", "WireMockConsoleLogger"]

# Just some info:
# build with : docker build -t wiremock.net .
# run with   : docker run --rm -p 9090:80 wiremock.net