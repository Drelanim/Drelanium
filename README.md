# Drelanium 

Web Test Automation with Selenium.WebDriver (see: [Getting started](docs/GettingStarted.md))

## Topics
* [Boundary value analysis](https://github.com/Drelanim/Drelanium/blob/master/source/Drelanium.ExampleSolution/Drelanium.ExampleSolution.UITests/Features/IntegerSetGenerator.feature) on random.org's [Random Integer Set Generator](https://www.random.org/integer-sets/) page
* [Getting started](docs/GettingStarted.md)


## NuGets

### [Drelanium](https://www.nuget.org/packages/Drelanium/)
C# Test Automation Framework based on Selenium.WebDriver to write browser automated tests with ease.
Extends the usage of numerous Selenium types, and provides new useful features. Supports Page Object Model design pattern.  
```console
dotnet add package Drelanium
```

#### Used packages:
* [Selenium](https://www.seleniumhq.org/), to automate browsers   
* [Microsoft.Extensions.Configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/), to create and bind configurations
* [Serilog](https://serilog.net/), as a .NET logger   
* [FluentAssertions](https://fluentassertions.com/), to write assertions in an extremely readable way   

---

### [Drelanium.SauceLabs](https://www.nuget.org/packages/Drelanium.SauceLabs/)
Provides support for executing remote Selenium tests on [SauceLabs](https://saucelabs.com/) 
```console
dotnet add package Drelanium.SauceLabs
```
---

