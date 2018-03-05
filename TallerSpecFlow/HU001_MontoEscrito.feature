Feature: HU001_MontoEscrito
	In order to print checks
	As a account manager
	I want to convert numbers to letters

@mytag
Scenario: Convert postive numbers to letters
	Given I access to home page "http://ceibapruebasbanco.azurewebsites.net/"
		And I select the option "Monto Escrito"
	When I want to convert the number "123"
		And I convert the number
	Then I verfiy the result is equal to "ciento veinte y tres"
		And finifh the test
