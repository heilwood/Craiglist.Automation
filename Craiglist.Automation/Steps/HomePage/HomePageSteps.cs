using Common.Automation;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Craiglist.Automation.Steps.HomePage
{
    [Binding, Scope(Tag = "HomePage")]
    public sealed class HomeSteps : StepBase
    {
        [Given(@"I have opened '(.*)' application page")]
        public void GivenIHaveOpenedApplicationPage(string homepage)
        {
            Navigation.GoToUrl(homepage);
        }

        [Then(@"I should be redirected to '(.*)' page")]
        public void ThenIShouldBeRedirectedToPage(string redirectedPage)
        {
            var currentUrl = Navigation.GetCurrentUrl();
            Assert.IsTrue(Navigation.GetCurrentUrl().Contains(redirectedPage), $"Redirected to not expected url, should be {redirectedPage}, but was {currentUrl}");
        }
    }
}
