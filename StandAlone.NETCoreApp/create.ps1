docker build -t sheyenrath/wiremock.net -f .\Dockerfile .
docker tag sheyenrath/wiremock.net:latest sheyenrath/wiremock.net:1.8.5
docker rmi $(docker images -f "dangling=true" -q)
docker images