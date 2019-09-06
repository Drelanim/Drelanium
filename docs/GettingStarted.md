## Getting started

#### 1) Create any kind of.NET Core project, and change the .csproj to the following

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework>
  </PropertyGroup>
</Project>
```

#### 2) Choose a Test Framework

If the purpose of the project is to execute tests, then it should contain a Test Framework.   
Open a cmd in the directory of the .NET Core project and use the following dotnet commands

###### 2.1 Using MSTest Test framework:
```console
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package MSTest.TestFramework
dotnet add package MSTest.TestAdapter
```

###### 2.2 Using NUnit Test framework:
```console
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package nunit
dotnet add package NUnit3TestAdapter
```

###### 2.3 Using xUnit Test framework:
```console
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
```

