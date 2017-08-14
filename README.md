# WireMock.Net-docker
WireMock.Net-docker is a Docker image which runs [WireMock-Net](https://github.com/WireMock-Net) (a flexible library for stubbing and mocking web services)

## Supported tags & respective Dockerfile links :

- `1.0.0`, `latest` [(1.0/Dockerfile)](https://github.com/https://github.com/WireMock-Net/WireMock.Net-docker/blob/1.0.0/Dockerfile)
- `1.0.0` [(1.0/Dockerfile)](https://github.com/https://github.com/WireMock-Net/WireMock.Net-docker/blob/1.0.0/Dockerfile)

## The image includes

- `EXPOSE 80` : the wiremock http server port

## How to use this image

#### Getting started

##### Pull latest image (Linux container)

```sh
docker pull sheyenrath/wiremock-net
```

##### Start a WireMock.Net container (Linux container)

```sh
docker run -it --rm -p 9090:80 sheyenrath/wiremock-net
```

> Access [http://localhost:9090/__admin/settings](http://localhost:9090/__admin/mappings) to display the mappings.

For more commands see [WIKI](https://github.com/WireMock-Net/WireMock.Net/wiki)
