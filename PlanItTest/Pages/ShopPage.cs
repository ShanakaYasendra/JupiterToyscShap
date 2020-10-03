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

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
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

            //Thread.Sleep(1000);
            try
            {
                FunnyCow.Click();
            }
            catch (Exception)
            {
                Thread.Sleep(1000);
                FunnyCow.Click();

            }


        }
        public void ClickBunnyoBuy()
        {
            // Thread.Sleep(1000);
            Bunny.Click();


        }
    }
}