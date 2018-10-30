docker build -t sheyenrath/wiremock.net -f .\Dockerfile .
docker rmi $(docker images -f "dangling=true" -q)
docker images