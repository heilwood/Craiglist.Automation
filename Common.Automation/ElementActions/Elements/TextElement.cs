using System;
using System.Collections.Generic;
using System.Linq;
using Common.Automation.ElementActions.ElementsBase;
using OpenQA.Selenium;

namespace Common.Automation.ElementActions.Elements
{
    public class TextElement : TextElementBase
    {
        public TextElement(IWebDriver driver, TimeSpan waitTime) : base(driver, waitTime)
        {
        }

        public List<string> GetUniqCurrencyFromList(List<string> listWithPrices)
        {
            var uniqCurrency = listWithPrices.Where(item => item != string.Empty).Select(RemoveDigitsFromText).Distinct().ToList();
            return uniqCurrency;
        }

        public List<List<decimal>> GetPriceByCurrency(By priceLocator)
        {
            var priceSortedByCurrency = new List<List<decimal>>();
            var prices = GetElementsText(priceLocator);
            var uniqCurrency = GetUniqCurrencyFromList(prices);

            foreach (var currency in uniqCurrency)
            {
                var pricesByCurrency = prices.Where(price => price.Contains(currency) && price != string.Empty).Select(GetDecimalFromText).ToList();
                priceSortedByCurrency.Add(pricesByCurrency);
            }

            return priceSortedByCurrency;
        }

        public bool IsPriceHigherToLower(By priceLocator)
        {
            var prices = GetPriceByCurrency(priceLocator);

            foreach (var priceList in prices)
            {
                for (var i = 0; i < priceList.Count - 1; i++)
                {
                    if (priceList[i] >= priceList[i + 1]) continue;
                    Console.WriteLine($"Error: this price {priceList[i]} is lower than {priceList[i + 1]}, but should be higher.");
                    return false;
                }
            }

            return true;
        }

        public bool IsPriceLowerToHigher(By priceLocator)
        {
            var prices = GetPriceByCurrency(priceLocator);

            foreach (var priceList in prices)
            {
                for (var i = 0; i < priceList.Count - 1; i++)
                {
                    if (priceList[i] <= priceList[i + 1]) continue;
                    Console.WriteLine($"Error: this price {priceList[i]} is higher than {priceList[i + 1]}, but should be lower.");
                    return false;
                }
            }

            return true;
        }
    }
}