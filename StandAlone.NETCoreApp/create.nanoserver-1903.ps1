docker build -t sheyenrath/wiremock.net-nanoserver-1903  -f .\Dockerfile.nanoserver-1903 .
docker rmi $(docker images -f "dangling=true" -q)
docker images