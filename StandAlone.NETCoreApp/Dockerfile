FROM microsoft/dotnet:2.0-sdk AS build-env

MAINTAINER Stef Heyenrath

WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# copy everything else and build
COPY . ./
RUN dotnet publish -c Release -r linux-x64 -o out

# build runtime image
FROM microsoft/dotnet:2.0-runtime-deps
WORKDIR /app
COPY --from=build-env /app/out ./
EXPOSE 80
ENTRYPOINT ["./wiremock-net", "--Urls", "http://*:80", "--ReadStaticMappings", "false"]

# Just some info:
# build with : docker build -t wiremock-net .
# run with   : docker run --rm -p 9090:80 wiremock-net