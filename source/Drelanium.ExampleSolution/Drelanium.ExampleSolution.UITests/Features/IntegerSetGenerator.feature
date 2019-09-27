Feature: Random Org's Integer Set Generator
	
	
# number of sets must be an integer in the [1,10000] interval
Scenario: Successfully generate 1 set
	Given I am visiting the Random Org's Random Integer Set Generator page
	When I setup the generator to generate "1" sets with "1" unique numbers between "1" and "2"
	And I click on the Get Sets button
	Then the number of generated sets is "1"


# number of sets must be an integer in the [1,10000] interval
Scenario: Successfully generate 10000 sets
	Given I am visiting the Random Org's Random Integer Set Generator page
	When I setup the generator to generate "10000" sets with "1" unique numbers between "1" and "2"
	And I click on the Get Sets button
	Then the number of generated sets is "10000"


# number of sets must be an integer in the [1,10000] interval
Scenario: Fail to generate 0 set
	Given I am visiting the Random Org's Random Integer Set Generator page
	When I setup the generator to generate "0" sets with "1" unique numbers between "1" and "2"
	And I click on the Get Sets button
	Then "Error: The number of sets must be an integer in the [1,10000] interval" error message is displayed


# number of sets must be an integer in the [1,10000] interval
Scenario: Fail to generate 10001 set
	Given I am visiting the Random Org's Random Integer Set Generator page
	When I setup the generator to generate "10001" sets with "1" unique numbers between "1" and "2"
	And I click on the Get Sets button
	Then "Error: The number of sets must be an integer in the [1,10000] interval" error message is displayed   	  