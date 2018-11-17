Feature: Housing: Sorting After Search
Verify is it sorting feature working currectly on housing page after search.


@Housing
Scenario Outline: Housing => After Search Sorting => Default Values: Sorting value can be selected from sorting dropdown
	Given I have opened 'Housing' page
	And I have entered to search field 'Helsinki'
	And I have pressed [Search] button
	When I press on [Sorting] dropdown
	Then <Sorting Values> in [Sorting] dropdown can be selected

	Examples: 
	| Sorting Values |
	| price ↑        |
	| price ↓        |
	| upcoming       |
	| newest         |
	| relevant       |

@Housing
Scenario: Housing => After Search Sorting => Default Values: Number of default values in sorting dropdown should be the same as in requirements
	Given I have opened 'Housing' page
	And I have entered to search field 'Helsinki'
	And I have pressed [Search] button
	When I press on [Sorting] dropdown       
	Then Number of default values in sorting dropdown should be '5'

	
@Housing
Scenario: Housing => After Search Sorting => Default Values: With empty text (just spaces) sorting value is present in sorting dropdown
	Given I have opened 'Housing' page
	And I have entered to search field '  '
	And I have pressed [Search] button
	When I press on [Sorting] dropdown
	Then relevant in [Sorting] dropdown can be selected
