using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PlanItTest.Pages
{
    public class CartPage
    {


        private IWebDriver driver;
       

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            PageFactory.InitElements(driver, this);
        }

        // Return cart item
        public bool GetItem(string item)
        {

            return driver.FindElement(By.XPath("//td[contains(.,'" + item + "')]")).Displayed;
        }
    }
}