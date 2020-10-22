using System;
using OpenQA.Selenium;

using PlanItTest.Util;

using SeleniumExtras;

namespace PlanItTest.Pages
{
    public class ShopPage
    {
        private IWebDriver driver;
        private ElementHelper elementHelper;
       

        public ShopPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            elementHelper = new ElementHelper(driver);
         
        }

    

        public void AddItemToTheCart(string item)
        {
            string element = "//h4[contains(.,'" + item + "')]/following-sibling::p/a";
            elementHelper.GetElementByXPath(element).Click();
        }


       
    }
}