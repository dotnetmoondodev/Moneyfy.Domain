# Moneyfy.Domain
Domain layer for Moneyfy Solution

## Create and publish package
```powershell
$version="1.0.2"
$owner="dotnetmoondodev"
$gh_pat=""

dotnet pack .\domain --configuration Release -p:PackageVersion=$version -p:RepositoryUrl=https://github.com/$owner/Moneyfy.Domain -o packages

dotnet nuget push packages\Moneyfy.Domain.$version.nupkg --api-key $gh_pat --source "github"
```