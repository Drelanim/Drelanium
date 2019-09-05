# Drelanium

![alt tag](http://classic.battle.net/war3/images/nightelf/spells/shadowstrike.gif)

***C# Test Automation Framework based on Selenium.WebDriver***

**Using:**
- Microsoft.Extensions.Configuration for an easy way browser configuration,
- Serilog as a .NET logger,
- FluentAssertions to write assertions in an extremely readable way.

## Drelanium NuGet package

Drelanium is available as a [NuGet package](https://www.nuget.org/packages/Drelanium/)
```
dotnet add package Drelanium
```

## Local Execution

Use the following WebDriver NuGet packages, to use your local browsers for test execution.  
WebDrivers requires certain browser versions.
```
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
```
dotnet add package Drelanium.SauceLabs
```

