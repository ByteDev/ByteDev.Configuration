string GetBuildConfiguration()
{
	if(HasArgument("Configuration"))
	{
		return Argument<string>("Configuration");
	}

	return EnvironmentVariable("Configuration") != null ? 
		EnvironmentVariable("Configuration") : 
		"Release";
}

string GetNuGetVersion()
{
	var settings = new GitVersionSettings
	{
		OutputType = GitVersionOutput.Json
	};

	GitVersion versionInfo = GitVersion(settings);

	Information("GitVersion:");
	Information(versionInfo.Dump<GitVersion>());

	return versionInfo.NuGetVersion;
}

void CleanObjDirectories()
{
	CleanDirectories(GetDirectories("../src/**/obj"));
	CleanDirectories(GetDirectories("../test/**/obj"));
}

void CleanBinDirectories()
{	
	CleanDirectories(GetDirectories("../src/**/bin"));
	CleanDirectories(GetDirectories("../test/**/bin"));
}

FilePathCollection GetUnitTestProjFiles()
{
	return GetFiles("../test/*.UnitTests/**/*.csproj");
}

FilePathCollection GetIntTestProjFiles()
{
	return GetFiles("../test/*.IntTests/**/*.csproj");
}

FilePathCollection GetPackageTestCoreProjFiles()
{
	return GetFiles("../test/*.NetCore*PackageTests/*.csproj");
}

void DotNetCoreTests(FilePathCollection projects, DotNetCoreTestSettings settings)
{
	foreach(var project in projects)
	{
		DotNetCoreTest(project.FullPath, settings);
	}
}

void DotNetCoreUnitTests(DotNetCoreTestSettings settings)
{
	var projects = GetUnitTestProjFiles();

	DotNetCoreTests(projects, settings);
}

void DotNetCoreIntTests(DotNetCoreTestSettings settings)
{
	var projects = GetIntTestProjFiles();

	DotNetCoreTests(projects, settings);
}

void DotNetCorePackageTests(DotNetCoreTestSettings settings)
{
	var projects = GetPackageTestCoreProjFiles();

	DotNetCoreTests(projects, settings);
}

void NetFrameworkUnitTests(string configuration)
{
	var assemblies = GetFiles($"../test/*UnitTests/bin/{configuration}/**/*.UnitTests.dll");
		
	NUnit3(assemblies);
}

void NetFrameworkIntTests(string configuration)
{
	var assemblies = GetFiles($"../test/*IntTests/bin/{configuration}/**/*.IntTests.dll");
		
	NUnit3(assemblies);
}

void NetFrameworkPackageTests(string configuration)
{
	var assemblies = GetFiles($"../test/*.Net4*.PackageTests/bin/{configuration}/**/*.PackageTests.dll");
		
	NUnit3(assemblies);
}