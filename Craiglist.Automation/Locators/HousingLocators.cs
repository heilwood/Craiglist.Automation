using OpenQA.Selenium;

namespace Craiglist.Automation.Locators
{
    public class HousingLocators
    {
        public By ProductSortingDropdown = By.CssSelector(".dropdown-sort .dropdown-list");
        public By PriceHigherToLowerSortingValue = By.CssSelector("[data-selection='pricedsc']");
        public By PriceLowerToHigherSortingValue = By.CssSelector("[data-selection='priceasc']");
        public By NewestSortingValue = By.CssSelector("[data-selection='date']");
        public By UpcomingSortingValue = By.CssSelector("[data-selection='upcoming']");
        public By PriceTxt = By.CssSelector(".result-meta .result-price");
        public By SearchInput = By.CssSelector("[placeholder='search housing']");
        public By SearchButton = By.CssSelector(".searchbtn");
        public By SortingDropdownValues = By.CssSelector(".dropdown-sort .dropdown-item");
        public By ChangeViewDropdown = By.CssSelector(".dropdown-view .dropdown-list");
        public By ChangeViewToListValue = By.Id("listview");
        public By ChangeViewToThumbValue = By.Id("picview");
        public By HideProductInTheMiddleButton = By.CssSelector("#sortable-results li:nth-child(4) .banish.icon.icon-trash");
    }
}
