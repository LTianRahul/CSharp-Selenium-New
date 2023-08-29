using System;
using OpenQA.Selenium.Appium;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

IWebDriver driver;

//ChromeOptions capabilities = new ChromeOptions();
//capabilities.BrowserVersion = "114";
//Dictionary<string, object> ltOptions = new Dictionary<string, object>();

//capabilities.AddAdditionalCapability("LT:Options", ltOptions);

DesiredCapabilities caps = new DesiredCapabilities();

caps.SetCapability("capabilityName.platformName", "windows 11");
caps.SetCapability("version", "latest");
caps.SetCapability("browser", "chrome");


caps.SetCapability("build", "LTBuildCSharpNew1");
caps.SetCapability("name", "LTTestCSharpNew1");
caps.SetCapability("project", "LTProjectCSharpNew1");



Console.Write("test case started\n");
// Initialize the remote Webdriver using LambdaTest remote URL
// and desired capabilities defined above
 driver = new OpenQA.Selenium.Remote.RemoteWebDriver(
    new Uri("https://rahulkumarlambdatest:dboZK7so8koMnIR1tN11aKfMgxyKtDpb90IlyaCj4n6n7tQeK6@hub.lambdatest.com/wd/hub"), caps);

Console.Write("Opening URL\n");

driver.Url = "https://whatmylocation.com/";

driver.Quit();  
