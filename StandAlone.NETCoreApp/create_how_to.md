# How to manually create image for Windows-Nano

## Windows Nano 1809

### 1. Build

``` cmd
docker build -t sheyenrath/wiremock.net-nanoserver-1809 -f .\Dockerfile.nanoserver-1809 .
```

### 2. Delete dangling images

``` ps
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag

``` cmd
docker tag sheyenrath/wiremock.net-nanoserver-1809:latest sheyenrath/wiremock.net-nanoserver-1809:1.1.9
```

### 4. Push

``` cmd
docker push sheyenrath/wiremock.net-nanoserver-1809:latest
docker push sheyenrath/wiremock.net-nanoserver-1809:1.1.9
```