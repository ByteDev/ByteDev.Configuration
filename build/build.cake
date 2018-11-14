#addin nuget:?package=Cake.Incubator&version=3.0.0
#tool "nuget:?package=NUnit.ConsoleRunner"
#load "ByteDev.Utilities.cake"

var nugetSources = new[] {"https://api.nuget.org/v3/index.json"};

var target = Argument("target", "Default");

var repoName = "ByteDev.Configuration";

var solutionFilePath = $"../src/{repoName}.sln";

var artifactsDirectory = Directory("../artifacts");
var nugetDirectory = artifactsDirectory + Directory("NuGet");
	
var configuration = GetBuildConfiguration();
	
Information("Configurtion: " + configuration);


Task("Clean")
    .Does(() =>
	{
		CleanDirectory(artifactsDirectory);

		CleanBinDirectories();
		CleanObjDirectories();
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
		var settings = new DotNetCoreBuildSettings()
        {
            Configuration = configuration
        };

        DotNetCoreBuild(solutionFilePath, settings);
	});

Task("UnitTests")
    .IsDependentOn("Build")
    .Does(() =>
	{
		var assemblies = GetFiles($"../src/*UnitTests/bin/{configuration}/**/*.UnitTests.dll");
		
		NUnit3(assemblies);
	});
	
Task("CreateNuGetPackages")
    .IsDependentOn("UnitTests")
    .Does(() =>
    {
		var nugetVersion = GetNuGetVersion();

        var settings = new DotNetCorePackSettings()
		{
			ArgumentCustomization = args => args.Append("/p:Version=" + nugetVersion),
			Configuration = configuration,
			OutputDirectory = nugetDirectory
		};
                
		DotNetCorePack($"../src/{repoName}/ByteDev.Configuration.csproj", settings);
    });

   
Task("Default")
    .IsDependentOn("CreateNuGetPackages");

RunTarget(target);