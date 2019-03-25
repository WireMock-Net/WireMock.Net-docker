docker build -t sheyenrath/wiremock.net-nanoserver-1803  -f .\Dockerfile.nanoserver-1803 .
docker rmi $(docker images -f "dangling=true" -q)
docker images