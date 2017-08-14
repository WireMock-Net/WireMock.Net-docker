remove-item latest -Recurse
new-item latest\src\StandAlone.NETCoreApp -itemtype directory

robocopy ..\..\WireMock.Net\src\ latest\src *.cs *.csproj /s /NFL /NDL /NJH /NJS /nc /ns /np

Copy-Item .\* -Include "*.cs","*.latest.csproj" -Destination .\latest\src\StandAlone.NETCoreApp

docker build -t wiremock-net  -f .\Dockerfile.latest .