Feature: Housing: Sorting
Verify is it sorting feature working currectly on housing page.

@Housing
Scenario: Housing => Sorting: Sorting by price from highest to lowest working
	Given I have opened 'Housing' page
	When I select [Price Highest to Lowest] sorting value
	Then Prodcuts should be sorted by price from highest to lowest

@Housing
Scenario: Housing => Sorting: Sorting by price from lowest to highest working
	Given I have opened 'Housing' page
	When I select [Price Lowest to Highest] sorting value
	Then Prodcuts should be sorted by price from lowest to highest

@Housing
Scenario: Housing => Sorting: Sorting by price from lowest to highest working when was selected not default sorting value
	Given I have opened 'Housing' page
	And I have selected [Newest] sorting value
	When I select [Price Lowest to Highest] sorting value
	Then Prodcuts should be sorted by price from lowest to highest

@Housing
Scenario: Housing => Sorting: Sorting by price from highest to lowest working when was selected not default sorting value
	Given I have opened 'Housing' page
	And I have selected [Upcoming] sorting value
	When I select [Price Highest to Lowest] sorting value
	Then Prodcuts should be sorted by price from highest to lowest

@Housing
Scenario: Housing => Sorting: Sorting by price from lowest to highest working if selected two times one by one
	Given I have opened 'Housing' page
	And I have selected [Price Lowest to Highest] sorting value
	When I select [Price Lowest to Highest] sorting value
    Then Prodcuts should be sorted by price from lowest to highest

@Housing
Scenario: Housing => Sorting: Sorting by price from highest to lowest working if selected two times one by one
	Given I have opened 'Housing' page
	And I have selected [Price Highest to Lowest] sorting value
	When I select [Price Highest to Lowest] sorting value
	Then Prodcuts should be sorted by price from highest to lowest

@Housing
Scenario Outline: Housing => Sorting => Default Values: Sorting value can be selected from sorting dropdown
	Given I have opened 'Housing' page
	When I press on [Sorting] dropdown
	Then <Sorting Values> in [Sorting] dropdown can be selected

	Examples: 
	| Sorting Values |
	| price ↑        |
	| price ↓        |
	| upcoming       |
	| newest         |

@Housing
Scenario: Housing => Sorting => Default Values: Number of default values in sorting dropdown should be the same as in requirements
	Given I have opened 'Housing' page
	When I press on [Sorting] dropdown
	Then Number of default values in sorting dropdown should be '4'

@Housing
Scenario: Housing => Sorting = View: Sorting by price from lowest to highest working when was selected thumb view
	Given I have opened 'Housing' page
	And I have selected [Thumb] view
	When I select [Price Lowest to Highest] sorting value
	Then Prodcuts should be sorted by price from lowest to highest

@Housing
Scenario: Housing => Sorting => View: Sorting by price from highest to lowest working when was selected thumb view
	Given I have opened 'Housing' page
	And I have selected [Thumb] view
	When I select [Price Highest to Lowest] sorting value
	Then Prodcuts should be sorted by price from highest to lowest


@Housing
Scenario: Housing => Sorting => View: Sorting by price from lowest to highest working when was selected list view
	Given I have opened 'Housing' page
	And I have selected [List] view
	When I select [Price Lowest to Highest] sorting value
	Then Prodcuts should be sorted by price from lowest to highest

@Housing
Scenario: Housing => Sorting => View: Sorting by price from highest to lowest working when was selected list view
	Given I have opened 'Housing' page
	And I have selected [List] view
	When I select [Price Highest to Lowest] sorting value
	Then Prodcuts should be sorted by price from highest to lowest


@Housing
Scenario: Housing => Sorting => Hidden Product: Sorting by price from lowest to highest working when product was hidden
	Given I have opened 'Housing' page
	And I have selected [Price Lowest to Highest] sorting value
	When I press [Hide Product] button for product in the middle
	Then Prodcuts should be sorted by price from lowest to highest

@Housing
Scenario: Housing => Sorting => Hidden Product: Sorting by price from highest to lowest working when was hidden
	Given I have opened 'Housing' page
	And I have selected [Price Highest to Lowest] sorting value
	When I press [Hide Product] button for product in the middle
	Then Prodcuts should be sorted by price from highest to lowest