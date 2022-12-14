// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TheInternetSpecFlow.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "AddRemoveElements_Feature")]
    public partial class AddRemoveElementsFeature : object, Xunit.IClassFixture<AddRemoveElementsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "AddRemoveElements_Feature"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AddRemoveElements.feature"
#line hidden
        
        public AddRemoveElementsFeature(AddRemoveElementsFeature.FixtureData fixtureData, TheInternetSpecFlow_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AddRemoveElements", @"Buttons to add and remove elements from the page.
The Add Element button creates Delete buttons, which remove themselves.

The JavaScript to obtain the Add Element button:
document.querySelector("".example > button"")

The JavaScript to obtain the first Delete button:
document.querySelector(""#elements > button:first-child"")", ProgrammingLanguage.CSharp, new string[] {
                        "AddRemoveElements_Feature"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Clicking Add and then Delete various amounts of times gives a certain number of e" +
            "lements on the page")]
        [Xunit.TraitAttribute("FeatureTitle", "AddRemoveElements")]
        [Xunit.TraitAttribute("Description", "Clicking Add and then Delete various amounts of times gives a certain number of e" +
            "lements on the page")]
        [Xunit.TraitAttribute("Category", "AddRemoveElements_Scenario")]
        [Xunit.InlineDataAttribute("1", "0", "1", new string[0])]
        [Xunit.InlineDataAttribute("2", "0", "2", new string[0])]
        [Xunit.InlineDataAttribute("2", "1", "1", new string[0])]
        [Xunit.InlineDataAttribute("5", "0", "5", new string[0])]
        [Xunit.InlineDataAttribute("3", "2", "1", new string[0])]
        [Xunit.InlineDataAttribute("5", "5", "0", new string[0])]
        public virtual void ClickingAddAndThenDeleteVariousAmountsOfTimesGivesACertainNumberOfElementsOnThePage(string numToAdd, string numToDelete, string numRemaining, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AddRemoveElements_Scenario"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("NumToAdd", numToAdd);
            argumentsOfScenario.Add("NumToDelete", numToDelete);
            argumentsOfScenario.Add("NumRemaining", numRemaining);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clicking Add and then Delete various amounts of times gives a certain number of e" +
                    "lements on the page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
    testRunner.Given(string.Format("{0} elements were added to the page", numToAdd), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
    testRunner.When(string.Format("the Delete buttons are clicked {0} times", numToDelete), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
    testRunner.Then(string.Format("the number of elements should be {0}", numRemaining), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AddRemoveElementsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AddRemoveElementsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
