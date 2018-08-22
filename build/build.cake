#addin "nuget:?package=Cake.Incubator&version=2.0.0"
#tool "nuget:?package=NUnit.ConsoleRunner"

var nugetSources = new[] {"https://api.nuget.org/v3/index.json"};

var target = Argument("target", "Default");

var solutionFilePath = "../src/ByteDev.Configuration.sln";

var artifactsDirectory = Directory("../artifacts");
var nugetDirectory = artifactsDirectory + Directory("NuGet");
	
// Configuration - The build configuration (Debug/Release) to use.
// 1. If command line parameter parameter passed, use that.
// 2. Otherwise if an Environment variable exists, use that.
var configuration = 
    HasArgument("Configuration") ? Argument<string>("Configuration") :
    EnvironmentVariable("Configuration") != null ? EnvironmentVariable("Configuration") : "Release";
	
Information("Configurtion: " + configuration);


Task("Clean")
    .Does(() =>
{
    CleanDirectory(artifactsDirectory);
	
	var binDirs = GetDirectories("../src/**/bin");
	var objDirs = GetDirectories("../src/**/obj");

	CleanDirectories(binDirs);
	CleanDirectories(objDirs);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
    {
		var settings = new NuGetRestoreSettings
		{
			Source = nugetSources
		};

		NuGetRestore(solutionFilePath, settings);
    });

Task("Build")
	.IsDependentOn("Restore")
    .Does(() =>
	{	
        DotNetCoreBuild(
            solutionFilePath,
            new DotNetCoreBuildSettings()
            {
                Configuration = configuration
            });
	});

Task("UnitTests")
    .IsDependentOn("Build")
    .Does(() =>
	{
		var assemblies = GetFiles("../src/*UnitTests/bin/" + configuration + "/**/*UnitTests.dll");
		
		NUnit3(assemblies);
	});
	
Task("CreateNuGetPackages")
    .IsDependentOn("UnitTests")
    .Does(() =>
    {
        var settings = new DotNetCorePackSettings()
		{
			Configuration = configuration,
			OutputDirectory = nugetDirectory
		};
                
		DotNetCorePack("../src/ByteDev.Configuration/ByteDev.Configuration.csproj", settings);
    });

   
Task("Default")
    .IsDependentOn("CreateNuGetPackages");

RunTarget(target);