using Common.Automation;
using Craiglist.Automation.Locators;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Craiglist.Automation.Steps.Housing
{
    [Binding, Scope(Tag = "Housing")]
    public sealed class HousingSteps : StepBase
    {
        private readonly HousingLocators _housingLocators;
        public HousingSteps()
        {
            _housingLocators = new HousingLocators();
        }

        #region Precondition steps

        [Given(@"I have opened 'Housing' page")]
        public void GivenIHaveOpenedPage()
        {
            Navigation.GotoRelatedUrl(ConfigManager.HousingPage);
        }

        [When(@"I press on \[Sorting] dropdown")]
        public void WhenIPressOnSortingDropdown()
        {
            Dropdown.Click(_housingLocators.ProductSortingDropdown);
        }

        [Given(@"I have entered to search field '(.*)'")]
        public void GivenIHaveEnteredToSearchField(string text)
        {
            Input.Type(_housingLocators.SearchInput, text);
        }

        [Given(@"I have pressed \[Search] button")]
        public void GivenIHavePressedSearchButton()
        {
            Button.ClickAndWait(_housingLocators.SearchButton);
        }

        [When(@"I select \[Price Highest to Lowest] sorting value")]
        [Given(@"I have selected \[Price Highest to Lowest] sorting value")]
        public void GivenIHaveSelectPriceHighestToLowestSortingValue()
        {
            Dropdown.SelectValueUsingClick(_housingLocators.ProductSortingDropdown, _housingLocators.PriceHigherToLowerSortingValue);
        }

        [When(@"I select \[Price Lowest to Highest] sorting value")]
        [Given(@"I have selected \[Price Lowest to Highest] sorting value")]
        public void WhenISelectPriceLowestToHighestSortingValue()
        {
            Dropdown.SelectValueUsingClick(_housingLocators.ProductSortingDropdown, _housingLocators.PriceLowerToHigherSortingValue);
        }

        [Given(@"I have selected \[Newest] sorting value")]
        public void GivenIHaveSelectedNewestSortingValue()
        {
            Dropdown.SelectValueUsingClick(_housingLocators.ProductSortingDropdown, _housingLocators.NewestSortingValue);
        }

        [Given(@"I have selected \[Upcoming] sorting value")]
        public void GivenIHaveSelectedUpcomingSortingValue()
        {
            Dropdown.SelectValueUsingClick(_housingLocators.ProductSortingDropdown, _housingLocators.UpcomingSortingValue);
        }

        [Given(@"I have selected \[Thumb] view")]
        public void GivenIHaveSelectedThumbView()
        {
            Dropdown.SelectValueUsingClick(_housingLocators.ChangeViewDropdown, _housingLocators.ChangeViewToThumbValue);
        }

        [Given(@"I have selected \[List] view")]
        public void GivenIHaveSelectedListView()
        {
            Dropdown.SelectValueUsingClick(_housingLocators.ChangeViewDropdown, _housingLocators.ChangeViewToListValue);
        }

        [When(@"I press \[Hide Product] button for product in the middle")]
        public void WhenIPressHideProductButtonForProductInTheMiddle()
        {
            Button.ClickAndWait(_housingLocators.HideProductInTheMiddleButton);
        }

        #endregion

        #region Asserts

        [Then(@"(.*) in \[Sorting] dropdown can be selected")]
        public void ThenPriceValueInSortingDropdownIsDisplayed(string value)
        {
            Assert.IsTrue(Dropdown.IsValueCanBeSelected(_housingLocators.ProductSortingDropdown, value), $"Values with text {value} is not present sorting in dropdown");
        }

        [Then(@"Number of default values in sorting dropdown should be '(.*)'")]
        public void ThenNumberOfDefaultValuesInSortingDropdownShouldBe(int numberOfValues)
        {
            Assert.AreEqual(numberOfValues, Dropdown.GetElementAmount(_housingLocators.SortingDropdownValues));
        }

        [Then(@"Prodcuts should be sorted by price from highest to lowest")]
        public void ThenProdcutsShouldBeSortedByPriceFromHighestToLowest()
        {
            Assert.IsTrue(TextElement.IsPriceHigherToLower(_housingLocators.PriceTxt), "Price sorting from highest to lowest not working currectly, check test output for details");
        }

        [Then(@"Prodcuts should be sorted by price from lowest to highest")]
        public void ThenProdcutsShouldBeSortedByPriceFromLowestToHighest()
        {
            Assert.IsTrue(TextElement.IsPriceLowerToHigher(_housingLocators.PriceTxt), "Price sorting from lowest to highest is not working currectly, check test output for details");
        }

        #endregion

    }
}
