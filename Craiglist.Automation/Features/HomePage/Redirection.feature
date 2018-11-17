Feature: Home: Redirection
Check that we are redirected to right website from main page

@HomePage
Scenario: Home => Redirection: Check that we are redirected to home page from main page
	Given I have opened 'http://craiglist.org' application page
	Then I should be redirected to 'https://helsinki.craigslist.fi/' page
