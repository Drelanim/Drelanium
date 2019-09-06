# Drelanium

![alt tag](https://github.com/Drelanim/Drelanium/blob/master/docs/icons/Drelanium.gif)

***C# Test Automation Framework based on Selenium.WebDriver***

**Using:**
- Microsoft.Extensions.Configuration for an easy way browser configuration,
- Serilog as a .NET logger,
- FluentAssertions to write assertions in an extremely readable way.

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


## Drelanium NuGet package

Drelanium is available as a [NuGet package](https://www.nuget.org/packages/Drelanium/)
```console
dotnet add package Drelanium
```

## Local Execution

Use the following WebDriver NuGet packages, to use your local browsers for test execution.  
WebDrivers requires certain browser versions.
```console
dotnet add package Selenium.Chrome.WebDriver
dotnet add package Selenium.Firefox.WebDriver
dotnet add package Selenium.InternetExplorer.WebDriver
dotnet add package Selenium.WebDriver.MicrosoftDriver
dotnet add package Selenium.Opera.WebDriver
dotnet add package Selenium.PhantomJS.WebDriver
```
## Remote Execution

Setup your network [Selenium Grid](https://www.seleniumhq.org/docs/07_selenium_grid.jsp) for remote execution according to the tutorial.

### SauceLabs

Executing remote tests using [SauceLabs](https://saucelabs.com/) is supported by the [Drelanium.SauceLabs](https://www.nuget.org/packages/Drelanium.SauceLabs/) NuGet package
```console
dotnet add package Drelanium.SauceLabs
```

