docker build -t sheyenrath/wiremock.net-nanoserver-2004  -f .\Dockerfile.nanoserver-2004 .
docker rmi $(docker images -f "dangling=true" -q)
docker images