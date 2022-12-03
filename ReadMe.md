To Create SPEC file use the following command :
C:\NuGetJfrogIntegration\NuGetExe\nuget.exe spec .\MyCalc\MyCalc.csproj 
C:\NuGetJfrogIntegration\NuGetExe\nuget.exe spec .\TestMyCalc\TestMyCalc.csproj 


nuget pack TestDemo.csproj.nuspec


Generate Nuget packages for MyCalc Project 
nuget pack .\MyCalc\MyCalc.csproj.nuspec

Generate Nuget packages for TestMyCalc Project
pack .\TestMyCalc\TestMyCalc.csproj.nuspec