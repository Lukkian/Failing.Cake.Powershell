#tool nuget:?package=NUnit.ConsoleRunner&version=3.9.0
#addin nuget:?package=Cake.Powershell&version=0.4.7

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var version = Argument("version", "1.0.0.12");
var configuration = Argument("configuration", "Release");
var publishpath = Argument("publishpath", "./artifacts/publish");
var solutionpath = Argument("solutionpath", "./src/Example.sln");
var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
var buildDir = Directory("./src/Example/bin") + Directory(configuration);
var publishDir = Directory(publishpath);

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{
    Information($"Cleaning: {buildDir}");
    CleanDirectory(buildDir);
    Information($"Cleaning: {publishDir}");
    CleanDirectory(publishDir);
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore("./src/Example.sln");
});

Task("Set-AssemblyInfo-Version")
    .Description("Set the version in all the AssemblyInfo.cs or AssemblyInfo.vb files in any subdirectory.")
    .Does(() =>
{
    StartPowershellFile("./SetAssemblyInfoVersion.ps1", args =>
        {
            args.Append("Version", version);
        });
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .IsDependentOn("Set-AssemblyInfo-Version")
    .Does(() =>
{
    if(IsRunningOnWindows())
    {
      // Use MSBuild
      MSBuild(solutionpath, settings =>
        settings.SetConfiguration(configuration)
        .SetVerbosity(Verbosity.Quiet));
    }
    else
    {
      // Use XBuild
      XBuild(solutionpath, settings =>
        settings.SetConfiguration(configuration)
        .SetVerbosity(Verbosity.Quiet));
    }
});

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
    NUnit3("./src/**/bin/" + configuration + "/*.Tests.dll", new NUnit3Settings {
        NoResults = true
        });
});

Task("Publish-ClickOnce")
    .IsDependentOn("Run-Unit-Tests")
    .Does(() =>
{
    Information("Run a script (omitted for brevity) to publish a ClickOnce package...");
});

Task("Restore-AssemblyInfo-Version")
    .IsDependentOn("Publish-ClickOnce")
    .Description("Restore the default version in all the AssemblyInfo.cs or AssemblyInfo.vb files in any subdirectory.")
    .Does(() =>
{
    StartPowershellFile("./SetAssemblyInfoVersion.ps1", args =>
        {
            args.Append("Version", "1.0.0.0");
        });
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Restore-AssemblyInfo-Version");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
