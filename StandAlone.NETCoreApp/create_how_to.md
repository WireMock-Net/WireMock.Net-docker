# Nano
## Commands
### 1. Build
```
docker build -t sheyenrath/wiremock.net-nano  -f .\Dockerfile.nano .
```

### 2. Delete dangling images
```
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag
```
docker tag sheyenrath/wiremock.net-nano:latest sheyenrath/wiremock.net-nano:1.0.4.18
```

### 4. Push
```
docker push sheyenrath/wiremock.net-nano:latest
docker push sheyenrath/wiremock.net-nano:1.0.4.18
```


# Linux
## Commands
### 1. Build
```
docker build -t sheyenrath/wiremock.net -f .\Dockerfile .
```

### 2. Delete dangling images
```
docker rmi $(docker images -f "dangling=true" -q)
```

### 3. Tag
```
docker tag sheyenrath/wiremock.net:latest sheyenrath/wiremock.net:1.0.4.18
```

### 4. Push
```
docker push sheyenrath/wiremock.net:latest
docker push sheyenrath/wiremock.net:1.0.4.18
```