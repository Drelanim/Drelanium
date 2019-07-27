prototype for multiple browser parallel web gui testing

as the name suggests this is largely throw-away code whose objective is accomplish parallell multiple browser test runs and in the process learn any limitations and finer points to incorporate such into the test framework.

The soolution will be stripped down to the essentials.


VS version and tools plugins:
------------------------------
VS2017 Professional 15.6.4 
JetBrains Resharper Ultimate 17.2.1
Nunit 3 Test Adapter 3.11.2.0 (not sure if needed)
SpecFlow for Visual Sudio 2017 2017.2.7
SlowCheetah 3.1.69

details:
--------

a) Create solution and Specflow/Nunit test project within it.

- create solution MultipleBrowserParallelGuiTesting with unit test project LoginTest
- add NUnit 3.11.0 Nuget to project
- add SpecFlow 2.4.0 Nuget to project
- add SpecFlow.NUnit 2.4.0 Nuget to project
- add selenuim.WebDriver 3.141.0 Nuget to project
- add selenuim.Support 3.141.0 Nuget to project


b) understand how the Slenium GRID works.... see folder "Selenium Grid Learning"

c) Build the grid. 
The result is the folder "SeleniumGrid" placed in the C drive root
equiped with startall.bat command file to start the selenium grid hub and local nodes

d) make specflow feature files and corresponding step files to run a very simple google search on 
three different browsers, like this: 

SPECFLOW FEATURE FILE:

	Feature: GoogleOnFirefox
	

	
@mytag
Scenario: RunASearch

	Given I start Firefox, navigate to Google and search for WebDriver


SPECFLOW STEP FILE:
 
        [Given(@"I start Firefox, navigate to Google and search for WebDriver")]
        public void GivenIStartFirefoxNavigateToGoogleAndSearchForWebDriver()
        {
            // ChromeOptions Options = new ChromeOptions();
            // InternetExplorerOptions Options = new InternetExplorerOptions();
            FirefoxOptions Options = new FirefoxOptions();
            //EdgeOptions Options = new EdgeOptions();

            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), Options.ToCapabilities(), TimeSpan.FromSeconds(600));// NOTE: connection timeout of 600 seconds or more required for time to launch grid nodes if non are available.

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.google.com/ncr");
                IWebElement query = driver.FindElement(By.Name("q"));
                query.SendKeys("webdriver");
                query.Submit();
                Thread.Sleep(1000);
                driver.Quit();
            }
            catch (Exception e)
            {
                driver.Quit();
                Assert.Fail("test failed");
            }
        }


e) enable parallell running by editing the AssemblyInfo.cs file of the test project (under Properties on the solution explorer)
	using NUnit.Framework;
	// add this to run in parallel
	[assembly: Parallelizable(ParallelScope.Fixtures)]
	[assembly: LevelOfParallelism(8)]

f) now, when you run the test project, instead of executing the three feature files in serioes, it will do so in parallell
   the Selenium Grid hub will direct the test on hand to the node that has a spare driver for the particular browser.

RESULTS:

Firefox, Chrome and Edge specflow scenarios are running in parrallel, no issue.
The Grid max instances for Edge had to be reduced to 1 from 4, more than one gives error. 
So it seems that at least for Chrome and Firefox the grid works very well an can handle 4 browser instances per type easily.
The Nunit max number of scenarios can also be set to an arbitrary number, dafault was 4












