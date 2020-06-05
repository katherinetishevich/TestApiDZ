Feature: Users
	When i click send button for  get request  displays an array with users data

@positive
Scenario: I  have output array with  all users
	Given I have prepored  get request 
	When I have an array with registered user data
	Then the result should be 200 ok on the screen
	 
	        