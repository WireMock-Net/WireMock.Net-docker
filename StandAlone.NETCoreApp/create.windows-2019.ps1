docker build -t sheyenrath/wiremock.net-windows-2019  -f .\Dockerfile.windows-2019 .
docker rmi $(docker images -f "dangling=true" -q)
docker images