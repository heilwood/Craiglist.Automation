﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Craiglist.Automation.Features.Housing
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Housing: Sorting After Search", Description="Verify is it sorting feature working currectly on housing page after search.", SourceFile="Features\\Housing\\SortingAfterSearch.feature", SourceLine=0)]
    public partial class HousingSortingAfterSearchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SortingAfterSearch.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Housing: Sorting After Search", "Verify is it sorting feature working currectly on housing page after search.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown(string sortingValues, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Housing"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Housing => After Search Sorting => Default Values: Sorting value can be selected " +
                    "from sorting dropdown", null, @__tags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 7
 testRunner.Given("I have opened \'Housing\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I have entered to search field \'Helsinki\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I have pressed [Search] button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I press on [Sorting] dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then(string.Format("{0} in [Sorting] dropdown can be selected", sortingValues), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: Sorting value can be selected " +
            "from sorting dropdown, Variant 0", new string[] {
                "Housing"}, SourceLine=14)]
        public virtual void HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown_Variant0()
        {
#line 6
this.HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown("price ↑", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: Sorting value can be selected " +
            "from sorting dropdown, Variant 1", new string[] {
                "Housing"}, SourceLine=14)]
        public virtual void HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown_Variant1()
        {
#line 6
this.HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown("price ↓", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: Sorting value can be selected " +
            "from sorting dropdown, Variant 2", new string[] {
                "Housing"}, SourceLine=14)]
        public virtual void HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown_Variant2()
        {
#line 6
this.HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown("upcoming", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: Sorting value can be selected " +
            "from sorting dropdown, Variant 3", new string[] {
                "Housing"}, SourceLine=14)]
        public virtual void HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown_Variant3()
        {
#line 6
this.HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown("newest", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: Sorting value can be selected " +
            "from sorting dropdown, Variant 4", new string[] {
                "Housing"}, SourceLine=14)]
        public virtual void HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown_Variant4()
        {
#line 6
this.HousingAfterSearchSortingDefaultValuesSortingValueCanBeSelectedFromSortingDropdown("relevant", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: Number of default values in so" +
            "rting dropdown should be the same as in requirements", new string[] {
                "Housing"}, SourceLine=21)]
        public virtual void HousingAfterSearchSortingDefaultValuesNumberOfDefaultValuesInSortingDropdownShouldBeTheSameAsInRequirements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Housing => After Search Sorting => Default Values: Number of default values in so" +
                    "rting dropdown should be the same as in requirements", null, new string[] {
                        "Housing"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("I have opened \'Housing\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 24
 testRunner.And("I have entered to search field \'Helsinki\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I have pressed [Search] button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("I press on [Sorting] dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("Number of default values in sorting dropdown should be \'5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Housing => After Search Sorting => Default Values: With empty text (just spaces) " +
            "sorting value is present in sorting dropdown", new string[] {
                "Housing"}, SourceLine=30)]
        public virtual void HousingAfterSearchSortingDefaultValuesWithEmptyTextJustSpacesSortingValueIsPresentInSortingDropdown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Housing => After Search Sorting => Default Values: With empty text (just spaces) " +
                    "sorting value is present in sorting dropdown", null, new string[] {
                        "Housing"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given("I have opened \'Housing\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("I have entered to search field \'  \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I have pressed [Search] button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.When("I press on [Sorting] dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
 testRunner.Then("relevant in [Sorting] dropdown can be selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
