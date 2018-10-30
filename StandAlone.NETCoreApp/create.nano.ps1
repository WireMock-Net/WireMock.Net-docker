docker build -t sheyenrath/wiremock.net-nano  -f .\Dockerfile.nano .
docker rmi $(docker images -f "dangling=true" -q)
docker images