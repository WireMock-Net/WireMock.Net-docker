dotnet restore

# Copy all *.nupkg files from all directories ending with /Release
$sourcePath = "C:\dev\GitHub\WireMock.Net\src"
$destinationPath = ".\NuGetForDocker"
Get-ChildItem -Path $sourcePath -Recurse -Filter *.nupkg | Where-Object { $_.FullName -like "*\Release\*" } | Copy-Item -Destination $destinationPath -Force

docker build -t sheyenrath/wiremock.net-alpine -f .\Dockerfile.alpine .
docker rmi $(docker images -f "dangling=true" -q)
docker images