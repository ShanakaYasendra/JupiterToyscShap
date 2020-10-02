using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestPlanIt.Pages
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

        // create varible for Navigation page
        public static NavBar navBar;
        public BasePage()
        {
            //initialize the webdriver
            if (driver == null)
            {

                driver = new ChromeDriver();

                driver.Navigate().GoToUrl("https://jupiter.cloud.planittesting.com/");
                driver.Manage().Window.Maximize();


                navBar = new NavBar(driver);

            }
        }


        public string GetTextVale(String element)
        {
            return driver.FindElement(By.Id(element)).Text;
        }
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
