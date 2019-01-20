# WireMock.Net-docker
WireMock.Net-docker is a Docker image which runs [WireMock.Net](https://github.com/WireMock-Net) (a flexible library for stubbing and mocking web HTTP responses using request-matching criteria.)

[![Gitter](https://img.shields.io/gitter/room/wiremock_dotnet/Lobby.svg)](https://gitter.im/wiremock_dotnet/Lobby)

## Linux

### Pull latest image

```sh
docker pull sheyenrath/wiremock.net
```

### Start the WireMock.Net container

```sh
docker run -it --rm -p 9091:80 sheyenrath/wiremock.net
```

## Windows Nano

### Pull latest image

```sh
docker pull sheyenrath/wiremock.net-nano
```

### Start the WireMock.Net container

```sh
docker run -it --rm -p 9091:80 sheyenrath/wiremock.net-nano
```

## Windows NanoServer 1803

### Pull latest image

```sh
docker pull sheyenrath/wiremock.net-nanoserver-1803
```

### Start the WireMock.Net container

```sh
docker run -it --rm -p 9091:80 sheyenrath/wiremock.net-nanoserver-1803
```

## Commands
For all possible commands, see this [WIKI - Commandlin Arguments](https://github.com/WireMock-Net/WireMock.Net-docker/wiki/Commandline-arguments)

## Using

> Access [http://localhost:9091/__admin/settings](http://localhost:9091/__admin/mappings) to display the mappings.

For more functionality, see [WIKI](https://github.com/WireMock-Net/WireMock.Net/wiki)