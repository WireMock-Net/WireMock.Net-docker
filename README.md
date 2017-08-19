# WireMock.Net-docker
WireMock.Net-docker is a Docker image which runs [WireMock.Net](https://github.com/WireMock-Net) (a flexible library for stubbing and mocking web HTTP responses using request-matching criteria.)

## The image includes

- `EXPOSE 80` : The wiremock http server port

## How to use this image

#### Getting started

##### Pull latest image (Linux container)

```sh
docker pull sheyenrath/wiremock.net
```

##### Start a WireMock.Net container (Linux container)

```sh
docker run -it --rm -p 9091:80 sheyenrath/wiremock.net
```

> Access [http://localhost:9091/__admin/settings](http://localhost:9091/__admin/mappings) to display the mappings.

For more commands see [WIKI](https://github.com/WireMock-Net/WireMock.Net/wiki)