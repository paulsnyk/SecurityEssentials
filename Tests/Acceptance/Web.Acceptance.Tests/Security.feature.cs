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
namespace SecurityEssentials.Acceptance.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Security")]
    public partial class SecurityFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Security.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Security", "\tIn order to avoid information disclosure\r\n\tAs a pen tester\r\n\tI want to be sure t" +
                    "he application has the correct security settings and behaviour", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I delete all cookies from the cache", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I clear down the database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("I have the standard set of lookups", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will log a content security policy violation")]
        public virtual void TheWebApplicationWillLogAContentSecurityPolicyViolation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The web application will log a content security policy violation", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "BlockedUri",
                        "http://myevilsite.com/stealdetails/capture/"});
            table1.AddRow(new string[] {
                        "DocumentUri",
                        "http://mysite.com/innocentpage/"});
            table1.AddRow(new string[] {
                        "LineNumber",
                        "1"});
            table1.AddRow(new string[] {
                        "Referrer",
                        ""});
            table1.AddRow(new string[] {
                        "OriginalPolicy",
                        "default-src http://localhost:4845"});
            table1.AddRow(new string[] {
                        "ScriptSample",
                        "#modernizr{font:0/0 a}#modernizr:after{c..."});
            table1.AddRow(new string[] {
                        "SourceFile",
                        "http://mysite.com/innocentpage/"});
            table1.AddRow(new string[] {
                        "ViolatedDirective",
                        "default-src http://mysite.com"});
#line 12
 testRunner.Given("I have a content security policy violation with details:", ((string)(null)), table1, "Given ");
#line 22
 testRunner.When("I post the content security policy violation to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("I have 1 content security policy violation in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "Level",
                        "Warning"});
            table2.AddRow(new string[] {
                        "Message",
                        "BlockedUri: \"http://myevilsite.com/stealdetails/capture/\""});
#line 25
 testRunner.And("I have a log in the system matching the following:", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will log a http public key pinning violation")]
        public virtual void TheWebApplicationWillLogAHttpPublicKeyPinningViolation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The web application will log a http public key pinning violation", null, ((string[])(null)));
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DateTime",
                        "2017-12-07"});
            table3.AddRow(new string[] {
                        "HostName",
                        "http://mysite.com/"});
            table3.AddRow(new string[] {
                        "Port",
                        "8080"});
            table3.AddRow(new string[] {
                        "ExpirationDate",
                        "2018-12-01"});
            table3.AddRow(new string[] {
                        "IncludeSubDomains",
                        "True"});
            table3.AddRow(new string[] {
                        "NotedHostName",
                        ""});
            table3.AddRow(new string[] {
                        "ServedCertificateChainDelimited",
                        "pem1,pem2,pem3"});
            table3.AddRow(new string[] {
                        "ValidatedCertificateChainDelimited",
                        "pem1,pem2,pem4"});
            table3.AddRow(new string[] {
                        "KnownPinsDelimited",
                        "known-pin1,known-pin2,known-pin3"});
#line 31
 testRunner.Given("I have a http public key pinning violation with details:", ((string)(null)), table3, "Given ");
#line 42
 testRunner.When("I post the http public key pinning violation to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("I have 1 http public key pinning violation in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "Level",
                        "Warning"});
            table4.AddRow(new string[] {
                        "Message",
                        "HostName: \"http://mysite.com/\""});
#line 45
 testRunner.And("I have a log in the system matching the following:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will log a certificate policy violation")]
        public virtual void TheWebApplicationWillLogACertificatePolicyViolation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The web application will log a certificate policy violation", null, ((string[])(null)));
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "FailureDate",
                        "[Now]"});
            table5.AddRow(new string[] {
                        "ExpirationDate",
                        "[1 Month From Now]"});
            table5.AddRow(new string[] {
                        "HostName",
                        "example.com"});
            table5.AddRow(new string[] {
                        "Port",
                        "8080"});
            table5.AddRow(new string[] {
                        "Source",
                        "web"});
#line 51
 testRunner.Given("I have a certificate policy violation with details:", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "SerialisedSct",
                        "Source",
                        "Status",
                        "Version"});
            table6.AddRow(new string[] {
                        "ABCDEFG",
                        "tls-extension",
                        "valid",
                        "1"});
            table6.AddRow(new string[] {
                        "CDEFGHIJ",
                        "tls-extension",
                        "valid",
                        "2"});
#line 58
 testRunner.And("I have the following certificate policy violation scts:", ((string)(null)), table6, "And ");
#line 62
 testRunner.When("I post the certificate policy violation to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.Then("I have 1 certificate policy violation in the system", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Level",
                        "Warning"});
            table7.AddRow(new string[] {
                        "Message",
                        "HostName: \"example.com\""});
#line 65
 testRunner.And("I have a log in the system matching the following:", ((string)(null)), table7, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The web application will return the correct security headers")]
        [NUnit.Framework.CategoryAttribute("CheckForErrors")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void TheWebApplicationWillReturnTheCorrectSecurityHeaders()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The web application will return the correct security headers", null, new string[] {
                        "CheckForErrors",
                        "Smoke"});
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 72
 testRunner.When("I call http get on the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table8.AddRow(new string[] {
                        "X-Frame-Options",
                        "Deny"});
            table8.AddRow(new string[] {
                        "X-Content-Type-Options",
                        "nosniff"});
            table8.AddRow(new string[] {
                        "X-XSS-Protection",
                        "1; mode=block; report=/Security/CspReporting"});
            table8.AddRow(new string[] {
                        "Referrer-Policy",
                        "origin"});
            table8.AddRow(new string[] {
                        "Feature-Policy",
                        "geolocation \'none\'; midi \'none\'; camera \'none\'; usb \'none\'; magnetometer \'none\'; " +
                            "sync-xhr \'none\'; microphone \'none\'; camera \'none\'; gyroscope \'none\'; speaker \'no" +
                            "ne\'; payment \'none\'"});
            table8.AddRow(new string[] {
                        "Content-Security-Policy",
                        @"default-src 'self'; style-src 'self' 'unsafe-inline'; img-src * data:; font-src 'self' https: data:; script-src 'self' 'unsafe-inline' 'unsafe-eval'; connect-src 'self'; frame-ancestors 'self'; form-action 'self'; base-uri 'self'; object-src 'none'; report-uri /Security/CspReporting"});
#line 73
 testRunner.Then("the response headers will contain:", ((string)(null)), table8, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key"});
            table9.AddRow(new string[] {
                        "X-AspNet-Version"});
            table9.AddRow(new string[] {
                        "X-AspNetMvc-Version"});
            table9.AddRow(new string[] {
                        "Server"});
#line 81
 testRunner.And("the response headers will not contain:", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The application will prevent a brute force login attempt")]
        [NUnit.Framework.CategoryAttribute("CheckForErrors")]
        public virtual void TheApplicationWillPreventABruteForceLoginAttempt()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The application will prevent a brute force login attempt", null, new string[] {
                        "CheckForErrors"});
#line 88
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 89
 testRunner.Given("I navigate to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
 testRunner.And("I maximise the browser window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("I am taken to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I click the login link in the navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I am navigated to the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "UserName",
                        "attempt1@test.net"});
            table10.AddRow(new string[] {
                        "Password",
                        "rhubarb22"});
#line 94
 testRunner.And("I enter the following login data:", ((string)(null)), table10, "And ");
#line 98
 testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("I navigate to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("I am taken to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("I click the login link in the navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("I am navigated to the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "UserName",
                        "attempt2@test.net"});
            table11.AddRow(new string[] {
                        "Password",
                        "rhubarb22"});
#line 103
 testRunner.And("I enter the following login data:", ((string)(null)), table11, "And ");
#line 107
 testRunner.And("I click the login button as quickly as possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("I navigate to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("I am taken to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("I click the login link in the navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("I am navigated to the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "UserName",
                        "attempt3@test.net"});
            table12.AddRow(new string[] {
                        "Password",
                        "rhubarb22"});
#line 112
 testRunner.And("I enter the following login data:", ((string)(null)), table12, "And ");
#line 116
 testRunner.And("I click the login button as quickly as possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("I navigate to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And("I am taken to the homepage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And("I click the login link in the navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("I am navigated to the \'login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table13.AddRow(new string[] {
                        "UserName",
                        "attempt4@test.net"});
            table13.AddRow(new string[] {
                        "Password",
                        "rhubarb22"});
#line 121
 testRunner.And("I enter the following login data:", ((string)(null)), table13, "And ");
#line 125
 testRunner.When("I click the login button as quickly as possible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 126
 testRunner.And("I wait 2 seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.Then("an error message is shown \'You have requested this resource too many times in the" +
                    " last 60 seconds.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A user with an expired password is redirected to the change password page until t" +
            "hey change the password")]
        [NUnit.Framework.CategoryAttribute("CheckForErrors")]
        public virtual void AUserWithAnExpiredPasswordIsRedirectedToTheChangePasswordPageUntilTheyChangeThePassword()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A user with an expired password is redirected to the change password page until t" +
                    "hey change the password", null, new string[] {
                        "CheckForErrors"});
#line 130
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Title",
                        "FirstName",
                        "LastName",
                        "Password",
                        "SecurityQuestion",
                        "SecurityAnswer",
                        "IsAdmin",
                        "Approved",
                        "Enabled",
                        "WorkTelephoneNumber",
                        "HomeTelephoneNumber",
                        "MobileTelephoneNumber",
                        "Town",
                        "Postcode",
                        "SkypeName",
                        "PasswordExpiryDate"});
            table14.AddRow(new string[] {
                        "user1@test.net",
                        "Mr",
                        "Needs",
                        "Approval",
                        "zasXX8576jFj123",
                        "What is the name of your first pet?",
                        "Beatrix",
                        "false",
                        "true",
                        "true",
                        "0123",
                        "0456",
                        "0789",
                        "town",
                        "postcode",
                        "skype",
                        "[Expired]"});
#line 131
 testRunner.Given("the following users are setup in the database:", ((string)(null)), table14, "Given ");
#line 134
 testRunner.And("the user \'user1@test.net\' has the password expiry date set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("I navigate to the website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("I maximise the browser window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
 testRunner.And("I click the login link in the navigation bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And("I am navigated to the \'Login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "UserName",
                        "user1@test.net"});
            table15.AddRow(new string[] {
                        "Password",
                        "zasXX8576jFj123"});
#line 139
 testRunner.And("I enter the following login data:", ((string)(null)), table15, "And ");
#line 143
 testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("I am navigated to the \'Change Password\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
 testRunner.And("I select Admin -> Change Security Information from the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
 testRunner.And("I am navigated to the \'Change Password\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
 testRunner.And("I select Admin -> Manage Account from the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
 testRunner.And("I am navigated to the \'Change Password\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table16.AddRow(new string[] {
                        "CurrentPassword",
                        "zasXX8576jFj123"});
            table16.AddRow(new string[] {
                        "NewPassword",
                        "NewPassword45678"});
            table16.AddRow(new string[] {
                        "ConfirmNewPassword",
                        "NewPassword45678"});
#line 149
 testRunner.And("I enter the following change password data:", ((string)(null)), table16, "And ");
#line 154
 testRunner.When("I submit the change password form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
 testRunner.Then("I am navigated to the \'Change Password Success\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 156
 testRunner.And("the user \'user1@test.net\' does not have the password expiry date set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("I select Admin -> Change Security Information from the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("I am navigated to the \'Login\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table17.AddRow(new string[] {
                        "UserName",
                        "user1@test.net"});
            table17.AddRow(new string[] {
                        "Password",
                        "NewPassword45678"});
#line 159
 testRunner.And("I enter the following login data:", ((string)(null)), table17, "And ");
#line 163
 testRunner.And("I click the login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
 testRunner.And("I am navigated to the \'Change Security Information\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

