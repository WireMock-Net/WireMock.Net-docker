remove-item latest -Recurse
new-item latest\src\StandAlone.NETCoreApp -itemtype directory

robocopy ..\..\WireMock.Net\src\ latest\src *.cs *.csproj /s /NFL /NDL /NJH /NJS /nc /ns /np

Copy-Item .\* -Include "*.cs","*.latest.csproj" -Destination .\latest\src\StandAlone.NETCoreApp

docker build -t sheyenrath/wiremock.net  -f .\Dockerfile.latest .

# delete dangling images
docker rmi $(docker images -f "dangling=true" -q)

# tag with:
# docker tag sheyenrath/wiremock.net:latest sheyenrath/wiremock.net:1.0.4.5

# push with :
# docker push sheyenrath/wiremock.net:1.0.4.5

# run with :
# docker run --rm -p 9091:80 sheyenrath/wiremock.net
# or
# docker run --rm -p 9091:80 sheyenrath/wiremock.net --ReadStaticMappings false --AdminUsername a --AdminPassword b --MaxRequestLogCount 99 --RequestLogExpirationDuration 24
