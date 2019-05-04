# How to create images for Windows-Nano and Linux

## Windows Nano

### 1. Build

``` cmd
docker build -t sheyenrath/wiremock.net-nanoserver-1803 -f .\Dockerfile.nanoserver-1803 .
docker build -t sheyenrath/wiremock.net-nanoserver-1809 -f .\Dockerfile.nanoserver-1809 .
```

### 2. Delete dangling images

``` ps
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag

``` cmd
docker tag sheyenrath/wiremock.net-nanoserver-1803:latest sheyenrath/wiremock.net-nanoserver-1803:1.0.15
docker tag sheyenrath/wiremock.net-nanoserver-1809:latest sheyenrath/wiremock.net-nanoserver-1809:1.0.15
```

### 4. Push

``` cmd
docker push sheyenrath/wiremock.net-nanoserver-1803:latest
docker push sheyenrath/wiremock.net-nanoserver-1803:1.0.15
docker push sheyenrath/wiremock.net-nanoserver-1809:latest
docker push sheyenrath/wiremock.net-nanoserver-1809:1.0.15
```

## Linux

### 1. Build

``` cmd
docker build -t sheyenrath/wiremock.net -f .\Dockerfile .
```

### 2. Delete dangling images

``` cmd
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag

``` cmd
docker tag sheyenrath/wiremock.net:latest sheyenrath/wiremock.net:1.0.15
```

### 4. Push

``` cmd
docker push sheyenrath/wiremock.net:latest
docker push sheyenrath/wiremock.net:1.0.15
```