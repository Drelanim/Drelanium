# Getting started

### 1) Create any kind of.NET Core project, and change the .csproj to the following

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework>
  </PropertyGroup>
</Project>
```

### 2) Convert to Test Project

Decisions needed on the followings:
* Which Test Framework to use?
* Should we write our tests in BDD?

[SpecFlow](https://specflow.org) is a .NET version of Cucumber, that supports BDD.


##### 2.1) Using MSTest Framework
```console
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package MSTest.TestFramework
dotnet add package MSTest.TestAdapter
```
##### + SpecFlow
```console
dotnet add package SpecFlow
dotnet add package SpecFlow.Tools.MsBuild.Generation
dotnet add package SpecFlow.MsTest
```


##### 2.2) Using NUnit Test framework:
```console
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package nunit
dotnet add package NUnit3TestAdapter
```
##### + SpecFlow
```console
dotnet add package SpecFlow
dotnet add package SpecFlow.Tools.MsBuild.Generation
dotnet add package SpecFlow.NUnit
```


##### 2.3) Using xUnit Test framework:
```console
dotnet add package Microsoft.NET.Test.Sdk
dotnet add package xunit
dotnet add package xunit.runner.visualstudio
```
##### + SpecFlow
```console
dotnet add package SpecFlow
dotnet add package SpecFlow.Tools.MsBuild.Generation
dotnet add package SpecFlow.xUnit
```


### 3) Selenium Local execution

To automate the locally installed browsers, the browser webdrivers should be added as packages.   

```console
dotnet add package Selenium.Chrome.WebDriver
dotnet add package Selenium.Firefox.WebDriver
dotnet add package Selenium.InternetExplorer.WebDriver
dotnet add package Selenium.WebDriver.MicrosoftDriver
dotnet add package Selenium.Opera.WebDriver
dotnet add package Selenium.PhantomJS.WebDriver
```
:warning: Certain WebDriver versions only supports certain browser versions. If you can't/not allowed to update your browser to the latest version, then you will probably need to downgrade your WebDriver's version, according to it's documentation.

ChromeDriver example:
```c#
var chromeDriverDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
var driver = new ChromeDriver(chromeDriverDirectory);
```


