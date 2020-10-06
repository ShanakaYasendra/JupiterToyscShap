using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;

namespace PlanItTest.Pages
{

    /// <summary>
    /// All test will run using chrome browser.
    /// chrome webdriver is added using nuget.
    /// I assume it will set the path corectlly for chromedriver.exe
    ///
    /// </summary>
    public abstract class BasePage
    {
        //create webdriver varible

        public static IWebDriver driver;

        public BasePage()
        {
         
        }

        public void Setup(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
           

        }

        // Return element text value
        public string GetTextValue(String element)
        {
            return driver.FindElement(By.Id(element)).Text;
        }

        //  Return element display
        public bool IsElementDisplay(string element)
        {

            try
            {
                driver.FindElement(By.Id(element));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void TestCleanUp()
        {
            driver.Quit();
        }
    }

 
}
