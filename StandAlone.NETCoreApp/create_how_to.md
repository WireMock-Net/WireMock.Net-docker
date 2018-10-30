# How to create images for Windows-Nano and Linux

## Windows Nano

### 1. Build

``` cmd
docker build -t sheyenrath/wiremock.net-nano  -f .\Dockerfile.nano .
```

### 2. Delete dangling images

``` cmd
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag

``` cmd
docker tag sheyenrath/wiremock.net-nano:latest sheyenrath/wiremock.net-nano:1.0.4.18
```

### 4. Push

``` cmd
docker push sheyenrath/wiremock.net-nano:latest
docker push sheyenrath/wiremock.net-nano:1.0.4.18
```

## Linux

### 1. Build

``` sh
docker build -t sheyenrath/wiremock.net -f .\Dockerfile .
```

### 2. Delete dangling images

``` sh
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag

``` sh
docker tag sheyenrath/wiremock.net:latest sheyenrath/wiremock.net:1.0.4.18
```

### 4. Push

``` sh
docker push sheyenrath/wiremock.net:latest
docker push sheyenrath/wiremock.net:1.0.4.18
```