docker build -t sheyenrath/wiremock.net-nanoserver-1909  -f .\Dockerfile.nanoserver-1909 .
docker rmi $(docker images -f "dangling=true" -q)
docker images