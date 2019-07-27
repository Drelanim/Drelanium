

Prerequisites
---------------

Install any edition of Visual Studio 2017 from visualstudio.com with any .NET-related workload. Visual Studio 2017 automatically includes NuGet capabilities when a .NET workload is installed.

Install the nuget.exe CLI by downloading it from nuget.org, saving that .exe file to a suitable folder, and adding that folder to your PATH environment variable.


Alternately, if you have the .NET Core SDK installed, you can use the dotnet CLI.

Register for a free account on nuget.org if you don't have one already. Creating a new account sends a confirmation email. You must confirm the account before you can upload a package.


this project
-------------

Goal:

Build a Nuget package out of the ServiceTestClasses c# library project used in various other test projects for REST API access
Put the nuget up for offline usage on the local machine (instead of uploading to a Nuget repo)
Rebuild solutions using this library with the offline nuget and see if it works.

execution:

a)  Nuget.exe was stored  at C:\nuget\nuget.exe and parent dir added to PATH using System control panel app

b) created a solution for the nuget, copied the ServiceTestClasses c# class library project into it and rebuilt it in Release configuration

c) configure project's package properties

A NuGet package contains a manifest (a .nuspec file), that contains relevant metadata such as the package identifier, version number, description, and more. Some of these can be drawn from the project properties directly, which avoids having to separately update them in both the project and the manifest. This section describes where to set the applicable properties.
Select the Project > Properties menu command, then select the Application tab.
In the Assembly name field, give your package a unique identifier.
You must give the package an identifier that's unique across nuget.org or whatever host you're using. For this walkthrough we recommend including "Sample" or "Test" in the name as the later publishing step does make the package publicly visible (though it's unlikely anyone will actually use it).
If you attempt to publish a package with a name that already exists, you see an error.
Select the Assembly Information... button, which brings up a dialog box in which you can enter other properties that carry into the manifest (see .nuspec file reference - replacement tokens). The most commonly used fields are Title, Description, Company, Copyright, and Assembly version. These properties ultimately appear with your package on a host like nuget.org, so make sure they're fully descriptive.
Optional: to see and edit the properties directly, open the Properties/AssemblyInfo.cs file in the project.
When the properties are set, set the project configuration to Release and rebuild the project to generate the updated DLL.

d) generate the initial manifest from command line

C:\Users\arpad_polan\Desktop\Nuget Package Building and Publishing\ServiceClassesNuget\ServiceTestClasses>nuget spec ServiceTestClasses.csproj
Created 'ServiceTestClasses.nuspec' successfully.
C:\Users\arpad_polan\Desktop\Nuget Package Building and Publishing\ServiceClassesNuget\ServiceTestClasses>

e) edit the manifest (see 2012_Bookmatter_ProNuGet.pdf what is manadatory and what is not)

<?xml version="1.0"?>
<package >
  <metadata>
    <id>$id$</id>
    <version>$version$</version>
    <title>MyServiceClasses</title>
    <authors>Arpad</authors>
    <owners>Arpad</owners>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>this is a long description here....la la laaaaaaaaaaaaaa ,long enough?</description>
    <releaseNotes>First release.</releaseNotes>
    <copyright>Copyright 2018</copyright>
    <tags>DOTNET RESTAPI LIBRARY</tags>
  </metadata>
</package>

f) finally generate the nuget package from command line

C:\Users\arpad_polan\Desktop\Nuget Package Building and Publishing\ServiceClassesNuget\ServiceTestClasses>nuget pack -Properties Configuration=Release
Attempting to build package from 'ServiceTestClasses.csproj'.
MSBuild auto-detection: using msbuild version '15.8.168.64424' from 'C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\bin'.
Packing files from 'C:\Users\arpad_polan\Desktop\Nuget Package Building and Publishing\ServiceClassesNuget\ServiceTestClasses\bin\Release'.
Using 'ServiceTestClasses.nuspec' for metadata.
Found packages.config. Using packages listed as dependencies
Successfully created package 'C:\Users\arpad_polan\Desktop\Nuget Package Building and Publishing\ServiceClassesNuget\ServiceTestClasses\ArpieServiceClasses.1.0.0.nupkg'.

g) offline publishing is simple, just place the nupkg file in a local directory and add a package source to it

h) inhaling an offline nuget created this way was verified by using this library nuget in an already existing solution that used the same library as an embedded library project before.
Worked like a charm.