using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace PlanItTest.Pages
{
    public class ShopPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ShopPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            PageFactory.InitElements(driver, this);
        }

        // Find the Funny Cow element
        [FindsBy(How = How.CssSelector, Using = "#product-6 .btn")]
        public IWebElement FunnyCow
        {
            get; set;
        }

        // Find the Bunny element
        [FindsBy(How = How.CssSelector, Using = "#product-4 .btn")]
        public IWebElement Bunny
        {
            get; set;
        }

        public void ClickFunnyCowToBuy()
        {

         
               
                FunnyCow.Click();

            


        }
        public void ClickBunnyoBuy()
        {
            
            Bunny.Click();


        }
    }
}