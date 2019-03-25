docker build -t sheyenrath/wiremock.net-nanoserver-1809  -f .\Dockerfile.nanoserver-1809 .
docker rmi $(docker images -f "dangling=true" -q)
docker images