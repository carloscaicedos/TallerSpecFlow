Feature: HU002_CreateUser
	In order to have a new customer in customer list
	As a customer manager
	I want to record the id, name, city, customer type and risk level for create a new customer

@mytag
Scenario: Create a new user
	Given I acces to home page "http://ceibapruebasbanco.azurewebsites.net"
		And I select the option "Manage Customers"
		And I select the option "Create New"
	When I enter the Id "112233"
		And I enter the name "ACME"
		And I enter the city "Medellín"
		And I enter the type client "Regular"
		And I enter the risk level "Bajo"
		And I create the user
	Then I valid that the customer list contain the id client "112233"
		And finish the test