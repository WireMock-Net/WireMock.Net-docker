docker build -t sheyenrath/wiremock.net-alpine -f .\Dockerfile.alpine .
docker rmi $(docker images -f "dangling=true" -q)
docker images