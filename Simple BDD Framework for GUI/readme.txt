this folder contains the design and implementation of a simplified VS dotnet c# test framework intended to support these key features:

- BDD functional testing (via. Specflow)
- parallel test execution
- selenium grid and multiple browsers for Web GUI testing (including headless driving option for real Chrome and Firefox browsers)
- automatic screenshot of failed GUI tests
- multiple test environments via Build configurations and app.config files
- preloaded with Schroders public website test scenarios to demonstrate the above



*** EXCLUDED ARE BUD AVAILABLE IN THE FULL VERSION **** 
- mixing target interfaces in a single scenario, eg. a Web test calling a RESTAPI or DB test step
- multiple target interface types (REST API, RabbitMQ, DB, Web GUI) external shared Nuget class libraries 
- modularity and resusability of step libraries 
- generalized solution with working, ready to expand sample tests