using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace PJTDataDrivenWithParameters.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver testdrive;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            
            testdrive = new ChromeDriver();
            testdrive.Manage().Window.Maximize();

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}