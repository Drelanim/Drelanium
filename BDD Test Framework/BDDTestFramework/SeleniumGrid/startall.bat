start cmd /k  "java -jar selenium-server-standalone-3.141.59.jar -role hub -hubConfig hub.json"
start cmd /k  "java -jar -Dwebdriver.gecko.driver=FireFoxV63.0.3/geckodriver.exe selenium-server-standalone-3.141.59.jar -role node -nodeConfig node1.json"
start cmd /k "java -Dwebdriver.edge.driver=Edge14.14393/MicrosoftWebDriver.exe -jar selenium-server-standalone-3.141.59.jar -role node -nodeConfig node2.json"
start cmd /k "java -Dwebdriver.chrome.driver=Chrome70.0.3538/chromedriver.exe -jar selenium-server-standalone-3.141.59.jar -role node -nodeConfig node3.json"
start cmd /k "java -Dwebdriver.ie.driver=IE11.0.95/IEDriverServer.exe -jar selenium-server-standalone-3.141.59.jar -role node -nodeConfig node4.json"
