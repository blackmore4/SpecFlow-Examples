﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18034
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BookShop.AcceptanceTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Prepare book catalog", Description="prepare catalog with a list of books required for manual testing", SourceFile="PrepareBookCatalog.feature", SourceLine=0)]
    public partial class PrepareBookCatalogFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PrepareBookCatalog.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Prepare book catalog", "prepare catalog with a list of books required for manual testing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Setup basic example books", SourceLine=4)]
        public virtual void SetupBasicExampleBooks()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setup basic example books", ((string[])(null)));
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Author",
                        "Title",
                        "Price"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Bridging the Communication Gap",
                        "12.20"});
            table1.AddRow(new string[] {
                        "Gojko Adzic",
                        "Specification By Example",
                        "15.30"});
            table1.AddRow(new string[] {
                        "Lisa Crispin and Janet Gregory",
                        "Agile Testing",
                        "20.20"});
            table1.AddRow(new string[] {
                        "Mitch Lacey",
                        "The Scrum Field Guide",
                        "15.31"});
            table1.AddRow(new string[] {
                        "Martin Fowler",
                        "Refactoring",
                        "29.55"});
            table1.AddRow(new string[] {
                        "Esther Derby and Diana Larsen",
                        "Agile Retrospectives",
                        "16.99"});
            table1.AddRow(new string[] {
                        "Matt Wynne and Aslak Hellesoy",
                        "The Cucumber Book",
                        "18.00"});
            table1.AddRow(new string[] {
                        "David Chelimsky",
                        "The RSpec Book",
                        "17.50"});
#line 6
 testRunner.Given("the following books", ((string)(null)), table1, "Given ");
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
