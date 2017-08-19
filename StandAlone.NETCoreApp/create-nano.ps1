remove-item latest -Recurse
new-item latest\src\StandAlone.NETCoreApp -itemtype directory

robocopy ..\..\WireMock.Net\src\ latest\src *.cs *.csproj /s /NFL /NDL /NJH /NJS /nc /ns /np

Copy-Item .\* -Include "*.cs","*.latest.csproj" -Destination .\latest\src\StandAlone.NETCoreApp

docker build -t sheyenrath/wiremock.net-nano  -f .\Dockerfile.latest.nano .

# delete dangling images
docker rmi $(docker images -f "dangling=true" -q)

# tag with:
# docker tag sheyenrath/wiremock.net-nano:latest sheyenrath/wiremock.net-nano:1.0.0-preview-1

# push with:
# docker push sheyenrath/wiremock.net-nano:1.0.0-preview-1

# run with  : docker run --rm -p 9091:80 sheyenrath/wiremock.net-nano
