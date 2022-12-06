cd .\nugetOutput
nuget push *.nupkg -Source Artifactory
nuget push *.nupkg -Source https://shankonduru.jfrog.io/artifactory/api/nuget/shankonduru-nuget/MyCalculator
