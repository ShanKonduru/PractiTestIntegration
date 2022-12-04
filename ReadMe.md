
Steps to follow to create Nuget Packages from VS Code.


Create a folder named Nuget.Quickstart for the project.
Open a command prompt and switch to the new folder.
Create the project by using the following command:
dotnet new console
Use dotnet run to test the app. You should see the output Hello, World!
Use the following command to install the Newtonsoft.json package:
dotnet add package Newtonsoft.Json
After the command completes, open the Nuget.Quickstart.csproj file in Visual Studio to see the added NuGet package reference:
<ItemGroup>
  <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />
</ItemGroup>
In Visual Studio, open the Program.cs file and add the following line at the top of the file:
using Newtonsoft.Json;
Add the following code to replace the Console.WriteLine("Hello, World!"); statement:
namespace Nuget.Quickstart
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account
            {
                Name = "John Doe",
                Email = "john@nuget.org",
                DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
Save the file, then build and run the app by using the dotnet run command. The output is the JSON representation of the Account object in the code:
{
  "Name": "John Doe",
  "Email": "john@nuget.org",
  "DOB": "1980-02-20T00:00:00Z"
}
Congratulations on installing and using your first NuGet package!

Open a command line and switch to the directory that contains your project file.

Use the following command to install a NuGet package:

dotnet add package <PACKAGE_NAME>

For example, to install the Newtonsoft.Json package, use the following command

dotnet add package Newtonsoft.Json

To Create SPEC file use the following command :
C:\NuGetJfrogIntegration\NuGetExe\nuget.exe spec .\MyCalc\MyCalc.csproj 
C:\NuGetJfrogIntegration\NuGetExe\nuget.exe spec .\TestMyCalc\TestMyCalc.csproj 


nuget pack TestDemo.csproj.nuspec


Generate Nuget packages for MyCalc Project 
nuget pack .\MyCalc\MyCalc.csproj.nuspec

Generate Nuget packages for TestMyCalc Project
pack .\TestMyCalc\TestMyCalc.csproj.nuspec

dotnet pack -c release



nuget sources Add -Name Artifactory -Source https://shankonduru.jfrog.io/artifactory/api/nuget/v3/shankonduru-nuget -username shankonduru@gmail.com -password AKCp8nHPXkEA5DUwSoRSYtoUJkUaBGVDgoZX9gyjdS7CTqvRRAeRMPnzqwWx7sJLjkHnEqVCQ
