using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace PlanItTest.Pages
{
    public class CartPage
    {


        private IWebDriver driver;
        private WebDriverWait wait;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        // Return cart item
        public bool GetItem(string item)
        {

            Thread.Sleep(1000);
            return driver.FindElement(By.XPath("//td[contains(.,'" + item + "')]")).Displayed;
        }
    }
}