start cmd /k  "java -jar selenium-server-standalone-3.141.59.jar -role hub"
start cmd /k  "java -jar -Dwebdriver.gecko.driver=FireFoxV63.0.3/geckodriver.exe -Dwebdriver.ie.driver=IE11.0.95/IEDriverServer.exe -Dwebdriver.chrome.driver=Chrome70.0.3538/chromedriver.exe selenium-server-standalone-3.141.59.jar -port 5555 -role node -hub http://localhost:4444/grid/register"
start cmd /k "java -Dwebdriver.edge.driver=Edge14.14393/MicrosoftWebDriver.exe -jar selenium-server-standalone-3.141.59.jar -port 5556 -role node -hub http://localhost:4444/grid/register -browser "browserName=MicrosoftEdge, platform=WINDOWS, maxInstances=3""