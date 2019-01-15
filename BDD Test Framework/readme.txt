this contains the design and implementation of a VS dotnet c# test framework intended to support these key features:

- BDD functional testing (via. Specflow)
- parallel test execution
- selenium grid and multiple browsers for Web GUI testing
- automatic screenshot of failed GUI tests
- multiple test environments via Build configurations and app.config files
- multiple target interface types (REST API, RabbitMQ, DB, Web GUI) external shared Nuget class libraries 
- mixing target interfaces in a single scenario, eg. a Web test calling a RESTAPI or DB test step
- modularity and resusability of step libraries 
- generalized solution with working, ready to expand sample tests


---------------------
implementation order
---------------------

DONE - "demo for multiple browser testing folder" - create a demo solution to determine selenium grid multiple browser, parallell test run feasibility and issues
this portion of the framework development showed that Selenium Grid works well for parallell GUI testing from specflow scenarios on differnt browsers
Chrome,Edge,Firefox were tested with 4/1/4 driver instances available respectively on the Selenium Grid and Nunit max parallel tests = 8

ALMOST DONE - "BDDTestFramework" folder - create a generalized VS solution, a BDD Framework, that can be the template for automation projects. This implements the requirements listed above under "intitial content".
(missing are examples for DB verification steps and some finer library methods)


 






